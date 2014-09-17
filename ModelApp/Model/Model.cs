using System.Collections.Generic;
using System.Xml.Linq;

namespace QuickModel3D.Model
{
    public class Model
    {
        private string _Name
            = null;
        private Project _Project
            = null;
        private int _LayoutIndex
            = -1;
        private int _ArrangeIndex
            = -1;
        private List<Shape> _Shapes
            = new List<Shape>();

        public string Name
        {
            get { return _Name; }
            set { _Name = string.IsNullOrWhiteSpace(value) ? null : value; }
        }

        public Project Project
        {
            get { return _Project; }
            set { _Project = value; }
        }

        public int LayoutIndex
        {
            get { return _LayoutIndex; }
            set { _LayoutIndex = value; }
        }

        public int ArrangeIndex
        {
            get { return _ArrangeIndex; }
            set { _ArrangeIndex = value; }
        }

        public Entity[] Entities
        {
            get { return Project.EntityHub.EntityArray; }
        }

        public Layout Layout
        {
            get
            {
                if (_LayoutIndex < 0)
                    return null;
                return _Project.Layouts[_LayoutIndex];
            }
        }

        public Arrange Arrange
        {
            get
            {
                if (_ArrangeIndex < 0)
                    return null;
                return _Project.Arranges[_ArrangeIndex];
            }
        }

        public List<Shape> Shapes 
        {
            get { return _Shapes; }
        }

        public Model()
        {
        }

        public XElement ToStructureXML()
        {
            var xml_layout = Layout.ToXML();
            xml_layout.Add(
                new XAttribute("index", _LayoutIndex + 1));
            var xml_arrange = Arrange.ToXML();
            xml_arrange.Add(
                new XAttribute("index", _ArrangeIndex + 1));
            var xml = new XElement("model",
                xml_layout,
                xml_arrange);
            return xml;
        }

        public XElement ToFullXML()
        {
            var xml_layout = Layout.ToXML();
            xml_layout.Add(
                new XAttribute("index", _LayoutIndex + 1));
            var xml_arrange = Arrange.ToXML();
            xml_arrange.Add(
                new XAttribute("index", _ArrangeIndex + 1));
            var xml_shape = new XElement("shapes");
            foreach (var shape in _Shapes)
                xml_shape.Add(shape.ToXML());
            var xml = new XElement("model",
                xml_layout,
                xml_arrange,
                xml_shape);
            return xml;
        }
    }
}
