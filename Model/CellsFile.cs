using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GameOfLife
{
    /// <summary>
    ///   This class is responsible for
    ///   Cells File (*.cells) I/O.
    /// </summary>
    public class CellsFile
    {
        StreamWriter _writer;
        StreamReader _reader;

        /// <summary>
        ///   Saves the current state to Cells File.
        /// </summary>
        /// <param name="fileName">Location to save.</param>
        /// <param name="life">Game of Life instance.</param>
        public void Save(string fileName, Life life)
        {
            _writer = new StreamWriter(fileName);
            _writer.WriteLine("!Name: " + Path.GetFileNameWithoutExtension(fileName));
            _writer.WriteLine("!");

            for (int col = 0; col < life.Universe.GetLength(1); col++)
            {
                for (int row = 0; row < life.Universe.GetLength(0); row++)
                    _writer.Write(life.Universe[row, col] ? "O" : ".");

                _writer.WriteLine();
            }

            _writer.Close();                
        }

        /// <summary>
        ///   Helper method to read all lines from
        ///   a plain text file.
        /// </summary>
        /// <param name="fileName">Plain text file path.</param>
        /// <returns>All lines read from file.</returns>
        private List<string> ReadLines(string fileName)
        {
            List<string> lines = new List<string>();
            _reader = new StreamReader(fileName);

            while (!_reader.EndOfStream)
            {
                string line = _reader.ReadLine();
                if (line != string.Empty && line[0] != '!')
                    lines.Add(line);
            }

            _reader.Close();

            return lines;
        }

        /// <summary>
        ///   Sets current GoL Universe to the state
        ///   saved on file.
        /// </summary>
        /// <param name="fileName">Cells file path.</param>
        /// <param name="life">Game of Life instance.</param>
        public void Open(string fileName, Life life)
        {
            List<string> lines = ReadLines(fileName);
            Config.Width = lines[0].Length;
            Config.Height = lines.Count;

            life.Universe = new bool[Config.Height, Config.Width];
            life.ScratchPad = new bool[Config.Height, Config.Width];

            for (int col = 0; col < lines[0].Length; col++)
                for (int row = 0; row < lines.Count; row++)
                    life.Universe[row, col] = (lines[row][col] == 'O');
        }

        /// <summary>
        ///   Loads into the current GoL Universe the pattern
        ///   in the Cells file. This pattern is placed in the
        ///   center of the Universe. If the pattern is bigger
        ///   than the Universe, asks for confirmation before
        ///   resizing it to comport the pattern.
        /// </summary>
        /// <param name="fileName">Cells file path.</param>
        /// <param name="life">Game of Life instance.</param>
        public void Import(string fileName, Life life)
        {
            List<string> lines = ReadLines(fileName);

            if (lines.Count > Config.Height || lines[0].Length > Config.Width)
            {
                DialogResult dr = MessageBox.Show(
                    "Imported file is larger than current universe.\n" +
                    "If you proceed, universe will be resized.", "Import...",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                if (dr == DialogResult.OK)
                {
                    Config.Height = lines.Count;
                    Config.Width = lines[0].Length;
                    life.UpdateFromConfig();
                }
                else
                    return;
            }

            int col = Config.Width / 2 - lines[0].Length / 2;
            int row = Config.Height / 2 - lines.Count / 2;

            for (int j = 0; j < lines[0].Length; j++)
                for (int i = 0; i < lines.Count; i++)
                    life.Universe[row + i, col + j] = (lines[i][j] == 'O');
        }
    }
}
