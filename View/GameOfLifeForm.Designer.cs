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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOfLifeForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadPreviousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxMenuClear = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuPause = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuNext = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuViewGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuViewHUD = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuViewNeighborCount = new System.Windows.Forms.ToolStripMenuItem();
            this.graphicsPanel = new GameOfLife.GraphicsPanel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
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
            this.importToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 38);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::GameOfLife.Properties.Resources.VSO_NewFile_40x;
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(260, 38);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::GameOfLife.Properties.Resources.OpenFolder_32x;
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(260, 38);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(257, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::GameOfLife.Properties.Resources.Save_32x;
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(260, 38);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(257, 6);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Image = global::GameOfLife.Properties.Resources.ImportFile_16x;
            this.importToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(260, 38);
            this.importToolStripMenuItem.Text = "&Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(257, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::GameOfLife.Properties.Resources.Close_16x;
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
            this.gridVisibleToolStripMenuItem.Image = global::GameOfLife.Properties.Resources.Transparent;
            this.gridVisibleToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gridVisibleToolStripMenuItem.Name = "gridVisibleToolStripMenuItem";
            this.gridVisibleToolStripMenuItem.Size = new System.Drawing.Size(302, 38);
            this.gridVisibleToolStripMenuItem.Text = "&Grid";
            this.gridVisibleToolStripMenuItem.Click += new System.EventHandler(this.GridVisibleToolStripMenuItem_Click);
            // 
            // headsUpVisibleToolStripMenuItem
            // 
            this.headsUpVisibleToolStripMenuItem.CheckOnClick = true;
            this.headsUpVisibleToolStripMenuItem.Name = "headsUpVisibleToolStripMenuItem";
            this.headsUpVisibleToolStripMenuItem.Size = new System.Drawing.Size(302, 38);
            this.headsUpVisibleToolStripMenuItem.Text = "&Heads Up Display";
            this.headsUpVisibleToolStripMenuItem.Click += new System.EventHandler(this.HeadsUpVisibleToolStripMenuItem_Click);
            // 
            // neighborCountVisibleToolStripMenuItem
            // 
            this.neighborCountVisibleToolStripMenuItem.CheckOnClick = true;
            this.neighborCountVisibleToolStripMenuItem.Name = "neighborCountVisibleToolStripMenuItem";
            this.neighborCountVisibleToolStripMenuItem.Size = new System.Drawing.Size(302, 38);
            this.neighborCountVisibleToolStripMenuItem.Text = "&Neighbor Count";
            this.neighborCountVisibleToolStripMenuItem.Click += new System.EventHandler(this.NeighborCountVisibleToolStripMenuItem_Click);
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
            this.startToolStripMenuItem.Image = global::GameOfLife.Properties.Resources.Run_16x;
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.startToolStripMenuItem.Size = new System.Drawing.Size(216, 38);
            this.startToolStripMenuItem.Text = "&Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Enabled = false;
            this.pauseToolStripMenuItem.Image = global::GameOfLife.Properties.Resources.Pause_16x;
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(216, 38);
            this.pauseToolStripMenuItem.Text = "&Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Image = global::GameOfLife.Properties.Resources.Next_16x;
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
            this.toolStripSeparator2,
            this.optionsToolStripMenuItem,
            this.settingsToolStripMenuItem});
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
            this.toolStripMenuItem3.Image = global::GameOfLife.Properties.Resources.Dice;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(234, 38);
            this.toolStripMenuItem3.Text = "&Randomize";
            // 
            // fromTimeToolStripMenuItem
            // 
            this.fromTimeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fromTimeToolStripMenuItem.Image")));
            this.fromTimeToolStripMenuItem.Name = "fromTimeToolStripMenuItem";
            this.fromTimeToolStripMenuItem.Size = new System.Drawing.Size(317, 38);
            this.fromTimeToolStripMenuItem.Text = "From &Time";
            this.fromTimeToolStripMenuItem.Click += new System.EventHandler(this.fromTimeToolStripMenuItem_Click);
            // 
            // fromCurrentSeedToolStripMenuItem
            // 
            this.fromCurrentSeedToolStripMenuItem.Name = "fromCurrentSeedToolStripMenuItem";
            this.fromCurrentSeedToolStripMenuItem.Size = new System.Drawing.Size(317, 38);
            this.fromCurrentSeedToolStripMenuItem.Text = "From &Current Seed";
            this.fromCurrentSeedToolStripMenuItem.Click += new System.EventHandler(this.fromCurrentSeedToolStripMenuItem_Click);
            // 
            // fromNewSeedToolStripMenuItem
            // 
            this.fromNewSeedToolStripMenuItem.Name = "fromNewSeedToolStripMenuItem";
            this.fromNewSeedToolStripMenuItem.Size = new System.Drawing.Size(317, 38);
            this.fromNewSeedToolStripMenuItem.Text = "From &New Seed";
            this.fromNewSeedToolStripMenuItem.Click += new System.EventHandler(this.fromNewSeedToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(231, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Image = global::GameOfLife.Properties.Resources.Settings_24x;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(234, 38);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.reloadPreviousToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(234, 38);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Image = global::GameOfLife.Properties.Resources.Transparent;
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(286, 38);
            this.resetToolStripMenuItem.Text = "&Reset to Default";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // reloadPreviousToolStripMenuItem
            // 
            this.reloadPreviousToolStripMenuItem.Name = "reloadPreviousToolStripMenuItem";
            this.reloadPreviousToolStripMenuItem.Size = new System.Drawing.Size(286, 38);
            this.reloadPreviousToolStripMenuItem.Text = "Re&load Previous";
            this.reloadPreviousToolStripMenuItem.Click += new System.EventHandler(this.reloadPreviousToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator7,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 38);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(266, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::GameOfLife.Properties.Resources.Transparent;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
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
            this.toolStrip1.Size = new System.Drawing.Size(1064, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = global::GameOfLife.Properties.Resources.VSO_NewFile_40x;
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = global::GameOfLife.Properties.Resources.OpenFolder_32x;
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = global::GameOfLife.Properties.Resources.Save_32x;
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // startToolStripButton
            // 
            this.startToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.startToolStripButton.Image = global::GameOfLife.Properties.Resources.Run_16x;
            this.startToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startToolStripButton.Name = "startToolStripButton";
            this.startToolStripButton.Size = new System.Drawing.Size(36, 36);
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
            this.pauseToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.pauseToolStripButton.Text = "&Copy";
            this.pauseToolStripButton.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // nextToolStripButton
            // 
            this.nextToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nextToolStripButton.Image = global::GameOfLife.Properties.Resources.Next_16x;
            this.nextToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nextToolStripButton.Name = "nextToolStripButton";
            this.nextToolStripButton.Size = new System.Drawing.Size(36, 36);
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
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxMenuClear,
            this.ctxMenuStart,
            this.ctxMenuPause,
            this.ctxMenuNext,
            this.toolStripSeparator5,
            this.optionsToolStripMenuItem1});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(256, 200);
            // 
            // ctxMenuClear
            // 
            this.ctxMenuClear.Name = "ctxMenuClear";
            this.ctxMenuClear.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.ctxMenuClear.Size = new System.Drawing.Size(255, 38);
            this.ctxMenuClear.Text = "Clear";
            this.ctxMenuClear.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // ctxMenuStart
            // 
            this.ctxMenuStart.Image = global::GameOfLife.Properties.Resources.Run_16x;
            this.ctxMenuStart.Name = "ctxMenuStart";
            this.ctxMenuStart.ShortcutKeyDisplayString = "F7";
            this.ctxMenuStart.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.ctxMenuStart.Size = new System.Drawing.Size(255, 38);
            this.ctxMenuStart.Text = "Start";
            this.ctxMenuStart.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // ctxMenuPause
            // 
            this.ctxMenuPause.Enabled = false;
            this.ctxMenuPause.Image = global::GameOfLife.Properties.Resources.Pause_16x;
            this.ctxMenuPause.Name = "ctxMenuPause";
            this.ctxMenuPause.ShortcutKeyDisplayString = "F8";
            this.ctxMenuPause.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.ctxMenuPause.Size = new System.Drawing.Size(255, 38);
            this.ctxMenuPause.Text = "Pause";
            this.ctxMenuPause.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // ctxMenuNext
            // 
            this.ctxMenuNext.Image = global::GameOfLife.Properties.Resources.Next_16x;
            this.ctxMenuNext.Name = "ctxMenuNext";
            this.ctxMenuNext.ShortcutKeyDisplayString = "F9";
            this.ctxMenuNext.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.ctxMenuNext.Size = new System.Drawing.Size(255, 38);
            this.ctxMenuNext.Text = "Next";
            this.ctxMenuNext.Click += new System.EventHandler(this.nextToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(252, 6);
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxMenuViewGrid,
            this.ctxMenuViewHUD,
            this.ctxMenuViewNeighborCount});
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(255, 38);
            this.optionsToolStripMenuItem1.Text = "View";
            // 
            // ctxMenuViewGrid
            // 
            this.ctxMenuViewGrid.CheckOnClick = true;
            this.ctxMenuViewGrid.Image = global::GameOfLife.Properties.Resources.Transparent;
            this.ctxMenuViewGrid.Name = "ctxMenuViewGrid";
            this.ctxMenuViewGrid.Size = new System.Drawing.Size(288, 38);
            this.ctxMenuViewGrid.Text = "Grid";
            this.ctxMenuViewGrid.Click += new System.EventHandler(this.GridVisibleToolStripMenuItem_Click);
            // 
            // ctxMenuViewHUD
            // 
            this.ctxMenuViewHUD.CheckOnClick = true;
            this.ctxMenuViewHUD.Name = "ctxMenuViewHUD";
            this.ctxMenuViewHUD.Size = new System.Drawing.Size(288, 38);
            this.ctxMenuViewHUD.Text = "Heads Up";
            this.ctxMenuViewHUD.Click += new System.EventHandler(this.HeadsUpVisibleToolStripMenuItem_Click);
            // 
            // ctxMenuViewNeighborCount
            // 
            this.ctxMenuViewNeighborCount.CheckOnClick = true;
            this.ctxMenuViewNeighborCount.Name = "ctxMenuViewNeighborCount";
            this.ctxMenuViewNeighborCount.Size = new System.Drawing.Size(288, 38);
            this.ctxMenuViewNeighborCount.Text = "Neighbor Count";
            this.ctxMenuViewNeighborCount.Click += new System.EventHandler(this.NeighborCountVisibleToolStripMenuItem_Click);
            // 
            // graphicsPanel
            // 
            this.graphicsPanel.BackColor = System.Drawing.SystemColors.Window;
            this.graphicsPanel.ContextMenuStrip = this.contextMenuStrip;
            this.graphicsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphicsPanel.Location = new System.Drawing.Point(0, 81);
            this.graphicsPanel.Name = "graphicsPanel";
            this.graphicsPanel.Size = new System.Drawing.Size(1064, 742);
            this.graphicsPanel.TabIndex = 3;
            this.graphicsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.graphicsPanel_Paint);
            this.graphicsPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel_MouseClick);
            // 
            // GameOfLifeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1064, 860);
            this.Controls.Add(this.graphicsPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameOfLifeForm";
            this.Text = "Game Of Life";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameOfLifeForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
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
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadPreviousToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuClear;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuStart;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuPause;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuNext;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuViewGrid;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuViewHUD;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuViewNeighborCount;
    }
}

