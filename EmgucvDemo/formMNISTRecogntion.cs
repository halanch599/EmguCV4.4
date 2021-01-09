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
using Emgu.CV.Structure;
using Emgu.CV.Dnn;

namespace EmgucvDemo
{
    public partial class formMNISTRecogntion : Form
    {
        //Point StartPosition = Point.Empty;
        bool isMouseDown = false;
        Net model = null;
        public formMNISTRecogntion()
        {
            InitializeComponent();
        }

        private void loadONNXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "ONNX Files (*.onnx;)|*.onnx;";
                if (dialog.ShowDialog()==DialogResult.OK)
                {
                    model = DnnInvoke.ReadNetFromONNX(dialog.FileName);
                    lblMessage.Text = "Model Loaded.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //StartPosition = e.Location;
            isMouseDown = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            //StartPosition = Point.Empty;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (isMouseDown==true )
                {
                    if (pictureBox1.Image==null)
                    {
                        Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                        pictureBox1.Image = bm;
                    }

                    using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                    {
                        g.FillEllipse(Brushes.Black, e.X, e.Y, 15, 15);
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    }
                    pictureBox1.Invalidate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image!=null)
            {
                pictureBox1.Image = null;
                pictureBox1.Invalidate();
                lblDigit.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image==null)
                {
                    throw new Exception("Draw a digit.");
                }

                if (model==null)
                {
                    throw new Exception("Load the ONNX model.");
                }

                Bitmap bm = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
                pictureBox1.DrawToBitmap(bm, pictureBox1.ClientRectangle);

                var img = bm.ToImage<Gray, byte>()
                    .Not()
                    .SmoothGaussian(3)
                    .Resize(28, 28, Emgu.CV.CvEnum.Inter.Cubic)
                    .Mul(1/255.0f);

                var input = DnnInvoke.BlobFromImage(img);
                model.SetInput(input);
                var output = model.Forward();

                float[] array = new float[10];
                output.CopyTo(array);

                var prob = SoftMax(array);
                int index= Array.IndexOf(prob, prob.Max());
                lblDigit.Text = index.ToString();

                chart1.Series.Clear();
                chart1.Titles.Clear();

                chart1.Series.Add("Hist");
                chart1.Titles.Add("Probabilities");

                for (int i = 0; i < prob.Length; i++)
                {
                    chart1.Series["Hist"].Points.AddXY(i, prob[i]);
                }

                //pictureBox1.Image = img.AsBitmap();
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        private float[] SoftMax(float []arr)
        {
            var exp = (from a in arr
                       select (float)Math.Exp(a))
                      .ToArray();
            var sum = exp.Sum();

            return exp.Select(x => x / sum).ToArray();

        }
    }
}
