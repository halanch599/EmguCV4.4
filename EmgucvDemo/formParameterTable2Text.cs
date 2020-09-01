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
    public partial class formParameterTable2Text : Form
    {

        public delegate void DelegateTable2Text(int NoCols, float MorphThrehold,int binaryThreshold, int offset);
        public event DelegateTable2Text OnApplyTable2Text;

        public formParameterTable2Text(int NoCols, float MorphThrehold, int binaryThreshold, int offset)
        {
            InitializeComponent();
            tbNoCols.Text = NoCols.ToString();
            tbMorphThreshold.Text = MorphThrehold.ToString();
            tbBinaryThreshold.Text = binaryThreshold.ToString();
            tboffset.Text = offset.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OnApplyTable2Text?.Invoke(
                    int.Parse(tbNoCols.Text),
                    float.Parse(tbMorphThreshold.Text),
                    int.Parse(tbBinaryThreshold.Text),
                    int.Parse(tboffset.Text)
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
