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

namespace EmgucvDemo
{
    public partial class formBrightnessContrast : Form
    {

        public Image<Bgr, byte> ImgInput{ get; set; }
        Image<Bgr, byte> imgOutput;
        public formBrightnessContrast()
        {
            InitializeComponent();
        }

        private void formBrightnessContrast_Load(object sender, EventArgs e)
        {
            try
            {
                if (ImgInput==null)
                {
                    throw new Exception("Select an image.");
                }
                if (ImgInput!=null)
                {
                    pictureBox1.Image = ImgInput.AsBitmap();
                }

                lblCurrentBrightness.Text = trackBar2.Value.ToString();
                lblMinBrightness.Text = trackBar2.Minimum.ToString();
                lblMaxBrightness.Text = trackBar2.Maximum.ToString();


                lblMinContrast.Text =((float)trackBar1.Minimum/100).ToString();
                lblMaxContrast.Text = ((float)trackBar1.Maximum / 100).ToString();
                lblCurrentContrast.Text = ((float)trackBar1.Value / 100).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ContrastBrightnessAdjust()
        {
            try
            {
                lblCurrentContrast.Text = ((float)trackBar1.Value / 100).ToString();
                imgOutput =   ImgInput.Mul(double.Parse(lblCurrentContrast.Text)) + trackBar2.Value;
              pictureBox1.Image = imgOutput.AsBitmap();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            try
            {
                ContrastBrightnessAdjust();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            try
            {
                ContrastBrightnessAdjust();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp;";

            if (dialog.ShowDialog()==DialogResult.OK)
            {
                ImgInput = new Image<Bgr, byte>(dialog.FileName);
                pictureBox1.Image = ImgInput.AsBitmap();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (imgOutput==null)
                {
                    return;
                }
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Images (*.jpg;)|*.jpg;| Images (*.png;)| *.png;| Images (*.bmp)|*.bmp;";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imgOutput.Save(dialog.FileName);
                    MessageBox.Show("Image saved successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
