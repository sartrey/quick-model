using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickModel3D.Model
{
    public abstract class Filter
    {
        protected int _Id
            = -1;
        protected string _Name 
            = null;

        public Filter()
        {
        }
        
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string Name 
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public abstract int DoWith(Project project);
    }
}
