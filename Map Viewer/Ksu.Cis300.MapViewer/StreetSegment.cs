/*StreetSegment.cs
 * Author: Andrew Weber
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Ksu.Cis300.MapViewer
{
    /// <summary>
    /// Represents a strait line segment of a street
    /// </summary>
    public struct StreetSegment
    {
        /// <summary>
        /// Starting point of the segment
        /// </summary>
        private PointF _starting;

        /// <summary>
        /// Ending point of the segment
        /// </summary>
        private PointF _ending;

        /// <summary>
        /// The color and the width of the segment
        /// </summary>
        private Pen _colorWidth;

        /// <summary>
        /// The number of zooms at which the segment is visible
        /// </summary>
        private int _numberOfZoom;

        /// <summary>
        /// Gets and sets the starting point of the segment
        /// </summary>
        public PointF Starting
        {
            get
            {
                return _starting;
            }

            set
            {
                _starting = value;
            }
        }

        /// <summary>
        /// Gets and sets the ending point of the segment
        /// </summary>
        public PointF Ending
        {
            get
            {
                return _ending;
            }

            set
            {
                _ending = value;
            }
        }

        /// <summary>
        /// Gets the number of zooms 
        /// </summary>
        public int NumberOfZoom
        {
            get
            {
                return _numberOfZoom;
            }
        }

        /// <summary>
        /// The constructor that initializes all of the fields
        /// </summary>
        /// <param name="starting">Starting point of the street segment</param>
        /// <param name="ending">Ending point of the street segment</param>
        /// <param name="color">Color of the lines</param>
        /// <param name="width">The width of the lines</param>
        /// <param name="zoom">The number of zooms at which the segment is visible</param>
        public StreetSegment(PointF starting, PointF ending, Color color, float width, int zoom)
        {
            _starting = starting;
            _ending = ending;
            _numberOfZoom = zoom;
            Pen p = new Pen(color, width);
            _colorWidth = p;

        }

        /// <summary>
        /// Draws the street segments 
        /// </summary>
        /// <param name="g">The context on which to draw</param>
        /// <param name="scale">Scale factor for translating the map coordinates to pixel coordinates</param>
        public void Draw(Graphics g, int scale)
        {
            g.DrawLine(_colorWidth, _starting.X * scale, _starting.Y * scale, _ending.X *scale,_ending.Y * scale);

        }
    }
}
