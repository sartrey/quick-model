using System.Collections.Generic;

namespace QuickModel3D.Model
{
    public class ExtremeFilter : Filter
    {
        private Entity _Entity = null;
        private int _Extreme = 0; //0 - x+, 1 - x-, 2 - y+, 3 - y-, 4 - z+, 5 - z-
        private bool _IsAnchor = true;
        private bool _IsOnlyOne = true;

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

        public override void DoWith(Project project)
        {
            var layouts = project.Layouts;
            var arranges = project.Arranges;
            var removed_layouts = new List<Layout>();
            foreach (var layout in layouts)
            {
                int arrange_index = 0;
                foreach (var arrange in arranges)
                {
                    int index = arrange.GetIndexById(_Entity.Id);
                    if (_IsAnchor ^ IsExtremePoint(layout, index, _Extreme, _IsOnlyOne))
                    {
                        if (!layout.InvalidArranges.Contains(arrange_index))
                            layout.InvalidArranges.Add(arrange_index);
                    }
                    arrange_index++;
                }
                if (layout.InvalidArranges.Count == arranges.Count)
                    removed_layouts.Add(layout);
            }
            foreach (var layout in removed_layouts)
                layouts.Remove(layout);
        }

        private bool IsExtremePoint(Layout layout, int index, int extreme, bool only = false)
        {
            var point = layout.Points[index];
            int dim = extreme / 2;
            bool dimd = extreme % 2 == 0;
            int coord = point[dim];
            foreach (var p in layout.Points)
            {
                if (p == point)
                    continue;
                int c = p[dim];
                bool judge = (dimd ? c < coord : c > coord) | (!only & (c == coord));
                if (!judge)
                    return false;
            }
            return true;
        }
    }
}
