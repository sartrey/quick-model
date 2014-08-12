using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickModel3D.Model
{
    public class Filter
    {
        protected int _Id;
        protected string _Name;

        public int Id 
        {
            get { return _Id; }
        }

        public string Name 
        {
            get { return _Name; }
        }

        public Filter(int id) 
        {
            _Id = id;
        }
    }
}
