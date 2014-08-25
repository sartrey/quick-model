using System.Collections.Generic;
using System.Xml.Linq;

namespace QuickModel3D.Model
{
    public class Layout
    {
        private Point[] _Points
            = null;
        private List<int> _InvalidArranges
            = new List<int>();

        public Point[] Points 
        {
            get { return _Points; }
            set { _Points = value; }
        }

        public XElement ToXML() 
        {
            var xml_layout = new XElement("layout");
            var xml_points = new XElement("points");
            for (int i = 0; i < Points.Length; i++)
            {
                var point = Points[i];
                var xml_point = new XElement("point",
                    new XAttribute("id", i),
                    new XElement("coords",
                        string.Format("{0},{1},{2}",
                        point.X, point.Y, point.Z)));
                xml_points.Add(xml_point);
            }
            xml_layout.Add(xml_points);
            return xml_layout;
        }
    }
}
