using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickModel3D.Model
{
    public class RelativeFilter : Filter
    {
        public override FilterType Type
        {
            get { return FilterType.Relative; }
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
