using System;

namespace GameOfLife
{
    /// <summary>
    ///   This class implements the Game Of Life logic.
    /// </summary>
    public class Life
    {
        public enum Boundaries { Toroidal, Finite };
        private Boundaries _boundary;

        public bool[,] Universe { get; set; }
        public bool[,] ScratchPad { get; set; }
        public int Generations { get; set; }
        public int GenerationsLimit { get; set; } // Set by "Run To..."
        public int LiveCells { get; set; }
        public bool HasReachedLimit // "Run To..." stop flag
        {
            get { return Generations == GenerationsLimit; }
        }

        public Life()
        {
            Generations = GenerationsLimit = 0;
        }

        /// <summary>
        ///   Updates the Game of Life settings
        ///   from <see cref="Config"/>.
        /// </summary>
        public void UpdateFromConfig()
        {
            _boundary = Config.Boundary;

            ScratchPad = new bool[Config.Height, Config.Width];

            if (Universe == null)
                Universe = new bool[Config.Height, Config.Width];

            for (int col = 0; col < ScratchPad.GetLength(1) && col < Universe.GetLength(1); col++)
                for (int row = 0; row < ScratchPad.GetLength(0) && row < Universe.GetLength(0); row++)
                    ScratchPad[row, col] = Universe[row, col];

            Universe = new bool[Config.Height, Config.Width];

            for (int col = 0; col < Universe.GetLength(1); col++)
                for (int row = 0; row < Universe.GetLength(0); row++)
                    Universe[row, col] = ScratchPad[row, col];
        }

        /// <summary>
        ///   This method applies the rules to decide
        ///   which cells live and die in the next generation.
        /// </summary>
        public void NextGeneration()
        {
            for (int col = 0; col < Universe.GetLength(1); col++)
                for (int row = 0; row < Universe.GetLength(0); row++)
                    if (Universe[row, col])
                    {
                        int neighbors = CountNeighbors(row, col);
                        if (neighbors < 2 || neighbors > 3)
                            ScratchPad[row, col] = false;
                        else
                            ScratchPad[row, col] = true;
                    }
                    else
                    {
                        if (CountNeighbors(row, col) == 3)
                            ScratchPad[row, col] = true;
                    }

            Universe = ScratchPad;
            ScratchPad = new bool[Config.Height, Config.Width];

            Generations++;
        }

        /// <summary>
        ///   Counts the neighbors of a given cell.
        /// </summary>
        /// <param name="r">Cell's row number.</param>
        /// <param name="c">Cell's column number.</param>
        /// <returns>Returns the number of neighbors.</returns>
        public int CountNeighbors(int r, int c)
        {
            switch (_boundary)
            {
                case Boundaries.Toroidal:
                    return CountNeighborsToroidal(r, c);
                case Boundaries.Finite:
                    return CountNeighborsFinite(r, c);
                default:
                    return 0;
            }
        }

        /// <summary>
        ///   Counts the neighbors of a given cell
        ///   in a finite universe.
        /// </summary>
        private int CountNeighborsFinite(int r, int c)
        {
            int neighbors = 0;

            for (int row = r - 1; (row <= r + 1) && (row < Universe.GetLength(0)); row++)
                if (row >= 0)
                    for (int col = c - 1; (col <= c + 1) && (col < Universe.GetLength(1)); col++)
                        if (col >= 0)
                            if (col != c || row != r)
                                if (Universe[row, col])
                                    neighbors++;

            return neighbors;
        }

        /// <summary>
        ///   Counts the neighbors of a given cell
        ///   in a toroidal universe.
        /// </summary>
        private int CountNeighborsToroidal(int r, int c)
        {
            int neighbors = 0;

            for (int row = r - 1; row <= r + 1; row++)
            {
                int y = Mod(row, Universe.GetLength(0));
                for (int col = c - 1; col <= c + 1; col++)
                {
                    int x = Mod(col, Universe.GetLength(1));
                    if (x != c || y != r)
                        if (Universe[y, x])
                            neighbors++;
                }
            }
                    
            return neighbors;
        }

        /// <summary>
        ///   Randomize the state of each cell
        ///   in the grid. When called using "current seed",
        ///   expects a null seed.
        /// </summary>
        /// <param name="seed">Nullable seed</param>
        public void RandomizeGrid(int? seed)
        {
            if (seed != null)
            {
                Config.Rng = new Random((int)seed);
                Config.Seed = (int)seed;
            }

            for (int col = 0; col < Universe.GetLength(1); col++)
                for (int row = 0; row < Universe.GetLength(0); row++)
                    Universe[row, col] = (Config.Rng.Next() % 2 == 0);
        }

        /// <summary>
        ///   <para>Modulus operator. The default % operator
        ///   doesn't handle negative numbers properly.</para>
        ///   <para>-2 % 50 == -2</para>
        ///   <para>Mod(-2, 50) == 48</para>
        /// </summary>
        public int Mod(int number, int divisor)
        {
            while (number < divisor)
                number += divisor;

            return number % divisor;
        }
    }
}
