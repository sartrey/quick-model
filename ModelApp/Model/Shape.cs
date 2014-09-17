using System.Xml.Linq;

namespace QuickModel3D.Model
{
    public enum ShapeType
    {
        Cube,
        Sphere,
        Cylinder
    }

    public class Shape
    {
        private ShapeType _Type;
        private PointF _Translate;
        private PointF _Scale;
        private PointF _Rotate;

        public ShapeType Type 
        {
            get { return _Type; }
            set { _Type = value; }
        }

        public string TypeName 
        {
            get 
            {
                switch(_Type)
                {
                    case ShapeType.Cube: 
                        return "cube";
                    case ShapeType.Cylinder : 
                        return "cylinder";
                    case ShapeType.Sphere:
                        return "sphere";
                    default:
                        return null;
                }
            }
        }

        public PointF Translate
        {
            get { return _Translate; }
        }

        public PointF Scale
        {
            get { return _Scale; }
        }
        
        public PointF Rotate
        {
            get { return _Rotate; }
        }

        public Shape() 
        {
            _Type = ShapeType.Cube;
            _Translate = new PointF(0, 0, 0);
            _Scale = new PointF(1, 1, 1);
            _Rotate = new PointF(0, 0, 0);
        }

        public XElement ToXML()
        {
            var xml = new XElement("shape",
                new XElement("type", TypeName),
                new XElement("translate",
                    string.Format("{0},{1},{2}",
                    _Translate.X, _Translate.Y, _Translate.Z)),
                new XElement("scale",
                    string.Format("{0},{1},{2}",
                    _Scale.X, _Scale.Y, _Scale.Z)),
                new XElement("rotate",
                    string.Format("{0},{1},{2}",
                    _Rotate.X, _Rotate.Y, _Rotate.Z)));
            return xml;
        }
    }
}
