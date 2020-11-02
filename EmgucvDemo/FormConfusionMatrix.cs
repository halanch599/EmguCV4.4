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
    public partial class FormConfusionMatrix : Form
    {
        public FormConfusionMatrix( int[,] CM,string txt="")
        {
            InitializeComponent();
            rtbSummary.Text = txt;
            dgvConfusionMatrix.DataSource = HelperClass.Array2DataTable(CM);
        }
    }
}
