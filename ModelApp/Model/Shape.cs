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
        private ShapeType _Type;
        private Point _Translate;
        private Point _Scale;
        private Point _Rotate;

        public ShapeType Type 
        {
            get { return _Type; }
        }

        public Point Translate
        {
            get { return _Translate; }
        }

        public Point Scale
        {
            get { return _Scale; }
        }
        
        public Point Rotate
        {
            get { return _Rotate; }
        }

        public Shape() 
        {
            _Type = ShapeType.Cube;
            _Translate = new Point(0, 0, 0);
            _Scale = new Point(0, 0, 0);
            _Rotate = new Point(0, 0, 0);
        }
    }
}
