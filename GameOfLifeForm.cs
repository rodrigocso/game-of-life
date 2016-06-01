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
    public partial class GameOfLifeForm : Form
    {
        bool[,] universe = new bool[10, 10];
        Timer timer = new Timer();
        int generations = 0;

        public GameOfLifeForm()
        {
            InitializeComponent();

            timer.Interval = 20;
            timer.Tick += Timer_Tick;
            timer.Enabled = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Call NextGeneration

            generations++;

            lblGeneration.Text = "Generations: " + generations;

            // graphicsPanel.Invalidade();
        }

        private void graphicsPanel_Paint(object sender, PaintEventArgs e)
        {
            float width = (float)graphicsPanel.ClientSize.Width / universe.GetLength(0);
            float height = (float)graphicsPanel.ClientSize.Height / universe.GetLength(1);

            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    RectangleF r = RectangleF.Empty;
                    r.X = x * width;
                    r.Y = y * height;
                    r.Width = width;
                    r.Height = height;

                    if (universe[x, y])
                        e.Graphics.FillRectangle(Brushes.Gray, r);

                    e.Graphics.DrawRectangle(Pens.Black, r.X, r.Y, r.Width, r.Height);
                }
            }
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

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < universe.GetLength(1); y++)
                for (int x = 0; x < universe.GetLength(0); x++)
                    universe[x, y] = false;

            graphicsPanel.Invalidate();
        }
    }
}
