using System;

namespace GameOfLife
{
    public class GameOfLife
    {
        private Config.Boundaries _boundary;

        public bool[,] Universe { get; set; }
        public bool[,] ScratchPad { get; set; }
        public int Generations { get; set; }
        public int GenerationsLimit { get; set; }
        public int LiveCells { get; set; }
        public bool HasReachedLimit { get { return Generations == GenerationsLimit; } }

        public GameOfLife()
        {
            Generations = GenerationsLimit = 0;
        }

        public void UpdateFromConfig()
        {
            _boundary = Config.Boundary;

            ScratchPad = new bool[Config.Height, Config.Width];

            if (Universe == null)
                Universe = new bool[Config.Height, Config.Width];

            for (int y = 0; y < ScratchPad.GetLength(1) || y < Universe.GetLength(1); y++)
                for (int x = 0; x < ScratchPad.GetLength(0) || x < Universe.GetLength(0); x++)
                    ScratchPad[x, y] = Universe[x, y];

            Universe = new bool[Config.Height, Config.Width];

            for (int y = 0; y < Universe.GetLength(1); y++)
                for (int x = 0; x < Universe.GetLength(0); x++)
                    Universe[x, y] = ScratchPad[x, y];
        }

        /// <summary>
        ///   This method applies the rules to decide
        ///   which cells live and die in the next generation.
        /// </summary>
        public void NextGeneration()
        {
            for (int y = 0; y < Universe.GetLength(1); y++)
                for (int x = 0; x < Universe.GetLength(0); x++)
                    if (Universe[x, y])
                    {
                        int neighbors = CountNeighbors(x, y);
                        if (neighbors < 2 || neighbors > 3)
                            ScratchPad[x, y] = false;
                        else
                            ScratchPad[x, y] = true;
                    }
                    else
                    {
                        if (CountNeighbors(x, y) == 3)
                            ScratchPad[x, y] = true;
                    }

            Universe = ScratchPad;
            ScratchPad = new bool[Config.Height, Config.Width];

            Generations++;
        }

        /// <summary>
        ///   Counts the neighbors of a given cell, considering a Finite universe.
        /// </summary>
        /// <param name="col">Cell's column number.</param>
        /// <param name="row">Cell's row number.</param>
        /// <returns>Returns the number of neighbors.</returns>
        public int CountNeighbors(int col, int row)
        {
            switch (_boundary)
            {
                case Config.Boundaries.Toroidal:
                    return CountNeighborsToroidal(col, row);
                case Config.Boundaries.Finite:
                    return CountNeighborsFinite(col, row);
                default:
                    return 0;
            }
        }

        private int CountNeighborsFinite(int col, int row)
        {
            int neighbors = 0;

            for (int y = row - 1; (y <= row + 1) && (y < Universe.GetLength(1)); y++)
                if (y >= 0)
                    for (int x = col - 1; (x <= col + 1) && (x < Universe.GetLength(0)); x++)
                        if (x >= 0)
                            if (x != col || y != row)
                                if (Universe[x, y])
                                    neighbors++;

            return neighbors;
        }

        private int CountNeighborsToroidal(int col, int row)
        {
            int neighbors = 0;

            for (int j = row - 1; j <= row + 1; j++)
            {
                int y = Mod(j, Universe.GetLength(1));
                for (int i = col - 1; i <= col + 1; i++)
                {
                    int x = Mod(i, Universe.GetLength(0));
                    if (x != col || y != row)
                        if (Universe[x, y])
                            neighbors++;
                }
            }
                    
            return neighbors;
        }

        public void RandomizeGrid(int? seed)
        {
            if (seed != null)
            {
                Config.Rng = new Random((int)seed);
                Config.Seed = (int)seed;
            }

            for (int y = 0; y < Universe.GetLength(1); y++)
                for (int x = 0; x < Universe.GetLength(0); x++)
                    Universe[x, y] = (Config.Rng.Next() % 2 == 0);
        }

        public int Mod(int number, int divisor)
        {
            while (number < divisor)
                number += divisor;

            return number % divisor;
        }
    }
}
