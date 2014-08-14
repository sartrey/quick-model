using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace QuickModel3D.Model
{
    public class Engine
    {
        private Project _Project
            = null;

        private event Action _ModelCreated;

        public Project Project
        {
            get { return _Project; }
            set { _Project = value; }
        }

        public event Action ModelCreated 
        {
            add { _ModelCreated += value; }
            remove { _ModelCreated -= value; }
        }

        public void Output(List<Point> layout)
        {
            Console.WriteLine("--layout--");
            foreach (var p in layout)
                Console.WriteLine(
                    string.Format("Point [X:{0} Y:{1} Z:{2}]",
                    p.X, p.Y, p.Z));
            Console.WriteLine("----------");
        }

        public void Generate()
        {
            int count = _Project.Entities.Count;
            var stack = new Stack<Point>();
            var layout = new List<Point>();
            var point = new Point(0, 0, 0);
            stack.Push(point);
            layout.Add(point);
            while (true)
            {
                if (layout.Count == count)
                {
                    Output(layout);
                    layout.Remove(point);
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
        }
    }
}