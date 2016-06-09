using System;
using System.Windows.Forms;

namespace GameOfLife
{
    /// <summary>
    ///   <para>Menu > Run > Run To...</para>
    /// </summary>
    public partial class RunToDialog : Form
    {
        // Run until this generation is reached.
        public int TargetGeneration { get; set; }

        public RunToDialog(int currentGeneration)
        {
            InitializeComponent();
            // It must not be possible to set the target
            // generation to a past generation.
            nudRunTo.Minimum = currentGeneration;
            nudRunTo.Maximum = int.MaxValue;
        }
    }
}
