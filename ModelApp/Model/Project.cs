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
        private LayoutHub _LayoutHub
            = new LayoutHub();
        private List<int[]> _Arranges
            = new List<int[]>();
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

        public LayoutHub LayoutHub
        {
            get { return _LayoutHub; }
        }

        public List<int[]> Arranges
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
