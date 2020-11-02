using Emgu.CV.ML;
using EmgucvDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmgucvDemo
{
    public partial class FormANNParameters : Form
    {

        public  delegate void AnnDelegate (ANN_MLP.AnnMlpActivationFunction annMlpActivationFunction,
            ANN_MLP.AnnMlpTrainMethod TrainMethod,
            float Momentum,
            int Iterations,
            float RMSE,
            int[] Layers,
            bool LoadSavedModel);
        public event AnnDelegate OnApplyANN;

        public FormANNParameters()
        {
            InitializeComponent();
        }

        private void FormANNParameters_Load(object sender, EventArgs e)
        {
            try
            {
                FillDropDownList();
                LoadConfiguration();
            }
            catch (Exception)
            {

            }

        }

        private void LoadConfiguration()
        {
            try
            {
                cbActivationFunction.SelectedIndex = int.Parse(HelperClass.ReadConfigParameters("ActivationFunction"));
                cbTrainedMethod.SelectedIndex = int.Parse(HelperClass.ReadConfigParameters("TrainMethod"));
                tbMomentum.Text = HelperClass.ReadConfigParameters("Momentum");
                tbIterations.Text = HelperClass.ReadConfigParameters("Iterations");
                tbRMSE.Text = HelperClass.ReadConfigParameters("RMSE");
                tbLayerSize.Text = HelperClass.ReadConfigParameters("LayerSize");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void FillDropDownList()
        {
            List<string> list = new List<string>() { "SigmoidSym", "Gaussian", "Identity", "LeakyRelu", "Relu" };
            cbActivationFunction.DataSource = list;
            cbActivationFunction.SelectedIndex = 0;

            list = new List<string>() { "Backprop", "Rprop", "Anneal" };
            cbTrainedMethod.DataSource = list;
            cbTrainedMethod.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                var ActivationFunction = ANN_MLP.AnnMlpActivationFunction.SigmoidSym;
                var TrainMethod = ANN_MLP.AnnMlpTrainMethod.Backprop;
                float Momentum = 0.5f;
                int iterations = 500;
                float RMSE = 0.001f;

                switch (cbActivationFunction.SelectedIndex)
                {
                    case 0:
                        ActivationFunction = ANN_MLP.AnnMlpActivationFunction.SigmoidSym;
                        break;

                    case 1:
                        ActivationFunction = ANN_MLP.AnnMlpActivationFunction.Gaussian;
                        break;
                    case 2:
                        ActivationFunction = ANN_MLP.AnnMlpActivationFunction.Identity;
                        break;
                    case 3:
                        ActivationFunction = ANN_MLP.AnnMlpActivationFunction.LeakyRelu;
                        break;
                    case 4:
                        ActivationFunction = ANN_MLP.AnnMlpActivationFunction.Relu;
                        break;
                    default:
                        ActivationFunction = ANN_MLP.AnnMlpActivationFunction.SigmoidSym;
                        break;
                }

                switch (cbTrainedMethod.SelectedIndex)
                {
                    case 0:
                        TrainMethod = ANN_MLP.AnnMlpTrainMethod.Backprop;
                        break;

                    case 1:
                        TrainMethod = ANN_MLP.AnnMlpTrainMethod.Rprop;
                        break;
                    case 2:
                        TrainMethod = ANN_MLP.AnnMlpTrainMethod.Anneal;
                        break;
                    default:
                        TrainMethod = ANN_MLP.AnnMlpTrainMethod.Backprop;
                        break;
                }

                int.TryParse(tbIterations.Text, out iterations);
                float.TryParse(tbRMSE.Text, out RMSE);
                float.TryParse(tbMomentum.Text, out Momentum);

                int[] LayerSize = Array.ConvertAll(tbLayerSize.Text.Split(','), s => int.Parse(s));
                OnApplyANN?.Invoke(ActivationFunction, TrainMethod, Momentum, iterations, RMSE, LayerSize, cbSaveModel.Checked);

                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                HelperClass.WriteConfigParameters("ActivationFunction", cbActivationFunction.SelectedIndex.ToString());
                HelperClass.WriteConfigParameters("TrainMethod", cbTrainedMethod.SelectedIndex.ToString());
                HelperClass.WriteConfigParameters("Momentum", tbMomentum.Text);
                HelperClass.WriteConfigParameters("RMSE", tbRMSE.Text);
                HelperClass.WriteConfigParameters("LayerSize", tbLayerSize.Text);
                HelperClass.WriteConfigParameters("Iterations", tbIterations.Text);

                lblMessage.Text = "Configuration information saved.";
                lblMessage.ForeColor = Color.Green;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
