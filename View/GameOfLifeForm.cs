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
        float _cellWidth, _cellHeight;
        
        Timer timer = new Timer();
        GameOfLife _life = new GameOfLife();

        public GameOfLifeForm()
        {
            InitializeComponent();
            Config.LoadInitialConfig();
            _life.UpdateFromConfig();
            UpdateFromConfig();

            timer.Tick += Timer_Tick;
            timer.Enabled = false;
        }

        /// <summary>
        ///   <para>Applies configuration information available
        ///   on Config (static) class to update the form.</para>
        ///   <see cref="Config"/> for more details.
        /// </summary>
        private void UpdateFromConfig()
        {
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
            _life.NextGeneration();
            graphicsPanel.Invalidate();

            if (_life.HasReachedLimit)
                pauseToolStripMenuItem_Click(sender, e);
        }

        private void graphicsPanel_Paint(object sender, PaintEventArgs e)
        {
            _cellWidth = (float)graphicsPanel.ClientSize.Width / _life.Universe.GetLength(0);
            _cellHeight = (float)graphicsPanel.ClientSize.Height / _life.Universe.GetLength(1);

            _life.LiveCells = 0;

            for (int y = 0; y < _life.Universe.GetLength(1); y++)
                for (int x = 0; x < _life.Universe.GetLength(0); x++)
                {
                    RectangleF r = new RectangleF(x * _cellWidth, y * _cellHeight, _cellWidth, _cellHeight);

                    if (_life.Universe[x, y])
                    {
                        e.Graphics.FillRectangle(new SolidBrush(Config.LiveCellColor), r);
                        ++_life.LiveCells;
                    }

                    if (Config.IsNeighborCountVisible)
                        ShowNeighborCount(r, _life.CountNeighbors(x, y), e.Graphics);
                }

            if (Config.IsGridVisible) DrawGrid(e.Graphics);
            if (Config.IsHeadsUpDisplayVisible) ShowHeadsUpDisplay(e.Graphics);

            lblCells.Text = "Cells: " + _life.LiveCells;
            lblGeneration.Text = "Generations: " + _life.Generations;
        }

        private void DrawGrid(Graphics g)
        {
            Pen gridPen = new Pen(Config.GridColor, 1);
            Pen gridTensPen = new Pen(Config.GridTensColor, 1);

            for (int y = 0; y < _life.Universe.GetLength(1); ++y)
                g.DrawLine(gridPen, 0, y * _cellHeight, Config.Width * _cellWidth, y * _cellHeight);

            for (int x = 0; x < _life.Universe.GetLength(0); ++x)
                g.DrawLine(gridPen, x * _cellWidth, 0, x * _cellWidth, Config.Height * _cellHeight);

            for (int y = 0; y < _life.Universe.GetLength(1); y += 10)
                g.DrawLine(gridTensPen, 0, y * _cellHeight, Config.Width * _cellWidth, y * _cellHeight);

            for (int x = 0; x < _life.Universe.GetLength(0); x += 10)
                g.DrawLine(gridTensPen, x * _cellWidth, 0, x * _cellWidth, Config.Height * _cellHeight);
        }

        private void ShowHeadsUpDisplay(Graphics g)
        {
            Font f = new Font("Courier New", 10f);
            float y = graphicsPanel.ClientSize.Height;
            float spacing = 15f;

            g.DrawString("Universe Size: {Width=" + Config.Width + ", Height=" + Config.Height + "}", f, Brushes.Red, 2, y - spacing);
            g.DrawString("Boundary Type: " + Config.Boundary, f, Brushes.Red, 2, y - 2 * spacing);
            g.DrawString("Cell Count: " + _life.LiveCells, f, Brushes.Red, 2, y - 3 * spacing);
            g.DrawString("Generations: " + _life.Generations, f, Brushes.Red, 2, y - 4 * spacing);
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

            Brush b = (count < 2 || count > 3) ? Brushes.Red : Brushes.Green;
            Font font = new Font("Courier New", 0.5f * Math.Min(_cellWidth, _cellHeight));

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            g.DrawString(count.ToString(), font, b, r, sf);
        }

        private void graphicsPanel_MouseClick(object sender, MouseEventArgs e)
        {
            int x = (int)(e.X / _cellWidth);
            int y = (int)(e.Y / _cellHeight);

            _life.Universe[x, y] = !_life.Universe[x, y];

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
            nextToolStripButton.Enabled = false;
            nextToolStripMenuItem.Enabled = false;
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            pauseToolStripMenuItem.Enabled = false;
            pauseToolStripButton.Enabled = false;
            startToolStripMenuItem.Enabled = true;
            startToolStripButton.Enabled = true;
            runToToolStripMenuItem.Enabled = true;
            nextToolStripButton.Enabled = true;
            nextToolStripMenuItem.Enabled = true;
        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _life.NextGeneration();
            graphicsPanel.Invalidate();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < _life.Universe.GetLength(1); y++)
                for (int x = 0; x < _life.Universe.GetLength(0); x++)
                    _life.Universe[x, y] = false;

            lblGeneration.Text = "Generations: " + (_life.Generations = 0);
            lblCells.Text = "Cells: " + (_life.LiveCells = 0);

            if (pauseToolStripButton.Enabled)
                pauseToolStripMenuItem_Click(sender, e);

            graphicsPanel.Invalidate();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void runToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunToDialog rtd = new RunToDialog(_life.Generations);

            if (rtd.ShowDialog() == DialogResult.OK)
            {
                _life.GenerationsLimit = rtd.TargetGeneration;
                startToolStripMenuItem_Click(sender, e);
            }
        }

        private void fromTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _life.RandomizeGrid(Math.Abs((int)DateTime.Now.Ticks));
            lblSeed.Text = "Seed: " + Config.Seed;
            graphicsPanel.Invalidate();
        }

        private void fromCurrentSeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _life.RandomizeGrid(null);
            lblSeed.Text = "Seed: " + Config.Seed;
            graphicsPanel.Invalidate();
        }

        private void fromNewSeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeedDialog sd = new SeedDialog(Config.Seed);
            if (sd.ShowDialog() == DialogResult.OK)
            {
                _life.RandomizeGrid(sd.Seed);
                lblSeed.Text = "Seed: " + Config.Seed;
                graphicsPanel.Invalidate();
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config.LoadInitialConfig();
            UpdateFromConfig();
        }
    }
}
