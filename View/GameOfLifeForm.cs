using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameOfLife
{
    /// <summary>
    ///   This class represents the application's main form.
    /// </summary>
    public partial class GameOfLifeForm : Form
    {
        bool[,] universe, scratchPad;
        int generations = 0;
        int generationsLimit = 0; // threshold enforced by "Run To..."
        int liveCells = 0;

        Timer timer = new Timer();

        public GameOfLifeForm()
        {
            InitializeComponent();
            Config.Seed = Math.Abs((int)DateTime.Now.Ticks);
            Config.Rng = new Random(Config.Seed);
            Config.LoadInitialConfig();
            ApplyConfig();

            timer.Tick += Timer_Tick;
            timer.Enabled = false;
        }

        /// <summary>
        ///   <para>Applies configuration information available
        ///   on Config (static) class to update the program.</para>
        ///   <see cref="Config"/> for more details.
        /// </summary>
        private void ApplyConfig()
        {
            scratchPad = new bool[Config.Height, Config.Width];

            if (universe == null)
                universe = new bool[Config.Height, Config.Width];

            for (int y = 0; y < scratchPad.GetLength(1) || y < universe.GetLength(1); y++)
                for (int x = 0; x < scratchPad.GetLength(0) || x < universe.GetLength(0); x++)
                    scratchPad[x, y] = universe[x, y];

            universe = new bool[Config.Height, Config.Width];

            for (int y = 0; y < universe.GetLength(1); y++)
                for (int x = 0; x < universe.GetLength(0); x++)
                    universe[x, y] = scratchPad[x, y];

            timer.Interval = Config.Interval;
            lblSeed.Text = "Seed: " + Config.Seed;
            lblBoundary.Text = "Boundary: " + Config.Boundary;

            gridVisibleToolStripMenuItem.Checked = Config.IsGridVisible;
            headsUpVisibleToolStripMenuItem.Checked = Config.IsHeadsUpDisplayVisible;
            neighborCountVisibleToolStripMenuItem.Checked = Config.IsNeighborCountVisible;

            graphicsPanel.Invalidate();
        }

        private void NeighborCountVisibleToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            Config.IsNeighborCountVisible = neighborCountVisibleToolStripMenuItem.Checked;
            graphicsPanel.Invalidate();
        }

        private void HeadsUpVisibleToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            Config.IsHeadsUpDisplayVisible = headsUpVisibleToolStripMenuItem.Checked;
            graphicsPanel.Invalidate();
        }

        private void GridVisibleToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            Config.IsGridVisible = gridVisibleToolStripMenuItem.Checked;
            graphicsPanel.Invalidate();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            NextGeneration();

            if (generations == generationsLimit)
                pauseToolStripMenuItem_Click(sender, e);
        }

        private void graphicsPanel_Paint(object sender, PaintEventArgs e)
        {
            float width = (float)graphicsPanel.ClientSize.Width / universe.GetLength(0);
            float height = (float)graphicsPanel.ClientSize.Height / universe.GetLength(1);

            liveCells = 0;

            SolidBrush liveCellBrush = new SolidBrush(Config.LiveCellColor);
            Pen gridPen = new Pen(Config.GridColor, 1);
            Pen gridTensPen = new Pen(Config.GridTensColor, 1);

            for (int y = 0; y < universe.GetLength(1); y++)
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    RectangleF r = new RectangleF(x * width, y * height, width, height);

                    if (universe[x, y])
                    {
                        e.Graphics.FillRectangle(liveCellBrush, r);
                        lblCells.Text = "Cells: " + (++liveCells);
                    }

                    if (Config.IsNeighborCountVisible)
                        ShowNeighborCount(r, CountNeighbors(x, y), e.Graphics);

                    if (Config.IsGridVisible)
                        e.Graphics.DrawRectangle(gridPen, r.X, r.Y, r.Width, r.Height);
                }

            if (Config.IsGridVisible)
                for (int y = 0; y < universe.GetLength(1); y += 10)
                    for (int x = 0; x < universe.GetLength(0); x += 10)
                        e.Graphics.DrawRectangle(gridTensPen, x * width, y * height, width * 10, height * 10);

            if (Config.IsHeadsUpDisplayVisible)
            {
                Font f = new Font("Courier New", 10f);
                float y = graphicsPanel.ClientSize.Height;
                float spacing = 15f;

                e.Graphics.DrawString("Universe Size: {Width=" + Config.Width + ", Height=" + Config.Height +"}", f, Brushes.Red, 2, y - spacing);
                e.Graphics.DrawString("Boundary Type: " + Config.Boundary, f, Brushes.Red, 2, y - 2 * spacing);
                e.Graphics.DrawString("Cell Count: " + liveCells, f, Brushes.Red, 2, y - 3 * spacing);
                e.Graphics.DrawString("Generations: " + generations, f, Brushes.Red, 2, y - 4 * spacing);
            }
        }

        /// <summary>
        ///   <para>This method displays the neighbor count for each
        ///   cell in its center whenever it is greater than zero.</para>
        ///   <para>If the cell is going to live in the next generation,
        ///   the number is shown in green; otherwise in red.</para>
        /// </summary>
        /// <param name="r">The cell that is going to display its count.</param>
        /// <param name="count">The cell's neighbor count.</param>
        /// <param name="g">Graphics object to draw to.</param>
        private void ShowNeighborCount(RectangleF r, int count, Graphics g)
        {
            if (count == 0)
                return;

            float width = (float)graphicsPanel.ClientSize.Width / universe.GetLength(0);
            float height = (float)graphicsPanel.ClientSize.Height / universe.GetLength(1);

            Brush b = (count < 2 || count > 3) ? Brushes.Red : Brushes.Green;
            Font font = new Font("Courier New", 0.5f * Math.Min(width, height));

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            g.DrawString(count.ToString(), font, b, r, sf);
        }

        private void DisplayHeadsUp(Font f, Brush b, Graphics g)
        {
            g.DrawString("Generations: " + generations, f, b, 0, 0);
        }

        private void graphicsPanel_MouseClick(object sender, MouseEventArgs e)
        {
            float width = (float)graphicsPanel.ClientSize.Width / universe.GetLength(0);
            float height = (float)graphicsPanel.ClientSize.Height / universe.GetLength(1);

            int x = (int)(e.X / width);
            int y = (int)(e.Y / height);

            universe[x, y] = !universe[x, y];

            graphicsPanel.Invalidate();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            pauseToolStripMenuItem.Enabled = true;
            pauseToolStripButton.Enabled = true;
            startToolStripMenuItem.Enabled = false;
            startToolStripButton.Enabled = false;
            runToToolStripMenuItem.Enabled = false;
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            pauseToolStripMenuItem.Enabled = false;
            pauseToolStripButton.Enabled = false;
            startToolStripMenuItem.Enabled = true;
            startToolStripButton.Enabled = true;
            runToToolStripMenuItem.Enabled = true;
        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < universe.GetLength(1); y++)
                for (int x = 0; x < universe.GetLength(0); x++)
                    universe[x, y] = false;

            lblGeneration.Text = "Generations: " + (generations = 0);
            lblCells.Text = "Cells: " + (liveCells = 0);

            if (pauseToolStripButton.Enabled)
                pauseToolStripMenuItem_Click(sender, e);

            graphicsPanel.Invalidate();
        }

        /// <summary>
        ///   This method applies the rules to decide
        ///   which cells live and die in the next generation.
        /// </summary>
        private void NextGeneration()
        {
            lblGeneration.Text = "Generations: " + (++generations);

            for (int y = 0; y < universe.GetLength(1); y++)
                for (int x = 0; x < universe.GetLength(0); x++)
                    if (universe[x, y]) // living cells
                    {
                        int neighbors = CountNeighbors(x, y);
                        if (neighbors < 2 || neighbors > 3) // die by loneliness or overcrowding
                            scratchPad[x, y] = false;
                        else
                            scratchPad[x, y] = true;
                    }
                    else // dead cells
                    {
                        if (CountNeighbors(x, y) == 3)
                            scratchPad[x, y] = true;
                    }

            universe = scratchPad;
            scratchPad = new bool[Config.Height, Config.Width];

            graphicsPanel.Invalidate();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void runToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunToDialog rtd = new RunToDialog(generations);

            if (rtd.ShowDialog() == DialogResult.OK)
            {
                generationsLimit = rtd.TargetGeneration;
                startToolStripMenuItem_Click(sender, e);
            }
        }

        private void fromTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomizeGrid(Math.Abs((int)DateTime.Now.Ticks));
        }

        private void RandomizeGrid(int? seed)
        {
            if (seed != null)
            {
                Config.Rng = new Random((int)seed);
                Config.Seed = (int)seed;
            }

            for (int y = 0; y < universe.GetLength(1); y++)
                for (int x = 0; x < universe.GetLength(0); x++)
                    universe[x, y] = (Config.Rng.Next() % 2 == 0);

            lblSeed.Text = "Seed: " + Config.Seed;
            graphicsPanel.Invalidate();
        }

        private void fromCurrentSeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomizeGrid(null);
        }

        private void fromNewSeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeedDialog sd = new SeedDialog(Config.Seed);
            if (sd.ShowDialog() == DialogResult.OK)
                RandomizeGrid(sd.Seed);
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config.LoadInitialConfig();
            ApplyConfig();
        }

        /// <summary>
        ///   Counts the neighbors of a given cell, considering a Finite universe.
        /// </summary>
        /// <param name="col">Cell's column number.</param>
        /// <param name="row">Cell's row number.</param>
        /// <returns>Returns the number of neighbors.</returns>
        private int CountNeighbors(int col, int row)
        {
            int neighbors = 0;

            for (int y = row - 1; (y <= row + 1) && (y < universe.GetLength(1)); y++)
                if (y >=0)
                    for (int x = col - 1; (x <= col + 1) && (x < universe.GetLength(0)); x++)
                        if (x >=0 )
                            if (x != col || y != row)
                                if (universe[x, y])
                                    neighbors++;
            
            return neighbors;
        }
    }
}
