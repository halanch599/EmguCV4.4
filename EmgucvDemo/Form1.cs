using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Features2D;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.CV.Flann;
using Emgu.CV.Cuda;
using System.Runtime.InteropServices;
using Emgu.CV.UI;

namespace EmgucvDemo
{
    public partial class Form1 : Form
    {
        Dictionary<string, Image<Bgr, byte>> imgList;
        Rectangle rect;
        Point StartROI;
        bool Selecting, MouseDown;
        public Form1()
        {
            InitializeComponent();
            Selecting = false;
            rect = Rectangle.Empty;
            imgList = new Dictionary<string, Image<Bgr, byte>>();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                imgList.Clear();
                OpenFileDialog dialog = new OpenFileDialog();
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    var img = new Image<Bgr, byte>(dialog.FileName);
                    AddImage(img, "Input");
                    pictureBox1.Image = img.AsBitmap();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddImage(Image<Bgr, byte> img, string keyname )
        {
            if(!treeView1.Nodes.ContainsKey(keyname))
            {
                TreeNode node = new TreeNode(keyname);
                node.Name = keyname;
                treeView1.Nodes.Add(node);
                treeView1.SelectedNode = node;
            }

            if(!imgList.ContainsKey(keyname))
            {
                imgList.Add(keyname, img);
            }
            else
            {
                imgList[keyname] = img;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(Selecting)
            {
                MouseDown = true;
                StartROI = e.Location;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(Selecting)
            {
                int width = Math.Max(StartROI.X, e.X) - Math.Min(StartROI.X, e.X);
                int height = Math.Max(StartROI.Y, e.Y) - Math.Min(StartROI.Y, e.Y);
                rect = new Rectangle(Math.Min(StartROI.X, e.X),
                    Math.Min(StartROI.Y, e.Y),
                    width,
                    height);
                Refresh();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if(MouseDown)
            {
                using (Pen pen = new Pen(Color.Red, 3))
                {
                    e.Graphics.DrawRectangle(pen, rect);
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if(Selecting)
            {
                Selecting = false;
                MouseDown = false;
            }
        }

        private void getRegionOfROIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image == null)
                    return;

                if (rect == Rectangle.Empty)
                    return;

                var img = new Bitmap(pictureBox1.Image).ToImage<Bgr, byte>();

                img.ROI = rect;
                var imgROI = img.Copy();
                img.ROI = Rectangle.Empty;

                pictureBox1.Image = imgROI.ToBitmap();
                AddImage(imgROI, "ROI Image");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                pictureBox1.Image = imgList[e.Node.Text].AsBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void selectROIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Selecting = true;
        }

        private void gaussianBlurROIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image == null)
                    return;

                if (rect == Rectangle.Empty)
                    return;

                var img = new Bitmap(pictureBox1.Image)
                    .ToImage<Bgr, byte>();

                img.ROI = rect;
                var img2 = img.Copy();
                var imgSmooth = img2.SmoothGaussian(25);

                img.SetValue(new Bgr(1, 1, 1));
                img._Mul(imgSmooth);

                img.ROI = Rectangle.Empty;
                pictureBox1.Image = img.AsBitmap();

                AddImage(img, "GaussianBlur");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cannyEdgesROIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image == null)
                    return;

                if (rect == Rectangle.Empty)
                    return;

                var img = new Bitmap(pictureBox1.Image)
                    .ToImage<Bgr, byte>();

                img.ROI = rect;
                var img2 = img.Copy();
                var imgCanny = img2.SmoothGaussian(5).Canny(100,50);
                var imgBgr = imgCanny.Convert<Bgr, byte>();

                img.SetValue(new Bgr(1, 1, 1));
                img._Mul(imgBgr);

                img.ROI = Rectangle.Empty;

                pictureBox1.Image = img.AsBitmap();
                AddImage(img, "Canny Edge");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void matchingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image==null || rect ==null)
                {
                    return;
                }

                var imgScene = imgList["Input"].Clone();
                var template = new Bitmap(pictureBox1.Image)
                    .ToImage<Bgr, byte>();


                Mat imgout = new Mat();

                CvInvoke.MatchTemplate(imgScene, template, imgout, Emgu.CV.CvEnum.TemplateMatchingType.CcorrNormed);

                double minVal = 0.0;
                double maxVal = 0.0;
                Point minLoc = new Point();
                Point maxLoc = new Point();

                CvInvoke.MinMaxLoc(imgout, ref minVal, ref maxVal, ref minLoc, ref maxLoc);
                Rectangle r = new Rectangle(maxLoc, template.Size);
                CvInvoke.Rectangle(imgScene, r, new MCvScalar(255, 0, 0), 3);
                pictureBox1.Image = imgScene.AsBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void resizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(!imgList.ContainsKey("ROI Image"))
                {
                    MessageBox.Show("Please select a template");
                    return;
                }

                var img = new Bitmap(pictureBox1.Image)
                    .ToImage<Bgr, byte>();

                img = img.Resize(1.25, Emgu.CV.CvEnum.Inter.Cubic);
                pictureBox1.Image = img.AsBitmap();
                AddImage(img, "Template Resized");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rotationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!imgList.ContainsKey("ROI Image"))
                {
                    MessageBox.Show("Please select a template");
                    return;
                }

