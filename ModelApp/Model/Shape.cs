using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickModel3D.Model
{
    public enum ShapeType
    {
        Cube,
        Sphere,
        Pyramid
    }

    public class Shape
    {
        private Point _BasePoint;
        private Point _OffsetPoint;

        public Point BasePoint 
        {
            get { return _BasePoint; }
        }

        public Point Center 
        {
            get { return null; } 
        }
    }
}
