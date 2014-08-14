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
        private Entity[] _Entities 
            = null;
        private Point[] _Locations
            = null;

        public int Id 
        {
            get { return _Id; }
        }

        public Entity[] Entities 
        {
            get { return _Entities; }
        }

        public Point[] Locations 
        {
            get { return _Locations; }
        }

        public Model(int space) 
        {
            _Entities = new Entity[space];
            _Locations = new Point[space];
        }
    }
}
