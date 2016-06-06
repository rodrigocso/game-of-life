using System;
using System.Drawing;

namespace GameOfLife
{
    /// <summary>
    ///   This class is responsible for keeping track
    ///   of the program's configurations.
    /// </summary>
    public static class Config
    {
        // If the process is running on high DPI monitors,
        // we need to adjust font size and spacing.
        public static bool IsProcessHighDPI { get; set; }

        public static Random Rng { get; set; }
        public static int Seed { get; set; }

        public static int Interval { get; set; } // Timer interval in ms.
        public static int Width { get; set; }    // Universe's columns.
        public static int Height { get; set; }   // Universe's rows.

        // Color properties for Game of Life:
        public static Color GridColor { get; set; }
        public static Color GridTensColor { get; set; }
        public static Color BackgroundColor { get; set; }
        public static Color LiveCellColor { get; set; }
        // Default Colors:
        public static Color DefaultGridColor { get { return Color.LightGray; } }
        public static Color DefaultGridTensColor { get { return Color.Black; } }
        public static Color DefaultBackgroundColor { get { return Color.White; } }
        public static Color DefaultLiveCellColor { get { return Color.LimeGreen; } }

        public static Life.Boundaries Boundary { get; set; } // Finite or Toroidal.

        public static bool IsGridVisible { get; set; }
        public static bool IsHeadsUpDisplayVisible { get; set; }
        public static bool IsNeighborCountVisible { get; set; }

        /// <summary>
        ///   This method sets the program's initial
        ///   configurations. Currently hard-coded.
        /// </summary>
        public static void LoadInitialConfig()
        {
            Interval = 20;
            Width = 100;
            Height = 50;

            LoadDefaultColors();
            
            Boundary = Life.Boundaries.Toroidal;
            IsGridVisible = true;
            IsHeadsUpDisplayVisible = true;
            IsNeighborCountVisible = false;

            if (Rng == null)
            {
                Seed = Math.Abs((int)DateTime.Now.Ticks);
                Rng = new Random(Seed);
            }
        }

        public static void LoadDefaultColors()
        {
            GridColor = Color.LightGray;
            GridTensColor = Color.Black;
            BackgroundColor = Color.White;
            LiveCellColor = Color.LimeGreen;
        }
    }
}
