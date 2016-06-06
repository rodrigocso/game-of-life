using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            using (Graphics graphics = Graphics.FromHwnd(IntPtr.Zero))
            {
                Config.IsProcessHighDPI = (graphics.DpiX > 96 || graphics.DpiY > 96);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GameOfLifeForm());
        }

        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
