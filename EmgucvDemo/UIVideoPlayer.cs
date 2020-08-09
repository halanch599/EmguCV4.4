using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using System.IO;
using Emgu.CV.Structure;

namespace EmgucvDemo
{
    public partial class UIVideoPlayer : UserControl
    {

        VideoCapture videoCapture;
        int CurrentFrame = 0;
        int TotalFrames = 0;
        int skip = 5;
        bool IsPlaying = false;
        CascadeClassifier classifier;
        private static UIVideoPlayer _intstance;
        private UIVideoPlayer() { }
        //{
        //    InitializeComponent();
        //}

        public static UIVideoPlayer GetInstance(string path)
        {
            _intstance = null;
            _intstance = new UIVideoPlayer();
            _intstance.init(path);
            return _intstance;

        }

        private void init(string path)
        {
            InitializeComponent();
            try
            {
                videoCapture = new VideoCapture(path);
                if (videoCapture == null) return;

                Mat frame = new Mat();
                TotalFrames = int.Parse(videoCapture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameCount).ToString());
                trackBar1.Value = CurrentFrame;
                trackBar1.Minimum = 0;
                trackBar1.Maximum = TotalFrames;
                lblCurrentFrame.Text = trackBar1.Value.ToString();
                lblFrameCount.Text = TotalFrames.ToString();

                string facePath = Path.GetFullPath(@"../../data/haarcascade_frontalface_default.xml");
                classifier = new CascadeClassifier(facePath);

                if (CurrentFrame<TotalFrames)
                {
                    if (videoCapture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames,CurrentFrame))
                    {
                        videoCapture.Read(frame);
                        pictureBox1.Image = frame.ToBitmap();
                        CurrentFrame++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblCurrentFrame.Text = trackBar1.Value.ToString();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (button1.Text=="Play")
                {
                    Mat frame = new Mat();
                    button1.Text = "Pause";
                    IsPlaying = true;

                    while (IsPlaying==true && trackBar1.Value<TotalFrames)
                    {
                        if (videoCapture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames,trackBar1.Value))
                        {
                            videoCapture.Read(frame);
                            pictureBox1.Image = ProcessFrame(frame).AsBitmap();

                            lblCurrentFrame.Text = trackBar1.Value.ToString();
                            if (trackBar1.Value+skip<=trackBar1.Maximum)
                            {
                                trackBar1.Value = trackBar1.Value + skip;
                            }
                            else
                            {
                                trackBar1.Value = trackBar1.Maximum;
                            }
                        }

                        await Task.Delay(1);
                    }

                }
                else
                {
                    button1.Text = "Play";
                    IsPlaying = false;
                    if (videoCapture!=null)
                    {
                        videoCapture.Pause();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Image<Bgr, byte> ProcessFrame(Mat frame)
        {
            try
            {
                var imgBGR = frame.ToImage<Bgr, byte>();
                var imgGray = imgBGR.Convert<Gray, byte>();
                var faces = classifier.DetectMultiScale(imgGray);

                foreach (var rect in faces)
                {
                    imgBGR.ROI = rect;
                    //imgBGR._SmoothGaussian();
                    imgBGR.SetValue(new Bgr(0, 0, 0));
                    imgBGR.ROI = Rectangle.Empty;
                }
                return imgBGR;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
