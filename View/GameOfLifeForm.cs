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
        
        // font size and spacing for DPI awareness.
        float _neighborCountFontMultiplier, _hudLineSpacing;
        const float FontSizeMultiplierHighDPI = 0.3f;
        const float FontSizeMultiplierLowDPI = 0.5f;
        const float LineSpacingHighDPI = 32f;
        const float LineSpacingLowDPI = 16f;
        
        Timer timer = new Timer();
        Life _life = new Life();

        public GameOfLifeForm()
        {
            InitializeComponent();
            Config.LoadCurrentConfig();
            _life.UpdateFromConfig();
            UpdateFromConfig();

            if (Config.IsProcessHighDPI)
            {
                _neighborCountFontMultiplier = FontSizeMultiplierHighDPI;
                _hudLineSpacing = LineSpacingHighDPI;
            }
            else
            {
                _neighborCountFontMultiplier = FontSizeMultiplierLowDPI;
                _hudLineSpacing = LineSpacingLowDPI;
            }

            timer.Tick += Timer_Tick;
            timer.Enabled = false;
        }

        /// <summary>
        ///   <para>Applies configuration information available
        ///   on <see cref="Config"/> class to update the form.</para>
        /// </summary>
        private void UpdateFromConfig()
        {
            timer.Interval = Config.Interval;
            lblSeed.Text = "Seed: " + Config.Seed;
            lblBoundary.Text = "Boundary: " + Config.Boundary;

            GridVisibleToolStripMenuItem_Click(null, null);
            NeighborCountVisibleToolStripMenuItem_Click(null, null);
            HeadsUpVisibleToolStripMenuItem_Click(null, null);

            graphicsPanel.BackColor = Config.BackgroundColor;
            graphicsPanel.Invalidate();
        }

        /// <summary>
        ///   <para>Menu > View > Neighbor Count</para>
        ///   <para>Turns on the neighbor count visualization.</para>
        /// </summary>
        private void NeighborCountVisibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender != null)
                Config.IsNeighborCountVisible = !Config.IsNeighborCountVisible;

            neighborCountVisibleToolStripMenuItem.Checked = ctxMenuViewNeighborCount.Checked = Config.IsNeighborCountVisible;

            if (Config.IsNeighborCountVisible)
            {
                neighborCountVisibleToolStripMenuItem.Image = Properties.Resources.Check;
                ctxMenuViewNeighborCount.Image = Properties.Resources.Check;
            }
            else
            {
                neighborCountVisibleToolStripMenuItem.Image = Properties.Resources.Transparent;
                ctxMenuViewNeighborCount.Image = Properties.Resources.Transparent;
            }

            graphicsPanel.Invalidate();
        }

        /// <summary>
        ///   Menu > View > Heads Up Display.
        /// </summary>
        private void HeadsUpVisibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender != null)
                Config.IsHeadsUpDisplayVisible = !Config.IsHeadsUpDisplayVisible;

            headsUpVisibleToolStripMenuItem.Checked = ctxMenuViewHUD.Checked = Config.IsHeadsUpDisplayVisible;

            if (Config.IsHeadsUpDisplayVisible)
            {
                headsUpVisibleToolStripMenuItem.Image = Properties.Resources.Check;
                ctxMenuViewHUD.Image = Properties.Resources.Check;
            }
            else
            {
                headsUpVisibleToolStripMenuItem.Image = Properties.Resources.Transparent;
                ctxMenuViewHUD.Image = Properties.Resources.Transparent;
            }

            graphicsPanel.Invalidate();
        }

        /// <summary>
        ///   Menu > View > Grid.
        /// </summary>
        private void GridVisibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender != null)
                Config.IsGridVisible = !Config.IsGridVisible;

            gridVisibleToolStripMenuItem.Checked = ctxMenuViewGrid.Checked = Config.IsGridVisible;

            if (Config.IsGridVisible)
            {
                gridVisibleToolStripMenuItem.Image = Properties.Resources.Check;
                ctxMenuViewGrid.Image = Properties.Resources.Check;
            }
            else
            {
                gridVisibleToolStripMenuItem.Image = Properties.Resources.Transparent;
                ctxMenuViewGrid.Image = Properties.Resources.Transparent;
            }

            graphicsPanel.Invalidate();
        }

        /// <summary>
        ///   With each interval, update GoL Universe's generation.
        /// </summary>
        /// <see cref="Config.Interval"/>
        private void Timer_Tick(object sender, EventArgs e)
        {
            _life.NextGeneration();
            graphicsPanel.Invalidate();

            if (_life.HasReachedLimit)
                pauseToolStripMenuItem_Click(sender, e);
        }

        /// <summary>
        ///   Display current Game of Life Universe state
        ///   on the graphics panel.
        /// </summary>
        private void graphicsPanel_Paint(object sender, PaintEventArgs e)
        {
            _cellHeight = (float)graphicsPanel.ClientSize.Height / _life.Universe.GetLength(0);
            _cellWidth = (float)graphicsPanel.ClientSize.Width / _life.Universe.GetLength(1);

            _life.LiveCells = 0;

            for (int row = 0; row < _life.Universe.GetLength(0); row++)
                for (int col = 0; col < _life.Universe.GetLength(1); col++)
                {
                    RectangleF r = new RectangleF(col * _cellWidth, row * _cellHeight, _cellWidth, _cellHeight);

                    if (_life.Universe[row, col])
                    {
                        e.Graphics.FillRectangle(new SolidBrush(Config.LiveCellColor), r);
                        ++_life.LiveCells;
                    }

                    if (Config.IsNeighborCountVisible)
                        ShowNeighborCount(r, _life.CountNeighbors(row, col), _life.Universe[row, col], e.Graphics);
                }

            if (Config.IsGridVisible) DrawGrid(e.Graphics);
            if (Config.IsHeadsUpDisplayVisible) ShowHeadsUpDisplay(e.Graphics);

            lblCells.Text = "Cells: " + _life.LiveCells;
            lblGeneration.Text = "Generations: " + _life.Generations;
        }

        /// <summary>
        ///   Draw grid lines on Graphics Panel.
        /// </summary>
        /// <param name="g">PaintEventArgs.Graphics</param>
        private void DrawGrid(Graphics g)
        {
            Pen gridPen = new Pen(Config.GridColor, 1);
            Pen gridTensPen = new Pen(Config.GridTensColor, 1);

            for (int col = 0; col < _life.Universe.GetLength(1); ++col)
                g.DrawLine(gridPen, col * _cellWidth, 0, col * _cellWidth, Config.Height * _cellHeight);

            for (int row = 0; row < _life.Universe.GetLength(0); ++row)
                g.DrawLine(gridPen, 0, row * _cellHeight, Config.Width * _cellWidth, row * _cellHeight);

            for (int col = 0; col < _life.Universe.GetLength(1); col += 10)
                g.DrawLine(gridTensPen, col * _cellWidth, 0, col * _cellWidth, Config.Height * _cellHeight);

            for (int row = 0; row < _life.Universe.GetLength(0); row += 10)
                g.DrawLine(gridTensPen, 0, row * _cellHeight, Config.Width * _cellWidth, row * _cellHeight);
        }

        /// <summary>
        ///   Draw the HUD on Graphics Panel.
        /// </summary>
        /// <param name="g">PaintEventArgs.Graphics</param>
        private void ShowHeadsUpDisplay(Graphics g)
        {
            Font f = new Font("Segoe UI", 9f);
            float h = graphicsPanel.ClientSize.Height;

            g.DrawString("Universe Size: {Width=" + Config.Width + ", Height=" + Config.Height + "}", f, Brushes.Red, 2, h - _hudLineSpacing);
            g.DrawString("Boundary Type: " + Config.Boundary, f, Brushes.Red, 2, h - 2 * _hudLineSpacing);
            g.DrawString("Cell Count: " + _life.LiveCells, f, Brushes.Red, 2, h - 3 * _hudLineSpacing);
            g.DrawString("Generations: " + _life.Generations, f, Brushes.Red, 2, h - 4 * _hudLineSpacing);
        }

        /// <summary>
        ///   <para>This method displays the neighbor count for each
        ///   cell in its center whenever it is greater than zero.</para>
        ///   <para>If the cell is going to live in the next generation,
        ///   the number is shown in green; otherwise in red.</para>
        /// </summary>
        /// <param name="r">The cell that is going to display its count.</param>
        /// <param name="count">The cell's neighbor count.</param>
        /// <param name="isAlive">The cell's status.</param>
        /// <param name="g">Graphics object to draw to.</param>
        private void ShowNeighborCount(RectangleF r, int count, bool isAlive, Graphics g)
        {
            if (count == 0)
                return;

            Brush b = (count < 2 || count > 3) ? Brushes.Red : (isAlive || count == 3) ? Brushes.Green : Brushes.Red;
            Font font = new Font("Segoe UI", _neighborCountFontMultiplier * Math.Min(_cellWidth, _cellHeight));

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            g.DrawString(count.ToString(), font, b, r, sf);
        }

        /// <summary>
        ///   Whenever the Graphics Panel is clicked,
        ///   locate the cell chosen by user and flip
        ///   its state.
        /// </summary>
        private void graphicsPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int row = (int)(e.Y / _cellHeight);
                int col = (int)(e.X / _cellWidth);

                _life.Universe[row, col] = !_life.Universe[row, col];

                graphicsPanel.Invalidate();
            }
        }

        /// <summary>
        ///   <para>Menu > Run > Start or toolbar button Start.</para>
        ///   <para>Start the Game of Life, so it changes to next
        ///   generation until the user pauses or closes the app.</para>
        /// </summary>
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            pauseToolStripMenuItem.Enabled = true;
            pauseToolStripButton.Enabled = true;
            ctxMenuPause.Enabled = true;
            startToolStripMenuItem.Enabled = false;
            startToolStripButton.Enabled = false;
            ctxMenuStart.Enabled = false;
            runToToolStripMenuItem.Enabled = false;
            nextToolStripButton.Enabled = false;
            nextToolStripMenuItem.Enabled = false;
            ctxMenuNext.Enabled = false;
        }

        /// <summary>
        ///   <para>Menu > Run > Pause or toolbar button Pause.</para>
        ///   <para>Pauses the Game of Life.</para>
        /// </summary>
        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            pauseToolStripMenuItem.Enabled = false;
            pauseToolStripButton.Enabled = false;
            ctxMenuPause.Enabled = false;
            startToolStripMenuItem.Enabled = true;
            startToolStripButton.Enabled = true;
            ctxMenuStart.Enabled = true;
            runToToolStripMenuItem.Enabled = true;
            nextToolStripButton.Enabled = true;
            nextToolStripMenuItem.Enabled = true;
            ctxMenuNext.Enabled = true;
        }

        /// <summary>
        ///   <para>Menu > Run > Next or toolbar button Next.</para>
        ///   <para>Advance GoL Universe to next generation.</para>
        /// </summary>
        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _life.NextGeneration();
            graphicsPanel.Invalidate();
        }

        /// <summary>
        ///   <para>Menu > File > New or toolbar button New.</para>
        ///   <para>Clear the Graphics Panel and reset GoL to
        ///   initial state. If the game is running, stops it.</para>
        /// </summary>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int col = 0; col < _life.Universe.GetLength(1); col++)
                for (int row = 0; row < _life.Universe.GetLength(0); row++)
                    _life.Universe[row, col] = false;

            lblGeneration.Text = "Generations: " + (_life.Generations = 0);
            lblCells.Text = "Cells: " + (_life.LiveCells = 0);

            if (pauseToolStripButton.Enabled)
                pauseToolStripMenuItem_Click(sender, e);

            graphicsPanel.Invalidate();
        }

        /// <summary>
        ///   <para>Menu > File > Exit</para>
        ///   <para>Close the application.</para>
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        ///   Before the application closes, the settings must be saved.
        /// </summary>
        private void GameOfLifeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Config.Save();
        }

        /// <summary>
        ///   <para>Menu > File > Run > Run To...</para>
        ///   <para>Pop up a dialog where the user specifies
        ///   until which generation Life should go.</para>
        /// </summary>
        private void runToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunToDialog rtd = new RunToDialog(_life.Generations);

            if (rtd.ShowDialog() == DialogResult.OK)
            {
                _life.GenerationsLimit = rtd.TargetGeneration;
                startToolStripMenuItem_Click(sender, e);
            }
        }

        /// <summary>
        ///   <para>Menu > Tools > Randomize > From Time</para>
        ///   <para>Randomize GoL Universe seeding the PRNG with
        ///   the current time.</para>
        /// </summary>
        private void fromTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _life.RandomizeGrid(Math.Abs((int)DateTime.Now.Ticks));
            lblSeed.Text = "Seed: " + Config.Seed;
            graphicsPanel.Invalidate();
        }

        /// <summary>
        ///   <para>Menu > Tools > Randomize > From Current Seed</para>
        ///   <para>Randomize GoL Universe without changing the 
        ///   PRNG seed.</para>
        /// </summary>
        private void fromCurrentSeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _life.RandomizeGrid(null);
            lblSeed.Text = "Seed: " + Config.Seed;
            graphicsPanel.Invalidate();
        }

        /// <summary>
        ///   <para>Menu > Tools > Randomize > From New Seed</para>
        ///   <para>Pop up a dialog to ask the user to provide
        ///   a seed for the PRNG, then randomize the GoL Universe.</para>
        /// </summary>
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

        /// <summary>
        ///   <para>Menu > File > Save or toolbar button Save</para>
        ///   <para>Pop a dialog to save the current Universe
        ///   to a Cells File.</para>
        ///   <see cref="CellsFile.Save(string, Life)"/>
        /// </summary>
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Cells|*.cells";
            sfd.Title = "Save";

            if (sfd.ShowDialog() == DialogResult.OK)
                new CellsFile().Save(sfd.FileName, _life);
        }

        /// <summary>
        ///   <para>Menu > File > Open or toolbar button Open</para>
        ///   <para>Pop a dialog to load a Universe state from
        ///   a Cells File.</para>
        ///   <see cref="CellsFile.Open(string, Life)"/>
        /// </summary>
        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Cells|*.cells";

            if (ofd.ShowDialog() == DialogResult.OK)
                new CellsFile().Open(ofd.FileName, _life);

            graphicsPanel.Invalidate();
        }

        /// <summary>
        ///   <para>Menu > File > Import</para>
        ///   <para>Pop a dialog to import a pattern to the 
        ///   current Universe from a Cells File.</para>
        ///   <see cref="CellsFile.Import(string, Life)"/>
        /// </summary>
        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Cells|*.cells";
            ofd.Title = "Import";

            if (ofd.ShowDialog() == DialogResult.OK)
                new CellsFile().Import(ofd.FileName, _life);

            graphicsPanel.Invalidate();
        }

        /// <summary>
        ///   <para>Menu > Tools > Settings > Reload Previous</para>
        ///   <para>Reload the application to the previous settings,
        ///   which means the settings that were active when the
        ///   current session began.</para>
        /// </summary>
        private void reloadPreviousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config.Load(Config.Configuration.Previous);
            UpdateFromConfig();
            _life.UpdateFromConfig();
            graphicsPanel.Invalidate();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }

        /// <summary>
        ///   <para>Menu > Tools > Reset Options</para>
        ///   <para>Reset to application to default settings.</para>
        ///   <see cref="Config.LoadCurrentConfig()"/>
        /// </summary>
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config.Load(Config.Configuration.Default);
            _life.UpdateFromConfig();
            UpdateFromConfig();
        }

        /// <summary>
        ///   <para>Menu > Tools > Options</para>
        ///   <para>Pop a dialog where the user can customize the
        ///   application appearance and behavior.</para>
        /// </summary>
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionsDialog od = new OptionsDialog();

            if (od.ShowDialog() == DialogResult.OK)
            {
                _life.UpdateFromConfig();
                UpdateFromConfig();
                graphicsPanel.Invalidate();
            }
        }
    }
}
