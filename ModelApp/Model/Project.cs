using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickModel3D.Model
{
    public class Project
    {
        private string _Path
            = null;

        private EntityHub _Entities
            = new EntityHub();
        private FilterHub _Filters
            = new FilterHub();

        public string Path 
        {
            get { return _Path; }
            set { _Path = value; }
        }

        public EntityHub Entities
        {
            get { return _Entities; }
        }

        public FilterHub Filters 
        {
            get { return _Filters; }
        }

        public void Load(string path) 
        {
            _Path = path;
        }
    }
}