                var img = new Bitmap(pictureBox1.Image)
                    .ToImage<Bgr, byte>();

                img = img.Rotate(90, new Bgr(0, 0, 0), false);
                pictureBox1.Image = img.AsBitmap();
                AddImage(img, "Template Rotated");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void multiScaleTemplateMatchingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image==null || rect ==null)
                {
                    return;
                }

                var imgScene = imgList["Input"].Clone();
                var template = new Bitmap(pictureBox1.Image)
                    .ToImage<Bgr, byte>();
                // multiscale logic

                Rectangle r = Rectangle.Empty;
                double GlobalminVal = float.MaxValue;

                for (float scale = 0.5f;  scale <=1.50;  scale+=0.25f)
                {
                    var temp = template.Resize(scale, Emgu.CV.CvEnum.Inter.Cubic);
                    Mat imgout = new Mat();
                    CvInvoke.MatchTemplate(imgScene, temp, imgout, Emgu.CV.CvEnum.TemplateMatchingType.Sqdiff);

                    double minval = 0;
                    double maxval = 0;
                    Point minloc = new Point();
                    Point maxloc = new Point();

                    CvInvoke.MinMaxLoc(imgout, ref minval, ref maxval, ref minloc, ref maxloc);

                    double prob = minval / (imgout.ToImage<Gray, byte>().GetSum().Intensity);

                    if(prob<GlobalminVal)
                    {
                        GlobalminVal = prob;
                        r = new Rectangle(minloc, temp.Size);
                    }
                }

