using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickModel3D.Model
{
    public class ExtremeFilter : Filter
    {
        private Entity _Entity = null;
        private int _Extreme = 0; //0 - up, 1 - down, 2 - left, 3 - right, 4 - front, 5 - back
        private bool _IsAnchor = false;
        private bool _IsOnlyOne = false;

        public Entity Entity 
        {
            get { return _Entity; }
            set { _Entity = value; }
        }

        public int Extreme
        {
            get { return _Extreme; }
            set { _Extreme = value; }
        }

        public bool IsAnchor
        {
            get { return _IsAnchor; }
            set { _IsAnchor = value; }
        }

        public bool IsOnlyOne
        {
            get { return _IsOnlyOne; }
            set { _IsOnlyOne = value; }
        }
        
        public override FilterType Type
        {
            get { return FilterType.Extreme; }
        }
        
        public override int DoWith(Project project)
        {
            throw new NotImplementedException();
        }
    }
}
