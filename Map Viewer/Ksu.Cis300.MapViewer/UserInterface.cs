/*UserInterface.cs
 * Author: Andrew Weber
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ksu.Cis300.MapViewer
{
    /// <summary>
    /// Where the interface actions get implimented
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// Initializes the interface
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
            uxZoomIn.Enabled = false;
            uxZoomOut.Enabled = false;
            
        }

        /// <summary>
        /// Scale factor at minimum zoom
        /// </summary>
        private const int _min = 10;

        /// <summary>
        /// The current map
        /// </summary>
        private Map _map;

        /// <summary>
        /// Reads the given imput file
        /// </summary>
        /// <param name="name">Name of the file</param>
        /// <param name="rec">The map bounds</param>
        /// <returns></returns>
        private static List<StreetSegment> ReadInput(string name, out RectangleF rec)
        {
            using (StreamReader sr = new StreamReader(name))
            {   
                string[] line = sr.ReadLine().Split(',');
                float x = Convert.ToSingle(line[0]);
                float y = Convert.ToSingle(line[1]);
                rec = new RectangleF(0, 0, x, y);
                List<StreetSegment> list = new List<StreetSegment>();

                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine().Split(',');
                    PointF start = new PointF(Convert.ToSingle(line[0]), Convert.ToSingle(line[1]));
                    PointF end = new PointF(Convert.ToSingle(line[2]), Convert.ToSingle(line[3]));
                    Color c = Color.FromArgb(Convert.ToInt32(line[4]));
                    x = Convert.ToSingle(line[5]);
                    int zoom = Convert.ToInt32(line[6]);
                    list.Add(new StreetSegment(start, end, c, x, zoom));
                }
                return list;
            }
        }

        /// <summary>
        /// Opens a file dialog when clicked and handles all the errors that could be thrown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (uxOpenDialog.ShowDialog() == DialogResult.OK)
                {
                    string name = uxOpenDialog.FileName;
                    RectangleF rec = new RectangleF();
                    List<StreetSegment> list = ReadInput(name,out rec);
                    Map map = new Map(list, rec, _min);
                    _map = map;

                    uxPanel.Controls.Clear();
                    uxPanel.Controls.Add(_map);
                    uxZoomIn.Enabled = true;
                    uxZoomOut.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Zooms the map in when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxZoomIn_Click(object sender, EventArgs e)
        {
            Point scrollpos = uxPanel.AutoScrollPosition;
            scrollpos.X *= -1;
            scrollpos.Y *= -1;
            _map.ZoomIn();
            if (_map.CanZoomIn)
            {
                uxZoomIn.Enabled = true;
                uxZoomOut.Enabled = true;
            }
            else
            {
                uxZoomIn.Enabled = false;
                scrollpos.X = scrollpos.X * 2 + uxPanel.ClientSize.Width / 2;
                scrollpos.Y = scrollpos.Y * 2 + uxPanel.ClientSize.Height / 2;
                uxPanel.AutoScrollPosition = scrollpos;
            }
        }

        /// <summary>
        /// Zooms the map out when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxZoomOut_Click(object sender, EventArgs e)
        {
            Point scrollpos = uxPanel.AutoScrollPosition;
            scrollpos.X *= -1;
            scrollpos.Y *= -1;
            _map.ZoomOut();
            if (_map.CanZoomOut)
            {
                uxZoomIn.Enabled = true;
                uxZoomOut.Enabled = true;
            }
            else
            {
                uxZoomOut.Enabled = false;
                scrollpos.X = scrollpos.X / 2 - uxPanel.ClientSize.Width / 4;
                scrollpos.Y = scrollpos.Y / 2 - uxPanel.ClientSize.Height / 4;
                uxPanel.AutoScrollPosition = scrollpos;
            }
        }
    }
}
