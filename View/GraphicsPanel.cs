using System;
using System.Windows.Forms;

namespace GameOfLife
{
    /// <summary>
    ///   The panel where GoL Universe is painted to.
    /// </summary>
    public class GraphicsPanel : Panel
    {
        public GraphicsPanel()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
        }
    }
}
