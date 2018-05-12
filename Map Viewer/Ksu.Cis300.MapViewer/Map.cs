/*Map.cs
 * Author: Andrew Weber
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu.Cis300.MapViewer
{
    /// <summary>
    /// The graphical control that displays the map
    /// </summary>
    public partial class Map : UserControl
    {
        
         /// <summary>
         /// The max zoom level that can be zoomed in
         /// </summary>
         private const int _maxZoom = 6;
        
         /// <summary>
         /// The scale factor
         /// </summary>
         private int _scale;
        
         /// <summary>
         /// The current zoom level
         /// </summary>
         private int _zoom = 0;
        
         /// <summary>
         /// The map's data
         /// </summary>
         private QuadTree _mapData;
        
         /// <summary>
         /// Finds if the control can zoom in
         /// </summary>
         public bool CanZoomIn
         {
             get
             {
                 if (_zoom < _maxZoom)
                 {
                     return true;
                 }
                 else
                 {
                     return false;
                 }
             }
         }
        
         /// <summary>
         /// Finds if the control can zoom out 
         /// </summary>
         public bool CanZoomOut
         {
             get
             {
                 if (_zoom > 0)
                 {
                     return true;
                 }
                 else
                 {
                     return false;
                 }
             }
         }

        /// <summary>
        /// Initializes the map components and does some exceptoin handling 
        /// </summary>
        /// <param name="streets">The streets in the map</param>
        /// <param name="mapBounds">The map bounds</param>
        /// <param name="scale">The scale factor of the map</param>
        public Map(List<StreetSegment> streets, RectangleF mapBounds, int scale)
        {
            int count = 0;
            foreach (StreetSegment street in streets)
            {
                count++; 

                if (!IsWithinBounds(street.Ending, mapBounds))
                {
                    throw new ArgumentException("Street " + (count -1)+ " is not within the given bounds");
                }
                else if (!IsWithinBounds(street.Starting, mapBounds))
                {
                    throw new ArgumentException("Street " + (count -1)+ " is not within the given bounds");
                }
            }
            InitializeComponent();
            _mapData = new QuadTree(streets, mapBounds, _maxZoom);
            _scale = scale;
            Size = new Size(Convert.ToInt32(mapBounds.Width * scale), Convert.ToInt32(mapBounds.Height * scale));


        }

        /// <summary>
        /// Determines if the coordinates are within the bounds
        /// </summary>
        /// <param name="pf">The points on the map</param>
        /// <param name="rf">The bounds of the map</param>
        /// <returns></returns>
        private static bool IsWithinBounds(PointF pf, RectangleF rf)
         {
             if (pf.X <= rf.Right && pf.X >= rf.Left && pf.Y <= rf.Bottom && pf.Y >= rf.Top)
             {
                 return true;
             }
             else
             {
                 return false;
             }
        
         }
        
         /// <summary>
         /// Zooms the map in if it can
         /// </summary>
         public void ZoomIn()
         {
             if (CanZoomIn)
             {
                 _zoom++;
                _scale *= 2;
                 Size  = new Size(Size.Width *2, Size.Height *2);
                Invalidate();
            }             
         }
        
         /// <summary>
         /// Zooms the map out if it can
         /// </summary>
         public void ZoomOut()
         {
             if (CanZoomOut)
             {
                 _zoom--;
                 _scale /=2;
                 Size  = new Size(Size.Width / 2, Size.Height /2);
                Invalidate();
            }      
         }
        
         /// <summary>
         /// Is called when any poart of the control needs to be redrawn
         /// </summary>
         /// <param name="e"></param>
         protected override void OnPaint(PaintEventArgs e)
         {
             base.OnPaint(e);
            RectangleF rec = e.ClipRectangle;
             e.Graphics.Clip = new Region(rec);
             _mapData.Draw(e.Graphics, _scale, _zoom);
         }      
  }
}

