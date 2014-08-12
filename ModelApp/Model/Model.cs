using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickModel3D.Model
{
    public class Model
    {
        private int _Id
            = -1;
        private string _Name
            = null;
        private Entity[] _Entities 
            = null;
        private Point[] _Locations
            = null;

        public int Id 
        {
            get { return _Id; }
        }

        public string Name 
        {
            get { return _Name; }
            set { _Name = value; }
        }
    }
}
