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
                    int index_a = arrange.GetIndexById(_EntityA.Id);
                    int index_b = arrange.GetIndexById(_EntityB.Id);
                    if (_IsLink ^ IsPointsLinked(layout, index_a, index_b))
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

        public bool IsPointsLinked(Layout layout, int index_a, int index_b)
        {
            var point_a = layout.Points[index_a];
            var point_b = layout.Points[index_b];
            int dist = 
                Math.Abs(point_a.X - point_b.X) + 
                Math.Abs(point_a.Y - point_b.Y) +
                Math.Abs(point_a.Z - point_b.Z);
            return dist == 1;
        }
    }
}
