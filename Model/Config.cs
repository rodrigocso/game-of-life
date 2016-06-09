using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace GameOfLife
{
    /// <summary>
    ///   This class is responsible for keeping track
    ///   of the program's configurations.
    /// </summary>
    public static class Config
    {
        // The xml file where settings are saved.
        const string _SettingsFile = "AppSettings.xml";

        // If the process is running on high DPI monitors,
        // we need to adjust font size and spacing.
        public static bool IsProcessHighDPI { get; set; }

        public static Random Rng { get; set; }
        public static int Seed { get; set; }

        public enum Configuration { Default, Current, Previous }

        // Game of Life characteristics:
        public static int Interval { get; set; } // Timer interval in ms.
        public static int Width { get; set; }    // Universe's columns.
        public static int Height { get; set; }   // Universe's rows.
        public static Life.Boundaries Boundary { get; set; } // Finite or Toroidal.

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

        // Visualization options:
        public static bool IsGridVisible { get; set; }
        public static bool IsHeadsUpDisplayVisible { get; set; }
        public static bool IsNeighborCountVisible { get; set; }

        /// <summary>
        ///   This method sets the program's initial
        ///   configurations.
        /// </summary>
        public static void LoadCurrentConfig()
        {
            if (Rng == null)
            {
                Seed = Math.Abs((int)DateTime.Now.Ticks);
                Rng = new Random(Seed);
            }

            Load(Configuration.Current);
        }

        /// <summary>
        ///   This method updates Config's properties
        ///   to match what's in the AppSettings.xml,
        ///   under a specific Configuration.
        /// </summary>
        /// <param name="config">
        ///   The configuration to be loaded.
        ///   (Default, Current or Previous)
        /// </param>
        public static void Load(Configuration config)
        {
            // If there is no settings file, create a new one.
            if (!File.Exists(_SettingsFile))
                CreateXmlFile();

            XDocument doc = XDocument.Load(_SettingsFile);
            XElement cfg = doc.Element("Config").Element(config.ToString());

            // Load Game of Life characteristics:
            Interval = Convert.ToInt32(cfg.Element("Life").Attribute("Interval").Value);
            Width = Convert.ToInt32(cfg.Element("Life").Attribute("Width").Value);
            Height = Convert.ToInt32(cfg.Element("Life").Attribute("Height").Value);
            Boundary = (cfg.Element("Life").Attribute("Boundary").Value == Life.Boundaries.Finite.ToString()) ? Life.Boundaries.Finite : Life.Boundaries.Toroidal;

            // Load visualization options:
            IsGridVisible = Convert.ToBoolean(cfg.Element("View").Attribute("Grid").Value);
            IsHeadsUpDisplayVisible = Convert.ToBoolean(cfg.Element("View").Attribute("HeadsUp").Value);
            IsNeighborCountVisible = Convert.ToBoolean(cfg.Element("View").Attribute("NeighborCount").Value);

            // Load color options:
            GridColor = Color.FromArgb(
                Convert.ToInt32(cfg.Element("Color").Element("Grid").Attribute("Red").Value),
                Convert.ToInt32(cfg.Element("Color").Element("Grid").Attribute("Green").Value),
                Convert.ToInt32(cfg.Element("Color").Element("Grid").Attribute("Blue").Value));

            GridTensColor = Color.FromArgb(
                Convert.ToInt32(cfg.Element("Color").Element("GridTens").Attribute("Red").Value),
                Convert.ToInt32(cfg.Element("Color").Element("GridTens").Attribute("Green").Value),
                Convert.ToInt32(cfg.Element("Color").Element("GridTens").Attribute("Blue").Value));

            BackgroundColor = Color.FromArgb(
                Convert.ToInt32(cfg.Element("Color").Element("Background").Attribute("Red").Value),
                Convert.ToInt32(cfg.Element("Color").Element("Background").Attribute("Green").Value),
                Convert.ToInt32(cfg.Element("Color").Element("Background").Attribute("Blue").Value));

            LiveCellColor = Color.FromArgb(
                Convert.ToInt32(cfg.Element("Color").Element("LiveCell").Attribute("Red").Value),
                Convert.ToInt32(cfg.Element("Color").Element("LiveCell").Attribute("Green").Value),
                Convert.ToInt32(cfg.Element("Color").Element("LiveCell").Attribute("Blue").Value));
        }

        /// <summary>
        ///   When the program exits, this method is called.
        ///   It is responsible for saving the current settings
        ///   to AppSettings.xml.
        /// </summary>
        public static void Save()
        {
            // If there is no settings file, create a new one.
            if (!File.Exists(_SettingsFile))
                CreateXmlFile();

            XDocument doc = XDocument.Load(_SettingsFile);
            XElement curr = doc.Element("Config").Element("Current");

            // Save Game of Life characteristics:
            curr.Element("Life").Attribute("Interval").Value = Interval.ToString();
            curr.Element("Life").Attribute("Width").Value = Width.ToString();
            curr.Element("Life").Attribute("Height").Value = Height.ToString();
            curr.Element("Life").Attribute("Boundary").Value = Boundary.ToString();

            // Save visualization options:
            curr.Element("View").Attribute("Grid").Value = IsGridVisible.ToString();
            curr.Element("View").Attribute("HeadsUp").Value = IsHeadsUpDisplayVisible.ToString();
            curr.Element("View").Attribute("NeighborCount").Value = IsNeighborCountVisible.ToString();

            // Save color options:
            curr.Element("Color").Element("Grid").Attribute("Red").Value = GridColor.R.ToString();
            curr.Element("Color").Element("Grid").Attribute("Green").Value = GridColor.G.ToString();
            curr.Element("Color").Element("Grid").Attribute("Blue").Value = GridColor.B.ToString();

            curr.Element("Color").Element("GridTens").Attribute("Red").Value = GridTensColor.R.ToString();
            curr.Element("Color").Element("GridTens").Attribute("Green").Value = GridTensColor.G.ToString();
            curr.Element("Color").Element("GridTens").Attribute("Blue").Value = GridTensColor.B.ToString();

            curr.Element("Color").Element("Background").Attribute("Red").Value = BackgroundColor.R.ToString();
            curr.Element("Color").Element("Background").Attribute("Green").Value = BackgroundColor.G.ToString();
            curr.Element("Color").Element("Background").Attribute("Blue").Value = BackgroundColor.B.ToString();

            curr.Element("Color").Element("LiveCell").Attribute("Red").Value = LiveCellColor.R.ToString();
            curr.Element("Color").Element("LiveCell").Attribute("Green").Value = LiveCellColor.G.ToString();
            curr.Element("Color").Element("LiveCell").Attribute("Blue").Value = LiveCellColor.B.ToString();

            // Replace the contents of "Previous" with "Current",
            // So that it is possible to "Reload Previous" through
            // Menu > Tools > Settings > Reload Previous.
            XElement cfg = doc.Element("Config");
            cfg.Element("Previous").ReplaceAll(cfg.Element("Current").Elements());

            // Since previous changes were made on memory only,
            // we need to save the file.
            doc.Save(_SettingsFile);
        }

        /// <summary>
        ///   This method is responsible for creating the AppSettings.xml
        ///   file if one doesn't exist.
        /// </summary>
        public static void CreateXmlFile()
        {
            XDocument doc = new XDocument(new XElement("Config")); // create a xml file with <Config/> as root.
            XElement cfg = doc.Descendants(XName.Get("Config")).First(); // load that element to memory.
            XElement def = new XElement("Default"); // this element will hold "Default" settings.
            XElement curr = new XElement("Current"); // this element will hold "Current" settings.
            XElement prev = new XElement("Previous"); // this element will hold "Previous" settings.

            // Color settings element, with hard-coded default values.
            XElement color =
                new XElement("Color",
                    new XElement("Grid",
                        new XAttribute("Red", 211),
                        new XAttribute("Green", 211),
                        new XAttribute("Blue", 211)),
                    new XElement("GridTens",
                        new XAttribute("Red", 0),
                        new XAttribute("Green", 0),
                        new XAttribute("Blue", 0)),
                    new XElement("Background",
                        new XAttribute("Red", 255),
                        new XAttribute("Green", 255),
                        new XAttribute("Blue", 255)),
                    new XElement("LiveCell",
                        new XAttribute("Red", 50),
                        new XAttribute("Green", 205),
                        new XAttribute("Blue", 205)));

            // Visualization options element, with hard-coded default values.
            XElement view =
                new XElement("View",
                    new XAttribute("Grid", true),
                    new XAttribute("HeadsUp", true),
                    new XAttribute("NeighborCount", false));

            // Game of Life characteristics element, with hard-coded default values.
            XElement life =
                new XElement("Life",
                    new XAttribute("Interval", 20),
                    new XAttribute("Height", 30),
                    new XAttribute("Width", 50),
                    new XAttribute("Boundary", Life.Boundaries.Toroidal));

            // Attach the created elements to the 3 settings: Current, Previous and Default.
            def.Add(life, view, color);
            curr.Add(life, view, color);
            prev.Add(life, view, color);
            // Attach the 3 settings to the root element.
            cfg.Add(def, curr, prev);
            // Save the xml file.
            doc.Save(_SettingsFile);
        }
    }
}
