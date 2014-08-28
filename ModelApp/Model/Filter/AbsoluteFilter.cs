using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickModel3D.Model
{
    public class AbsoluteFilter : Filter
    {
        public AbsoluteFilter() 
        {
        }

        public override int DoWith(Project project)
        {
            throw new NotImplementedException();
        }

        public override FilterType Type
        {
            get { return FilterType.Absolute; }
        }
    }
}
