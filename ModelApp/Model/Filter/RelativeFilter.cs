using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickModel3D.Model
{
    public class RelativeFilter : Filter
    {
        private Entity _EntityA = null;
        private Entity _EntityB = null;
        private bool _IsLink = false;

        public override FilterType Type
        {
            get { return FilterType.Relative; }
        }

        public Entity EntityA
        {
            get { return _EntityA; }
            set { _EntityA = value; }
        }

        public Entity EntityB
        {
            get { return _EntityB; }
            set { _EntityB = value; }
        }

        public bool IsLink 
        {
            get { return _IsLink; }
            set { _IsLink = value; }
        }

        public RelativeFilter() 
        {
        }

        public override int DoWith(Project project)
        {
            throw new NotImplementedException();
        }
    }
}
