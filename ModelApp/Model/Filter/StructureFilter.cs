using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickModel3D.Model
{
    public class StructureFilter : Filter
    {
        public override FilterType Type
        {
            get { return FilterType.Unknown; }
        }

        public StructureFilter()
        {
        }

        public override int DoWith(Project project)
        {
            throw new NotImplementedException();
        }
    }
}
