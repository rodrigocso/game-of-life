﻿using System;
using System.Drawing;

namespace GameOfLife
{
    /// <summary>
    ///   This class is responsible for keeping track
    ///   of the program's configurations.
    /// </summary>
    public static class Config
    {
        public static Random Rng { get; set; }
        public static int Seed { get; set; }

        public static int Interval { get; set; } // Timer interval in ms.
        public static int Width { get; set; }    // Universe's columns.
        public static int Height { get; set; }   // Universe's rows.

        public static Color GridColor { get; set; }
        public static Color GridTensColor { get; set; }
        public static Color BackgroundColor { get; set; }
        public static Color LiveCellColor { get; set; }

        public enum Bounderies { Toroidal, Finite, Infinite };
        public static Bounderies Boundary { get; set; }

        public static bool IsGridVisible { get; set; }
        public static bool IsHeadsUpDisplayVisible { get; set; }
        public static bool IsNeighborCountVisible { get; set; }

        public static void LoadInitialConfig()
        {
            Interval = 20;
            Width = Height = 50;

            GridColor = Color.LightGray;
            GridTensColor = Color.Black;
            BackgroundColor = Color.White;
            LiveCellColor = Color.LimeGreen;
            Boundary = Bounderies.Finite;
            IsGridVisible = true;
            IsHeadsUpDisplayVisible = true;
            IsNeighborCountVisible = false;

            Seed = (int)DateTime.Now.Ticks & 0x0000FFFF;
            Rng = new Random(Seed);
        }
    }
}