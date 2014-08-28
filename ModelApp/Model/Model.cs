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
                return _Project.LayoutHub[_LayoutIndex];
            }
        }

        public int[] Arrange
        {
            get
            {
                if (_ArrangeIndex < 0)
                    return null;
                return _Project.Arranges[_ArrangeIndex];
            }
        }

        public Model()
        {
        }

        public XElement ToStructureXML()
        {
            var xml = new XElement("model",
                Layout.ToXML(),
                new XElement("arrange",
                    string.Join(",", Arrange)));
            return xml;
        }

        public XElement ToFullXML()
        {
            return null;
        }
    }
}
