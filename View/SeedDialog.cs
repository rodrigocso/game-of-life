using System;
using System.Windows.Forms;

namespace GameOfLife
{
    /// <summary>
    ///   A dialog where a user can type a
    ///   custom seed or generate a random one.
    /// </summary>
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
        
        /// <summary>
        ///   Fills the Numeric Up Down with a random integer.
        /// </summary>
        private void btnRandomize_Click(object sender, EventArgs e)
        {
            nudSeed.Value = Seed = Config.Rng.Next();
        }
    }
}
