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
        private PointIterator _BasePoint;
        private PointIterator _OffsetPoint;

        public PointIterator BasePoint 
        {
            get { return _BasePoint; }
        }

        public PointIterator Center 
        {
            get { return null; } 
        }
    }
}
