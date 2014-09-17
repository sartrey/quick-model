using System;
using System.Collections.Generic;

namespace QuickModel3D.Model
{
    public class Engine
    {
        private string _Version
            = "1.0";
        private Project _Project
            = null;

        public Project Project
        {
            get { return _Project; }
            set { _Project = value; }
        }

        private Layout CreateLayout(List<PointIterator> iters)
        {
            var points = new Point[iters.Count];
            for (int i = 0; i < iters.Count; i++)
            {
                var point = iters[i].ToPoint();
                points[i] = point;
            }
            var layout = new Layout();
            layout.Points = points;
            return layout;
        }

        public void GenerateLayout()
        {
            var layouts = Project.Layouts;
            layouts.Clear();
            int count = Project.EntityHub.Count;
            var stack = new Stack<PointIterator>();
            var points = new List<PointIterator>();
            var point = new PointIterator(0, 0, 0);
            stack.Push(point);
            points.Add(point);
            while (true)
            {
                if (points.Count == count)
                {
                    var layout = CreateLayout(points);
                    layouts.Add(layout);
                    points.Remove(point);
                    stack.Pop();
                    if (stack.Count == 0)
                        break;
                    point = stack.Peek();
                    point.NextStep();
                }
                else
                {
                    if (point.NextPoint == null)
                    {
                        points.Remove(point);
                        stack.Pop();
                        if (stack.Count == 0)
                            break;
                        point = stack.Peek();
                        point.NextStep();
                    }
                    else
                    {
                        point = point.NextPoint;
                        stack.Push(point);
                        points.Add(point);
                    }
                }
            }
        }

        private bool NextArrange(List<int> arrange) 
        {
            int pos1 = 0, pos2 = 0, find = 0;
            int end = arrange.Count - 1;
            pos1 = end;
            while(pos1 != 0)
            {
                pos2 = pos1;
                pos1--;
                if(arrange[pos1] < arrange[pos2])
                {
                    find = end;
                    while (arrange[find] <= arrange[pos1])
                        find--;
                    int temp = arrange[find];
                    arrange[find] = arrange[pos1];
                    arrange[pos1] = temp;
                    arrange.Reverse(pos2, end - pos2 + 1);
                    return true;
                }
            }
            arrange.Reverse(pos1, end - pos1 + 1);
            return false;
        }

        private Arrange CreateArrange(List<int> iters)
        {
            var arrange = new Arrange(iters.Count);
            var entities = Project.EntityHub.EntityArray;
            for (int i = 0; i < iters.Count; i++)
                arrange[i] = entities[iters[i]].Id;
            return arrange;
        }

        public void GenerateArrange()
        {
            var arranges = Project.Arranges;
            arranges.Clear();
            int count = Project.EntityHub.Count;
            //count < 1 return;
            var iters = new List<int>();
            for (int i = 0; i < count; i++)
                iters.Add(i);
            do {
                var arrange = CreateArrange(iters);
                arranges.Add(arrange);
            } while (NextArrange(iters));
        }

        public void DoWithFilter()
        {
            var filters = Project.FilterHub.Filters;
            foreach (var filter in filters)
                filter.DoWith(Project);
        }
    }
}