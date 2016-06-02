namespace GameOfLife
{
    partial class OptionsDialog
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.tabView = new System.Windows.Forms.TabPage();
            this.tabAdvanced = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnColorGrid = new System.Windows.Forms.Button();
            this.btnColorLiveCell = new System.Windows.Forms.Button();
            this.btnColorBack = new System.Windows.Forms.Button();
            this.btnColorGridx10 = new System.Windows.Forms.Button();
            this.btnColorReset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optToroidal = new System.Windows.Forms.RadioButton();
            this.optFinite = new System.Windows.Forms.RadioButton();
            this.optInfinite = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabView.SuspendLayout();
            this.tabAdvanced.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(14, 401);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(123, 41);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(158, 401);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 41);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGeneral);
            this.tabControl1.Controls.Add(this.tabView);
            this.tabControl1.Controls.Add(this.tabAdvanced);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(675, 395);
            this.tabControl1.TabIndex = 2;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.label3);
            this.tabGeneral.Controls.Add(this.label2);
            this.tabGeneral.Controls.Add(this.numericUpDown3);
            this.tabGeneral.Controls.Add(this.numericUpDown2);
            this.tabGeneral.Controls.Add(this.numericUpDown1);
            this.tabGeneral.Controls.Add(this.label1);
            this.tabGeneral.Location = new System.Drawing.Point(8, 39);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(659, 348);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // tabView
            // 
            this.tabView.Controls.Add(this.label7);
            this.tabView.Controls.Add(this.label6);
            this.tabView.Controls.Add(this.label5);
            this.tabView.Controls.Add(this.label4);
            this.tabView.Controls.Add(this.btnColorReset);
            this.tabView.Controls.Add(this.btnColorGridx10);
            this.tabView.Controls.Add(this.btnColorBack);
            this.tabView.Controls.Add(this.btnColorLiveCell);
            this.tabView.Controls.Add(this.btnColorGrid);
            this.tabView.Location = new System.Drawing.Point(8, 39);
            this.tabView.Name = "tabView";
            this.tabView.Padding = new System.Windows.Forms.Padding(3);
            this.tabView.Size = new System.Drawing.Size(659, 348);
            this.tabView.TabIndex = 1;
            this.tabView.Text = "View";
            this.tabView.UseVisualStyleBackColor = true;
            // 
            // tabAdvanced
            // 
            this.tabAdvanced.Controls.Add(this.groupBox1);
            this.tabAdvanced.Location = new System.Drawing.Point(8, 39);
            this.tabAdvanced.Name = "tabAdvanced";
            this.tabAdvanced.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdvanced.Size = new System.Drawing.Size(659, 348);
            this.tabAdvanced.TabIndex = 2;
            this.tabAdvanced.Text = "Advanced";
            this.tabAdvanced.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time Interval in Milliseconds";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(317, 16);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown1.TabIndex = 1;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(317, 62);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown2.TabIndex = 2;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(317, 110);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Width of Universe in Cells";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Height of Universe in Cells";
            // 
            // btnColorGrid
            // 
            this.btnColorGrid.Location = new System.Drawing.Point(6, 20);
            this.btnColorGrid.Name = "btnColorGrid";
            this.btnColorGrid.Size = new System.Drawing.Size(58, 39);
            this.btnColorGrid.TabIndex = 0;
            this.btnColorGrid.UseVisualStyleBackColor = true;
            // 
            // btnColorLiveCell
            // 
            this.btnColorLiveCell.Location = new System.Drawing.Point(6, 190);
            this.btnColorLiveCell.Name = "btnColorLiveCell";
            this.btnColorLiveCell.Size = new System.Drawing.Size(58, 39);
            this.btnColorLiveCell.TabIndex = 1;
            this.btnColorLiveCell.UseVisualStyleBackColor = true;
            // 
            // btnColorBack
            // 
            this.btnColorBack.Location = new System.Drawing.Point(6, 135);
            this.btnColorBack.Name = "btnColorBack";
            this.btnColorBack.Size = new System.Drawing.Size(58, 39);
            this.btnColorBack.TabIndex = 2;
            this.btnColorBack.UseVisualStyleBackColor = true;
            // 
            // btnColorGridx10
            // 
            this.btnColorGridx10.Location = new System.Drawing.Point(6, 79);
            this.btnColorGridx10.Name = "btnColorGridx10";
            this.btnColorGridx10.Size = new System.Drawing.Size(58, 39);
            this.btnColorGridx10.TabIndex = 3;
            this.btnColorGridx10.UseVisualStyleBackColor = true;
            // 
            // btnColorReset
            // 
            this.btnColorReset.Location = new System.Drawing.Point(6, 292);
            this.btnColorReset.Name = "btnColorReset";
            this.btnColorReset.Size = new System.Drawing.Size(121, 39);
            this.btnColorReset.TabIndex = 4;
            this.btnColorReset.Text = "Reset";
            this.btnColorReset.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Grid Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Grid x 10 Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Background Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Live Cell Color";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.optInfinite);
            this.groupBox1.Controls.Add(this.optFinite);
            this.groupBox1.Controls.Add(this.optToroidal);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Boundary Type";
            // 
            // optToroidal
            // 
            this.optToroidal.AutoSize = true;
            this.optToroidal.Location = new System.Drawing.Point(15, 43);
            this.optToroidal.Name = "optToroidal";
            this.optToroidal.Size = new System.Drawing.Size(121, 29);
            this.optToroidal.TabIndex = 0;
            this.optToroidal.TabStop = true;
            this.optToroidal.Text = "Toroidal";
            this.optToroidal.UseVisualStyleBackColor = true;
            // 
            // optFinite
            // 
            this.optFinite.AutoSize = true;
            this.optFinite.Location = new System.Drawing.Point(15, 92);
            this.optFinite.Name = "optFinite";
            this.optFinite.Size = new System.Drawing.Size(96, 29);
            this.optFinite.TabIndex = 1;
            this.optFinite.TabStop = true;
            this.optFinite.Text = "Finite";
            this.optFinite.UseVisualStyleBackColor = true;
            // 
            // optInfinite
            // 
            this.optInfinite.AutoSize = true;
            this.optInfinite.Location = new System.Drawing.Point(15, 142);
            this.optInfinite.Name = "optInfinite";
            this.optInfinite.Size = new System.Drawing.Size(106, 29);
            this.optInfinite.TabIndex = 2;
            this.optInfinite.TabStop = true;
            this.optInfinite.Text = "Infinite";
            this.optInfinite.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(179, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 143);
            this.label8.TabIndex = 3;
            this.label8.Text = "Warning! Changing boundary type may erase current cells.";
            // 
            // OptionsDialog
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(675, 455);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options Dialog";
            this.tabControl1.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.tabView.ResumeLayout(false);
            this.tabView.PerformLayout();
            this.tabAdvanced.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabView;
        private System.Windows.Forms.TabPage tabAdvanced;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnColorReset;
        private System.Windows.Forms.Button btnColorGridx10;
        private System.Windows.Forms.Button btnColorBack;
        private System.Windows.Forms.Button btnColorLiveCell;
        private System.Windows.Forms.Button btnColorGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton optInfinite;
        private System.Windows.Forms.RadioButton optFinite;
        private System.Windows.Forms.RadioButton optToroidal;
    }
}