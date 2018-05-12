/*QuadTree.cs
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
    /// Stores the map informatoin
    /// </summary>
    public class QuadTree
    {
        /// <summary>
        /// One of the quadtree's four children
        /// </summary>
        private QuadTree _t1;

        /// <summary>
        /// One of the quadtree's four children
        /// </summary>
        private QuadTree _t2;

        /// <summary>
        /// One of the quadtree's four children
        /// </summary>
        private QuadTree _t3;

        /// <summary>
        /// One of the quadtree's four children
        /// </summary>
        private QuadTree _t4;

        /// <summary>
        /// Describes the rectangle im map coordinates
        /// </summary>
        private RectangleF _rectangle;

        /// <summary>
        /// The street segments
        /// </summary>
        private List<StreetSegment> _streets;

        /// <summary>
        /// Splits the street segments by visibility
        /// </summary>
        /// <param name="splitSegment">The street segment that gets split</param>
        /// <param name="height">The height of the tree</param>
        /// <param name="visible">The streets that are visible at the current height</param>
        /// <param name="invisible">The streets that are invisible at the current height</param>
        private static void SplitVisibility(List<StreetSegment> splitSegment, int height, List<StreetSegment> visible, List<StreetSegment> invisible)
        {
            foreach (StreetSegment street in splitSegment)
            {
                if (street.NumberOfZoom > height)
                {
                    visible.Add(street);
                }
                else
                {
                    invisible.Add(street);
                }
            }

        }

        /// <summary>
        /// Splits the street segments into an east and west portion
        /// </summary>
        /// <param name="split">Street segment to split</param>
        /// <param name="vertical">The x value of the vertical line</param>
        /// <param name="west">The street segments west of the vertical line</param>
        /// <param name="east">The street segments east of the vertical line</param>
        private static void SplitEastWest(List<StreetSegment> split, float vertical, List<StreetSegment> west, List<StreetSegment> east)
        {
            foreach(StreetSegment street in split)
            {
                if (street.Ending.X <= vertical && street.Starting.X <= vertical)
                {
                    west.Add(street);
                }
                else if (street.Ending.X >= vertical && street.Starting.X >= vertical)
                {
                    east.Add(street);
                }
                else
                {
                    StreetSegment newEast = street;
                    StreetSegment newWest = street;

                    float newY = ((street.Ending.Y - street.Starting.Y) * (vertical - street.Starting.X) / (street.Ending.X - street.Starting.X)) + street.Starting.Y;
                    PointF pointf = new PointF(vertical, newY);

                    newEast.Ending = pointf;
                    newWest.Starting = pointf;
                    if (newEast.Ending.X >= vertical)
                    {
                        east.Add(newEast);
                        west.Add(newWest);
                    }
                    else
                    {
                        east.Add(newWest);
                        west.Add(newEast);
                    }
                }
            }
        }

        /// <summary>
        /// Splits the streets into a north and south portion
        /// </summary>
        /// <param name="split">The street segment to be split</param>
        /// <param name="horizontal">The y value of the horizontal line</param>
        /// <param name="north">The street segment north of the horizontal line</param>
        /// <param name="south">The street segment south of the horizontal line</param>
        private static void SplitNorthSouth(List<StreetSegment> split, float horizontal, List<StreetSegment> north, List<StreetSegment> south)
        {
            foreach (StreetSegment street in split)
            {
                if (street.Ending.Y <= horizontal && street.Starting.Y <= horizontal)
                {
                    north.Add(street);
                }
                else if (street.Ending.Y >= horizontal && street.Starting.Y >= horizontal)
                {
                    south.Add(street);
                }
                else
                {
                    StreetSegment newNorth = street;
                    StreetSegment newSouth = street;

                    float newX = ((street.Ending.X - street.Starting.X) * (horizontal - street.Starting.Y) / (street.Ending.Y - street.Starting.Y)) + street.Starting.X;
                    PointF pointf = new PointF(newX, horizontal);

                    newNorth.Ending = pointf;
                    newSouth.Starting = pointf;
                    if (newNorth.Starting.Y <= horizontal)
                    {
                        north.Add(newNorth);
                        south.Add(newSouth);
                    }
                    else
                    {
                        north.Add(newSouth);
                        south.Add(newNorth);
                    }
                    
                }
            }
        }

        /// <summary>
        /// Recurisve constructor that builds the tree
        /// </summary>
        /// <param name="ss">The street segments</param>
        /// <param name="rectangle">The area that the tree represents</param>
        /// <param name="height">The height of the tree</param>
        public QuadTree(List<StreetSegment> ss, RectangleF rectangle, int height)
        {
            _rectangle = rectangle;
            if (height == 0)
            {
                _streets = ss;
            }
            else
            {
                List<StreetSegment> east = new List<StreetSegment>();
                List<StreetSegment> west = new List<StreetSegment>();
                List<StreetSegment> visible = new List<StreetSegment>();
                List<StreetSegment> invisible = new List<StreetSegment>();
                List<StreetSegment> northeast = new List<StreetSegment>();
                List<StreetSegment> northwest = new List<StreetSegment>();
                List<StreetSegment> southeast = new List<StreetSegment>();
                List<StreetSegment> southwest = new List<StreetSegment>();

                SplitVisibility(ss, height, visible, invisible);
                _streets = visible;

                SplitEastWest(ss, (rectangle.Width + rectangle.Left), west, east);
                SplitNorthSouth(east, (rectangle.Height + rectangle.Top), northeast, southeast);
                SplitNorthSouth(west, (rectangle.Height + rectangle.Top), northwest, southwest);

                RectangleF rec = new RectangleF(0,0, rectangle.Width, rectangle.Height);
                _t1 = new QuadTree(northwest, rec, height - 1);
                _t2 = new QuadTree(northeast, rec, height - 1);
                _t3 = new QuadTree(southwest, rec, height - 1);
                _t4 = new QuadTree(southeast, rec, height - 1);
            }

        }

        /// <summary>
        /// Draws the tree onto the panel
        /// </summary>
        /// <param name="draw">The graphics on which to draw</param>
        /// <param name="scale">The scale factor for translating map coordinates to pixel coordinates</param>
        /// <param name="depth">The max depth of the tree nodes</param>
        public void Draw(Graphics draw, int scale, int depth)
        {
            RectangleF rec = new RectangleF(draw.ClipBounds.X / scale, draw.ClipBounds.Y / scale, draw.ClipBounds.Width / scale, draw.ClipBounds.Height / scale);
            
            if (_rectangle.IntersectsWith(rec))
            {
                foreach(StreetSegment street in _streets)
                {
                    street.Draw(draw, scale);
                }
                if (depth > 0)
                {
                    _t1.Draw(draw, scale, depth - 1);
                    _t2.Draw(draw, scale, depth - 1);
                    _t3.Draw(draw, scale, depth - 1);
                    _t4.Draw(draw, scale, depth - 1);
                }

            }

        }

    }
}
