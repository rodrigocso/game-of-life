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
    public partial class OptionsDialog : Form
    {
        public OptionsDialog()
        {
            InitializeComponent();
            UpdateViewFromConfig();
        }

        /// <summary>
        /// Load config to form controls.
        /// <see cref="Config"/>
        /// </summary>
        private void UpdateViewFromConfig()
        {
            btnColorBack.BackColor = Config.BackgroundColor;
            btnColorLiveCell.BackColor = Config.LiveCellColor;
            btnColorGrid.BackColor = Config.GridColor;
            btnColorGridx10.BackColor = Config.GridTensColor;

            nudInterval.Value = Config.Interval;
            nudHeight.Value = Config.Height;
            nudWidth.Value = Config.Width;

            switch (Config.Boundary)
            {
                case Life.Boundaries.Toroidal:
                    optToroidal.Select();
                    break;
                case Life.Boundaries.Finite:
                    optFinite.Select();
                    break;
            }
        }

        /// <summary>
        /// Save user's customized options to config.
        /// <see cref="Config"/>
        /// </summary>
        private void UpdateConfigFromView()
        {
            Config.BackgroundColor = btnColorBack.BackColor;
            Config.LiveCellColor = btnColorLiveCell.BackColor;
            Config.GridColor = btnColorGrid.BackColor;
            Config.GridTensColor = btnColorGridx10.BackColor;

            Config.Interval = (int)nudInterval.Value;
            Config.Height = (int)nudHeight.Value;
            Config.Width = (int)nudWidth.Value;

            if (optToroidal.Checked)
                Config.Boundary = Life.Boundaries.Toroidal;
            else if (optFinite.Checked)
                Config.Boundary = Life.Boundaries.Finite;
        }

        private void ChangeColor(Button btn)
        {
            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
                btn.BackColor = cd.Color;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            UpdateConfigFromView();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnColorGrid_Click(object sender, EventArgs e)
        {
            ChangeColor(btnColorGrid);
        }

        private void btnColorGridx10_Click(object sender, EventArgs e)
        {
            ChangeColor(btnColorGridx10);
        }

        private void btnColorBack_Click(object sender, EventArgs e)
        {
            ChangeColor(btnColorBack);
        }

        private void btnColorLiveCell_Click(object sender, EventArgs e)
        {
            ChangeColor(btnColorLiveCell);
        }

        private void btnColorReset_Click(object sender, EventArgs e)
        {
            btnColorBack.BackColor = Config.DefaultBackgroundColor;
            btnColorGrid.BackColor = Config.DefaultGridColor;
            btnColorGridx10.BackColor = Config.DefaultGridTensColor;
            btnColorLiveCell.BackColor = Config.DefaultLiveCellColor;
        }
    }
}
