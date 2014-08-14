using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickModel3D.Model
{
    public class Filter
    {
        protected int _Id;

        public int Id 
        {
            get { return _Id; }
        }

        public Filter(int id) 
        {
            _Id = id;
        }
    }
}
