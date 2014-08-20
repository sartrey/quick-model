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
        private Point[] _KeyPoints
            = null;

        public int Id 
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public Entity[] Entities
        {
            get { return _Entities; }
            set
            {
                _Entities = value;
                _KeyPoints = new Point[value.Length];
            }
        }

        public Point[] KeyPoints
        {
            get { return _KeyPoints; }
        }

        public Model() 
        {
        }
    }
}
