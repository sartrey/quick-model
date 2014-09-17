using System.Collections.Generic;
using System.Xml.Linq;

namespace QuickModel3D.Model
{
    public class Project
    {
        private EntityHub _EntityHub
            = new EntityHub();
        private FilterHub _FilterHub
            = new FilterHub();
        private List<Layout> _Layouts
            = new List<Layout>();
        private List<Arrange> _Arranges
            = new List<Arrange>();
        private string _EngineVersion
            = null;

        public EntityHub EntityHub
        {
            get { return _EntityHub; }
        }

        public FilterHub FilterHub 
        {
            get { return _FilterHub; }
        }

        public List<Layout> Layouts
        {
            get { return _Layouts; }
        }

        public List<Arrange> Arranges
        {
            get { return _Arranges; }
        }

        public void Load(string path) 
        {
        }

        public XElement ToXML() 
        {
            return null;
        }
    }
}
