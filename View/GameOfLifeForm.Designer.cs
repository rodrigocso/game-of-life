namespace GameOfLife
{
    partial class GameOfLifeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOfLifeForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gridVisibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headsUpVisibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neighborCountVisibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.fromTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromCurrentSeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromNewSeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.startToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pauseToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.nextToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblGeneration = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCells = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSeed = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblBoundary = new System.Windows.Forms.ToolStripStatusLabel();
            this.graphicsPanel = new GameOfLife.GraphicsPanel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator3,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 38);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(260, 38);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Enabled = false;
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(260, 38);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(257, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(260, 38);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(257, 6);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Enabled = false;
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(260, 38);
            this.printPreviewToolStripMenuItem.Text = "&Import";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(257, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(260, 38);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gridVisibleToolStripMenuItem,
            this.headsUpVisibleToolStripMenuItem,
            this.neighborCountVisibleToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(78, 38);
            this.toolStripMenuItem1.Text = "&View";
            // 
            // gridVisibleToolStripMenuItem
            // 
            this.gridVisibleToolStripMenuItem.CheckOnClick = true;
            this.gridVisibleToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gridVisibleToolStripMenuItem.Name = "gridVisibleToolStripMenuItem";
            this.gridVisibleToolStripMenuItem.Size = new System.Drawing.Size(365, 38);
            this.gridVisibleToolStripMenuItem.Text = "&Grid Visible";
            this.gridVisibleToolStripMenuItem.CheckedChanged += new System.EventHandler(this.GridVisibleToolStripMenuItem_CheckedChanged);
            // 
            // headsUpVisibleToolStripMenuItem
            // 
            this.headsUpVisibleToolStripMenuItem.CheckOnClick = true;
            this.headsUpVisibleToolStripMenuItem.Name = "headsUpVisibleToolStripMenuItem";
            this.headsUpVisibleToolStripMenuItem.Size = new System.Drawing.Size(365, 38);
            this.headsUpVisibleToolStripMenuItem.Text = "&Heads Up Visible";
            this.headsUpVisibleToolStripMenuItem.CheckedChanged += new System.EventHandler(this.HeadsUpVisibleToolStripMenuItem_CheckedChanged);
            // 
            // neighborCountVisibleToolStripMenuItem
            // 
            this.neighborCountVisibleToolStripMenuItem.CheckOnClick = true;
            this.neighborCountVisibleToolStripMenuItem.Name = "neighborCountVisibleToolStripMenuItem";
            this.neighborCountVisibleToolStripMenuItem.Size = new System.Drawing.Size(365, 38);
            this.neighborCountVisibleToolStripMenuItem.Text = "&Neighbor Count Visible";
            this.neighborCountVisibleToolStripMenuItem.CheckedChanged += new System.EventHandler(this.NeighborCountVisibleToolStripMenuItem_CheckedChanged);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.nextToolStripMenuItem,
            this.runToToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(69, 38);
            this.toolStripMenuItem2.Text = "&Run";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.startToolStripMenuItem.Size = new System.Drawing.Size(216, 38);
            this.startToolStripMenuItem.Text = "&Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Enabled = false;
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(216, 38);
            this.pauseToolStripMenuItem.Text = "&Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(216, 38);
            this.nextToolStripMenuItem.Text = "&Next";
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.nextToolStripMenuItem_Click);
            // 
            // runToToolStripMenuItem
            // 
            this.runToToolStripMenuItem.Name = "runToToolStripMenuItem";
            this.runToToolStripMenuItem.Size = new System.Drawing.Size(216, 38);
            this.runToToolStripMenuItem.Text = "Run &To...";
            this.runToToolStripMenuItem.Click += new System.EventHandler(this.runToToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.toolsToolStripMenuItem.Enabled = false;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(82, 38);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromTimeToolStripMenuItem,
            this.fromCurrentSeedToolStripMenuItem,
            this.fromNewSeedToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(234, 38);
            this.toolStripMenuItem3.Text = "&Randomize";
            // 
            // fromTimeToolStripMenuItem
            // 
            this.fromTimeToolStripMenuItem.Name = "fromTimeToolStripMenuItem";
            this.fromTimeToolStripMenuItem.Size = new System.Drawing.Size(317, 38);
            this.fromTimeToolStripMenuItem.Text = "From &Time";
            // 
            // fromCurrentSeedToolStripMenuItem
            // 
            this.fromCurrentSeedToolStripMenuItem.Name = "fromCurrentSeedToolStripMenuItem";
            this.fromCurrentSeedToolStripMenuItem.Size = new System.Drawing.Size(317, 38);
            this.fromCurrentSeedToolStripMenuItem.Text = "From &Current Seed";
            // 
            // fromNewSeedToolStripMenuItem
            // 
            this.fromNewSeedToolStripMenuItem.Name = "fromNewSeedToolStripMenuItem";
            this.fromNewSeedToolStripMenuItem.Size = new System.Drawing.Size(317, 38);
            this.fromNewSeedToolStripMenuItem.Text = "From &New Seed";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Enabled = false;
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(234, 38);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(234, 38);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.reloadToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(234, 38);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(187, 38);
            this.resetToolStripMenuItem.Text = "&Reset";
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(187, 38);
            this.reloadToolStripMenuItem.Text = "Re&load";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator7,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Enabled = false;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 38);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Enabled = false;
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(211, 38);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Enabled = false;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(211, 38);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Enabled = false;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(211, 38);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(208, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(211, 38);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.startToolStripButton,
            this.pauseToolStripButton,
            this.nextToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 42);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1064, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Enabled = false;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Enabled = false;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // startToolStripButton
            // 
            this.startToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.startToolStripButton.Image = global::GameOfLife.Properties.Resources.Run_16x;
            this.startToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startToolStripButton.Name = "startToolStripButton";
            this.startToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.startToolStripButton.Text = "C&ut";
            this.startToolStripButton.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // pauseToolStripButton
            // 
            this.pauseToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pauseToolStripButton.Enabled = false;
            this.pauseToolStripButton.Image = global::GameOfLife.Properties.Resources.Pause_16x;
            this.pauseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pauseToolStripButton.Name = "pauseToolStripButton";
            this.pauseToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pauseToolStripButton.Text = "&Copy";
            this.pauseToolStripButton.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // nextToolStripButton
            // 
            this.nextToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nextToolStripButton.Image = global::GameOfLife.Properties.Resources.Next_16x;
            this.nextToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nextToolStripButton.Name = "nextToolStripButton";
            this.nextToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.nextToolStripButton.Text = "&Paste";
            this.nextToolStripButton.Click += new System.EventHandler(this.nextToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblGeneration,
            this.lblCells,
            this.lblSeed,
            this.lblBoundary});
            this.statusStrip1.Location = new System.Drawing.Point(0, 823);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1064, 37);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblGeneration
            // 
            this.lblGeneration.Name = "lblGeneration";
            this.lblGeneration.Size = new System.Drawing.Size(158, 32);
            this.lblGeneration.Text = "Generation: 0";
            // 
            // lblCells
            // 
            this.lblCells.Name = "lblCells";
            this.lblCells.Size = new System.Drawing.Size(90, 32);
            this.lblCells.Text = "Cells: 0";
            // 
            // lblSeed
            // 
            this.lblSeed.Name = "lblSeed";
            this.lblSeed.Size = new System.Drawing.Size(93, 32);
            this.lblSeed.Text = "Seed: 0";
            // 
            // lblBoundary
            // 
            this.lblBoundary.Name = "lblBoundary";
            this.lblBoundary.Size = new System.Drawing.Size(188, 32);
            this.lblBoundary.Text = "Boundary: Finite";
            // 
            // graphicsPanel
            // 
            this.graphicsPanel.BackColor = System.Drawing.SystemColors.Window;
            this.graphicsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphicsPanel.Location = new System.Drawing.Point(0, 67);
            this.graphicsPanel.Name = "graphicsPanel";
            this.graphicsPanel.Size = new System.Drawing.Size(1064, 756);
            this.graphicsPanel.TabIndex = 3;
            this.graphicsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.graphicsPanel_Paint);
            this.graphicsPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel_MouseClick);
            // 
            // GameOfLifeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1064, 860);
            this.Controls.Add(this.graphicsPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameOfLifeForm";
            this.Text = "Game Of Life";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblGeneration;
        private System.Windows.Forms.ToolStripStatusLabel lblCells;
        private System.Windows.Forms.ToolStripStatusLabel lblSeed;
        private System.Windows.Forms.ToolStripStatusLabel lblBoundary;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton startToolStripButton;
        private System.Windows.Forms.ToolStripButton pauseToolStripButton;
        private System.Windows.Forms.ToolStripButton nextToolStripButton;
        private GraphicsPanel graphicsPanel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gridVisibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem headsUpVisibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neighborCountVisibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem fromTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromCurrentSeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromNewSeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
    }
}