                if (r!=null)
                {
                    CvInvoke.Rectangle(imgScene, r, new MCvScalar(255, 0, 0), 3);
                    pictureBox1.Image = imgScene.AsBitmap();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void featureMatchingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private static VectorOfPoint ProcessImage(Image<Gray,byte> template, Image<Gray, byte> sceneImage)
        {
            try
            {
                // initialization
                VectorOfPoint finalPoints = null;
                Mat homography = null;
                VectorOfKeyPoint templateKeyPoints = new VectorOfKeyPoint();
                VectorOfKeyPoint sceneKeyPoints = new VectorOfKeyPoint();
                Mat tempalteDescriptor = new Mat();
                Mat sceneDescriptor = new Mat();

                Mat mask;
                int k = 2;
                double uniquenessthreshold = 0.80;
                VectorOfVectorOfDMatch matches = new VectorOfVectorOfDMatch();

                // feature detectino and description
                Brisk featureDetector = new Brisk();
                featureDetector.DetectAndCompute(template, null, templateKeyPoints, tempalteDescriptor, false);
                featureDetector.DetectAndCompute(sceneImage, null, sceneKeyPoints, sceneDescriptor, false);

                // Matching
                BFMatcher matcher = new BFMatcher(DistanceType.Hamming);
                matcher.Add(tempalteDescriptor);
                matcher.KnnMatch(sceneDescriptor, matches, k);

                mask = new Mat(matches.Size, 1, Emgu.CV.CvEnum.DepthType.Cv8U, 1);
                mask.SetTo(new MCvScalar(255));

                Features2DToolbox.VoteForUniqueness(matches, uniquenessthreshold, mask);

               int count =  Features2DToolbox.VoteForSizeAndOrientation(templateKeyPoints, sceneKeyPoints, matches, mask, 1.5, 20);

                if(count>=4)
                {
                    homography = Features2DToolbox.GetHomographyMatrixFromMatchedFeatures(templateKeyPoints,
                        sceneKeyPoints, matches, mask, 5);
                }

                if (homography!=null)
                {
                    Rectangle rect = new Rectangle(Point.Empty, template.Size);
                    PointF[] pts = new PointF[]
                    {
                        new PointF(rect.Left,rect.Bottom),
                        new PointF(rect.Right,rect.Bottom),
                        new PointF(rect.Right,rect.Top),
                        new PointF(rect.Left,rect.Top)
                    };

                    pts = CvInvoke.PerspectiveTransform(pts, homography);
                    Point[] points = Array.ConvertAll<PointF, Point>(pts, Point.Round);
                    finalPoints = new VectorOfPoint(points);
                }

                return finalPoints;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private void bFMatcherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image == null || !imgList.ContainsKey("Input"))
                {
                    return;
                }

                var imgScene = imgList["Input"].Clone();
                var template = new Bitmap(pictureBox1.Image)
                    .ToImage<Gray, byte>();

                var vp = ProcessImage(template, imgScene.Convert<Gray, byte>());
                if (vp != null)
                {
                    CvInvoke.Polylines(imgScene, vp, true, new MCvScalar(0, 0, 255), 5);
                }

                pictureBox1.Image = imgScene.AsBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fLANNMatcherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image == null || !imgList.ContainsKey("Input"))
                {
                    return;
                }

                var imgScene = imgList["Input"].Clone();
                var template = new Bitmap(pictureBox1.Image)
                    .ToImage<Gray, byte>();

                var vp = ProcessImageFLANN(template, imgScene.Convert<Gray, byte>());
                if (vp != null)
                {
                    CvInvoke.Polylines(imgScene, vp, true, new MCvScalar(0, 0, 255), 5);
                }

                pictureBox1.Image = imgScene.AsBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static VectorOfPoint ProcessImageFLANN(Image<Gray, byte> template, Image<Gray, byte> sceneImage)
        {
            try
            {
                // initializations done
                VectorOfPoint finalPoints = null;
                Mat homography = null;
                VectorOfKeyPoint templateKeyPoints = new VectorOfKeyPoint();
                VectorOfKeyPoint sceneKeyPoints = new VectorOfKeyPoint();
                Mat tempalteDescriptor = new Mat();
                Mat sceneDescriptor = new Mat();

                Mat mask;
                int k = 2;
                double uniquenessthreshold = 0.80;
                VectorOfVectorOfDMatch matches = new VectorOfVectorOfDMatch();

                // feature detectino and description
                KAZE featureDetector = new KAZE();
                featureDetector.DetectAndCompute(template, null, templateKeyPoints, tempalteDescriptor, false);
                featureDetector.DetectAndCompute(sceneImage, null, sceneKeyPoints, sceneDescriptor, false);


                // Matching

                //KdTreeIndexParams ip = new KdTreeIndexParams();
                //var ip = new AutotunedIndexParams();
                var ip = new LinearIndexParams();
                SearchParams sp = new SearchParams();
                FlannBasedMatcher matcher = new FlannBasedMatcher(ip, sp);


                matcher.Add(tempalteDescriptor);
                matcher.KnnMatch(sceneDescriptor, matches, k);

                mask = new Mat(matches.Size, 1, Emgu.CV.CvEnum.DepthType.Cv8U, 1);
                mask.SetTo(new MCvScalar(255));

                Features2DToolbox.VoteForUniqueness(matches, uniquenessthreshold, mask);

                int count = Features2DToolbox.VoteForSizeAndOrientation(templateKeyPoints, sceneKeyPoints, matches, mask, 1.5, 20);

                if (count >= 4)
                {
                    homography = Features2DToolbox.GetHomographyMatrixFromMatchedFeatures(templateKeyPoints,
                        sceneKeyPoints, matches, mask, 5);
                }

                if (homography != null)
                {
                    Rectangle rect = new Rectangle(Point.Empty, template.Size);
                    PointF[] pts = new PointF[]
                    {
                        new PointF(rect.Left,rect.Bottom),
                        new PointF(rect.Right,rect.Bottom),
                        new PointF(rect.Right,rect.Top),
                        new PointF(rect.Left,rect.Top)
                    };

                    pts = CvInvoke.PerspectiveTransform(pts, homography);
                    Point[] points = Array.ConvertAll<PointF, Point>(pts, Point.Round);
                    finalPoints = new VectorOfPoint(points);
                }

                return finalPoints;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private void harrisDetectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ApplyHarisCorner();
                formHarisParameters parameters = new formHarisParameters(0, 255, 200);
                parameters.OnApply += ApplyHarisCorner;
                parameters.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ApplyHarisCorner(int threshold =200)
        {
            try
            {
                if (imgList["Input"] == null)
                {
                    return;
                }

                var img = imgList["Input"].Clone();
                var gray = img.Convert<Gray, byte>();

                var corners = new Mat();
                CvInvoke.CornerHarris(gray, corners, 2);
                CvInvoke.Normalize(corners, corners, 255, 0, Emgu.CV.CvEnum.NormType.MinMax);

                Matrix<float> matrix = new Matrix<float>(corners.Rows, corners.Cols);
                corners.CopyTo(matrix);

                for (int i = 0; i < matrix.Rows; i++)
                {
                    for (int j = 0; j < matrix.Cols; j++)
                    {
                        if (matrix[i, j] > threshold)
                        {
                            CvInvoke.Circle(img, new Point(j, i), 5, new MCvScalar(0, 0, 255), 3);
                        }
                    }
                }

                pictureBox1.Image = img.AsBitmap();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void shiTomasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (imgList["Input"] == null)
                {
                    return;
                }

                var img = imgList["Input"].Clone();
                var gray = img.Convert<Gray, byte>();

                GFTTDetector detector = new GFTTDetector(2000,0.06);
                var corners = detector.Detect(gray);

                Mat outimg = new Mat();
                Features2DToolbox.DrawKeypoints(img, new VectorOfKeyPoint(corners), outimg, new Bgr(0, 0, 255));

                pictureBox1.Image = outimg.ToBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fASTDetectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ApplyFASTFeatureDetector();
                formHarisParameters parameters = new formHarisParameters(0, 15, 10);
                parameters.OnApply += ApplyFASTFeatureDetector;
                parameters.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ApplyFASTFeatureDetector(int threshold=10)
        {
            try
            {
                if(imgList["Input"]==null)
                {
                    return;
                }

                var img = imgList["Input"].Clone();
                var gray = img.Convert<Gray, byte>();

                FastFeatureDetector detector = new FastFeatureDetector(threshold);
                var corners = detector.Detect(gray);

                Mat outimg = new Mat();
                Features2DToolbox.DrawKeypoints(img, new VectorOfKeyPoint(corners), outimg, new Bgr(0, 0, 255));

                pictureBox1.Image = outimg.ToBitmap();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void oRBDetectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (imgList["Input"] == null)
                {
                    return;
                }

                var img = imgList["Input"].Clone();
                var gray = img.Convert<Gray, byte>();

                ORBDetector detector = new ORBDetector();
                var corners = detector.Detect(gray);

                Mat outimg = new Mat();
                Features2DToolbox.DrawKeypoints(img, new VectorOfKeyPoint(corners), outimg, new Bgr(0, 0, 255));

                pictureBox1.Image = outimg.ToBitmap();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mSERDetectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (imgList["Input"] == null)
                {
                    return;
                }

                var img = imgList["Input"].Clone();
                var gray = img.Convert<Gray, byte>();

                MSERDetector detector = new MSERDetector();
                var corners = detector.Detect(gray);

                Mat outimg = new Mat();
                Features2DToolbox.DrawKeypoints(img, new VectorOfKeyPoint(corners), outimg, new Bgr(0, 0, 255));

                pictureBox1.Image = outimg.ToBitmap();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void findContoursSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image == null) return;

                var img = new Bitmap(pictureBox1.Image).ToImage<Bgr, byte>();

                var gray = img.Convert<Gray, byte>()
                    .ThresholdBinaryInv(new Gray(240), new Gray(255));

                // contours
                VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
                Mat h = new Mat();

                CvInvoke.FindContours(gray, contours, h, Emgu.CV.CvEnum.RetrType.External
                    , Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);


                VectorOfPoint approx = new VectorOfPoint();

                Dictionary<int, double> shapes = new Dictionary<int, double>();

                for (int i = 0; i < contours.Size; i++)
                {
                    approx.Clear();
                    double perimeter = CvInvoke.ArcLength(contours[i], true);
                    CvInvoke.ApproxPolyDP(contours[i], approx, 0.04 * perimeter, true);
                    double area = CvInvoke.ContourArea(contours[i]);

                    if(approx.Size>6)
                    {
                        shapes.Add(i, area);
                    }
                }


                if (shapes.Count>0)
                {
                    var sortedShapes = (from item in shapes
                                        orderby item.Value ascending
                                        select item).ToList();

                    for (int i = 0; i < sortedShapes.Count; i++)
                    {
                        CvInvoke.DrawContours(img, contours, sortedShapes[i].Key, new MCvScalar(0, 0, 255), 2);
                        var moments = CvInvoke.Moments(contours[sortedShapes[i].Key]);
                        int x = (int)(moments.M10 / moments.M00);
                        int y = (int)(moments.M01 / moments.M00);

                        CvInvoke.PutText(img, (i + 1).ToString(), new Point(x, y), Emgu.CV.CvEnum.FontFace.HersheyTriplex, 1.0,
                            new MCvScalar(0, 0, 255), 2);
                        CvInvoke.PutText(img, sortedShapes[i].Value.ToString(), new Point(x, y-30), Emgu.CV.CvEnum.FontFace.HersheyTriplex, 1.0,
                            new MCvScalar(0, 0, 255), 2);
                    }

                }

                pictureBox1.Image = img.ToBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image == null) return;

                var img = new Bitmap(pictureBox1.Image).ToImage<Bgr, byte>();
                img._SmoothGaussian(5);

                Bgr lower = new Bgr(0, 100, 0);
                Bgr higher = new Bgr(100, 255, 50);

                var mask = img.InRange(lower, higher).Not();
                img.SetValue(new Bgr(0, 0, 0), mask);
                pictureBox1.Image = img.AsBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image == null) return;

                var img = new Bitmap(pictureBox1.Image).ToImage<Bgr, byte>();
                img._SmoothGaussian(5);

                Bgr lower = new Bgr(0, 0, 150);
                Bgr higher = new Bgr(50, 50, 255);

                var mask = img.InRange(lower, higher).Not();
                img.SetValue(new Bgr(0, 0, 0), mask);
                pictureBox1.Image = img.AsBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void multiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image == null) return;
                if (rect == null) return;

                ApplyMultiObjectDetectionTM();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ApplyMultiObjectDetectionTM(float threshold = 0.1f)
        {
            try
            {
                var imgScene = imgList["Input"].Clone();
                var template = new Bitmap(pictureBox1.Image).ToImage<Bgr, byte>();

                Mat imgOut = new Mat();
                CvInvoke.MatchTemplate(imgScene, template, imgOut, Emgu.CV.CvEnum.TemplateMatchingType.Sqdiff);

                Mat imgOutNorm = new Mat();
        
                CvInvoke.Normalize(imgOut, imgOutNorm, 0, 1, Emgu.CV.CvEnum.NormType.MinMax, Emgu.CV.CvEnum.DepthType.Cv64F);

                Matrix<double> matches = new Matrix<double>(imgOutNorm.Size);
                imgOutNorm.CopyTo(matches);

                double minValue = 0, maxVal = 0;
                Point minLoc = new Point();
                Point maxLoc = new Point();

                do
                {
                    CvInvoke.MinMaxLoc(matches, ref minValue, ref maxVal, ref minLoc, ref maxLoc);
                    Rectangle r = new Rectangle(minLoc, template.Size);
                    CvInvoke.Rectangle(imgScene, r, new MCvScalar(255, 0, 0), 1);

                    matches[minLoc.Y, minLoc.X] = 0.5;
                    matches[maxLoc.Y, maxLoc.X] = 0.5;
                } while (minValue <= threshold);

                pictureBox1.Image = imgScene.AsBitmap();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void colorBasedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void filledObjectDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image == null) return;
                var img = new Bitmap(pictureBox1.Image).ToImage<Bgr, byte>();
                var gray = img.Convert<Gray, byte>()
                    .SmoothGaussian(5)
                    .ThresholdBinaryInv(new Gray(250), new Gray(255));

                VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
                Mat h = new Mat();

                CvInvoke.FindContours(gray, contours, h, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
                var mask = gray.CopyBlank();
                for (int i = 0; i < contours.Size; i++)
                {
                    var area = CvInvoke.ContourArea(contours[i]);
                    if (area>100)
                    {
                        var bbox = CvInvoke.BoundingRectangle(contours[i]);
                        gray.ROI = bbox;
                        mask.ROI = bbox;
                        var count = gray.GetSum().Intensity / 255;
                        //var count2 = gray.CountNonzero();
                        float percentage = (float)count / (bbox.Width*bbox.Height);

                        if(percentage<0.5f)
                        {
                            gray.CopyTo(mask);
                        }
                        gray.ROI = Rectangle.Empty;
                        mask.ROI = Rectangle.Empty;
                    }
                }
                img.SetValue(new Bgr(255, 255, 255), mask);
                AddImage(img, "Filtered Image");
                pictureBox1.Image = img.AsBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void detectObjectsWithHolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int threshold = 10;
                if (pictureBox1.Image == null) return;

                var img = new Bitmap(pictureBox1.Image).ToImage<Gray, byte>()
                    .SmoothGaussian(3);
                var gray = img.ThresholdBinaryInv(new Gray(200), new Gray(255));

                VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
                Mat mat = new Mat();
                CvInvoke.FindContours(gray, contours, mat, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);

                var mask = gray.CopyBlank();

                for (int i = 0; i < contours.Size; i++)
                {
                    var area = CvInvoke.ContourArea(contours[i]);
                    if (area>50)
                    {
                        var bbox = CvInvoke.BoundingRectangle(contours[i]);
                        CvInvoke.DrawContours(mask, contours, i, new MCvScalar(255), -1);

                        gray.ROI = bbox;
                        mask.ROI = bbox;

                        var grayNonZero = gray.CountNonzero();
                        var maskNonZero = mask.CountNonzero();

                        gray.ROI = Rectangle.Empty;
                        mask.ROI = Rectangle.Empty;
                        

                        int diff = Math.Abs(grayNonZero[0] - maskNonZero[0]);
                        

                        if (diff<=threshold)
                        {
                            mask._Dilate(2);
                            img.SetValue(new Gray(255), mask);
                        }

                        mask.SetZero();
                    }
                }
                AddImage(img.Convert<Bgr, byte>(), "Objects with Holes");
                pictureBox1.Image = img.ToBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void countHolesİnObjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image == null) return;

                var img = new Bitmap(pictureBox1.Image).ToImage<Gray, byte>()
                    .SmoothGaussian(3);
                var gray = img.ThresholdBinaryInv(new Gray(200), new Gray(255));

                VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
                Mat mat = new Mat();
                CvInvoke.FindContours(gray, contours, mat, Emgu.CV.CvEnum.RetrType.Tree, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
                int[] hierarchy = mat.GetData(false).Cast<int>().ToArray();
                var mask = img.CopyBlank();

                for (int i = 0; i < contours.Size; i++)
                {
                    var area = CvInvoke.ContourArea(contours[i]);
                    if (area>50)
                    {
                        var Parent = hierarchy[(i * 4) + 3];

                        if (Parent==-1)
                        {
                            // count the contours inside
                            var count = hierarchy.Where((p, j) => ((j + 1) % 4 == 0) && p == i).Count();
                            var bbox = CvInvoke.BoundingRectangle(contours[i]);
                            bbox.Y -= 5;
                            CvInvoke.PutText(img, "Holes = " + count.ToString(), bbox.Location,
                                Emgu.CV.CvEnum.FontFace.HersheyPlain, 1.0, new MCvScalar(0));
                        }
                    }
                }

                AddImage(img.Convert<Bgr, byte>(), "Holes Object");
                pictureBox1.Image = img.AsBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calculateToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image==null)
                {
                    return;
                }

                var img = new Bitmap(pictureBox1.Image)
                    .ToImage<Gray,byte>();

                Mat hist = new Mat();
                float[] ranges = new float[] { 0, 255 };
                int[] channel = { 0 };
                int[] histSize = { 256 };

                VectorOfMat ms = new VectorOfMat();
                ms.Push(img);

                CvInvoke.CalcHist(ms, channel, null, hist, histSize, ranges, false);

                HistogramViewer viewer = new HistogramViewer();
                viewer.Text = "Image Histogram";
                viewer.ShowIcon = false;
                viewer.HistogramCtrl.AddHistogram("Image Histogram", Color.Blue, hist,
                    histSize[0], ranges);
                viewer.HistogramCtrl.Refresh();
                viewer.Show();

                // sroting the histogram 
                var array = hist.GetData();
                var list = array.Cast<Single>().Select(c => (int)c).ToArray();
                var dictionary = list.Select((v, j) => new { Key = j, Value = v })
                    .ToDictionary(o => o.Key, o => o.Value);

                var sorted = dictionary.OrderByDescending(x => x.Value).ToList();
                int N = 20;
                List<int> selected = new List<int>();
                for (int i = 0; i < N; i++)
                {
                    selected.Add(sorted[i].Key);
                }

                Image<Gray, byte> img2 = img.Convert<byte>(delegate (byte b)
                {
                    return selected.Contains((int)b) ? b : (byte)0;
                });

                pictureBox1.Image = img2.AsBitmap();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void binarizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                formHarisParameters form = new formHarisParameters(0, 255, 100);
                form.OnApply += ApplyThreshold;
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ApplyThreshold(int x)
        {
            try
            {
                if (imgList["Input"]==null)
                {
                    return;
                }

                var img = imgList["Input"].Convert<Gray, byte>().Clone();
                var output = img.ThresholdBinary(new Gray(x), new Gray(255));
                pictureBox1.Image = output.AsBitmap();
                AddImage(output.Convert<Bgr, byte>(), "Thresholding");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void histogramEqualizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image==null)
                {
                    return;
                }

                var img = new Bitmap(pictureBox1.Image)
                    .ToImage<Gray, byte>();
                Mat histeq = new Mat();
                CvInvoke.EqualizeHist(img, histeq);
                pictureBox1.Image = histeq.ToBitmap();
                AddImage(histeq.ToImage<Bgr, byte>(), "Histogram Equalization");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cLAHEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image == null)
                {
                    return;
                }

                var img = new Bitmap(pictureBox1.Image)
                    .ToImage<Gray, byte>();
                Mat output = new Mat();
                CvInvoke.CLAHE(img, 50, new Size(8, 8), output);
                pictureBox1.Image = output.ToBitmap();
                AddImage(output.ToImage<Bgr, byte>(), "CLAHE");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backpropagationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void watershedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image == null) return;

                var img = new Bitmap(pictureBox1.Image)
                    .ToImage<Bgr, byte>();
                var mask = img.Convert<Gray, byte>()
                    .ThresholdBinaryInv(new Gray(150), new Gray(255));
                Mat distanceTransofrm = new Mat();
                CvInvoke.DistanceTransform(mask, distanceTransofrm, null, Emgu.CV.CvEnum.DistType.L2, 3);
                CvInvoke.Normalize(distanceTransofrm, distanceTransofrm, 0, 255, Emgu.CV.CvEnum.NormType.MinMax);
                var markers = distanceTransofrm.ToImage<Gray, byte>()
                    .ThresholdBinary(new Gray(50), new Gray(255));
                CvInvoke.ConnectedComponents(markers, markers);
                var finalMarkers = markers.Convert<Gray, Int32>();

                CvInvoke.Watershed(img, finalMarkers);

                Image<Gray, byte> boundaries = finalMarkers.Convert<byte>(delegate (Int32 x)
                {
                    return (byte)(x==-1?255:0);
                });

                boundaries._Dilate(1);
                img.SetValue(new Bgr(0, 255, 0), boundaries);
                AddImage(img, "Watershed Segmentation");
                pictureBox1.Image = img.ToBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backprojectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image == null) return;
                if (rect == null) return;

                var imgScene = imgList["Input"].Clone();
                var imgObject = new Bitmap(pictureBox1.Image)
                    .ToImage<Gray, byte>();

                Mat histObject = new Mat();

                float[] ranges = new float[] {0,255 };
                int[] channel = { 0 };
                int[] histSize = { 256 };

                var msScene = new VectorOfMat();
                msScene.Push(imgScene);

                var msObject = new VectorOfMat();
                msObject.Push(imgObject);

                CvInvoke.CalcHist(msObject, channel, null, histObject, histSize, ranges, false);
                CvInvoke.Normalize(histObject, histObject, 0, 255, Emgu.CV.CvEnum.NormType.MinMax);

                Mat proj = new Mat();
                CvInvoke.CalcBackProject(msScene, channel, histObject, proj, ranges);

                var kernel = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Ellipse,
                    new Size(5, 5), new Point(-1, -1));
                CvInvoke.Filter2D(proj, proj, kernel, new Point(-1, -1));

                var binary = proj.ToImage<Gray, byte>()
                    .ThresholdBinary(new Gray(50), new Gray(255))
                    .Mat;

                var rgb = imgScene.CopyBlank();

                VectorOfMat vm = new VectorOfMat();
                vm.Push(binary);
                vm.Push(binary);
                vm.Push(binary);

                CvInvoke.Merge(vm,rgb.Mat);

                var output = new Mat();
                CvInvoke.BitwiseAnd(rgb, imgScene, output);

                pictureBox1.Image = output.ToBitmap();
                AddImage(output.ToImage<Bgr, byte>(), "Back Projection");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
