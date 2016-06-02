using System;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class RunToDialog : Form
    {
        public int TargetGeneration { get; set; }

        public RunToDialog(int currentGeneration)
        {
            InitializeComponent();
            nudRunTo.Minimum = currentGeneration;
            nudRunTo.Maximum = int.MaxValue;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            TargetGeneration = (int)nudRunTo.Value;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
