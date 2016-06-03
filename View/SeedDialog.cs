using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class SeedDialog : Form
    {
        public int Seed { get; set; }

        public SeedDialog(int seed)
        {
            InitializeComponent();
            nudSeed.Maximum = int.MaxValue;
            nudSeed.Minimum = int.MinValue;
            nudSeed.Value = Seed = seed;
        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {
            nudSeed.Value = Seed = Config.Rng.Next();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Seed = (int)nudSeed.Value;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
