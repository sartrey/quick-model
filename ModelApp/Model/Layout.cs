using System;
using System.Collections.Generic;

namespace QuickModel3D.Model
{
    public class Layout
    {
        private List<Entity> _Entities
            = new List<Entity>();
        private Dictionary<int, Point> _Data
            = new Dictionary<int, Point>();
        private List<Point[]> _Layouts
            = new List<Point[]>();

        public void Output(List<Point> layout)
        {
            Console.WriteLine("--layout--");
            foreach (var p in layout)
                Console.WriteLine(
                    string.Format("Point [X:{0} Y:{1} Z:{2}]",
                    p.X, p.Y, p.Z));
            Console.WriteLine("----------");
        }

        public void Generate(int count)
        {
            var stack = new Stack<Point>();
            var layout = new List<Point>();
            var point_zero = new Point(0, 0, 0);
            var point = point_zero;
            stack.Push(point);
            layout.Add(point);
            if (count == 1)
            {
                Output(layout);
                return;
            }
            int layout_count = 0;
            while (true)
            {
                if (layout.Count == count)
                {
                    layout_count++;
                    Output(layout);
                    layout.Remove(point);
                    stack.Pop();
                    point = stack.Peek();
                    point.NextStep();
                }
                else
                {
                    if (point.NextPoint == null)
                    {
                        layout.Remove(point);
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
                        layout.Add(point);
                    }
                }
            }
            Console.WriteLine("layout count: " + layout_count.ToString());
        }
    }
}