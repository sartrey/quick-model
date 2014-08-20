using System;
using System.Collections.Generic;

namespace QuickModel3D.Model
{
    public class Engine
    {
        private Project _Project
            = null;

        private event Action<Model> _ModelCreated;

        public Project Project
        {
            get { return _Project; }
            set { _Project = value; }
        }

        public event Action<Model> ModelCreated 
        {
            add { _ModelCreated += value; }
            remove { _ModelCreated -= value; }
        }

        public void Output(List<PointIterator> layout)
        {
            Console.WriteLine("--layout--");
            foreach (var p in layout)
                Console.WriteLine(
                    string.Format("Point [X:{0} Y:{1} Z:{2}]",
                    p.X, p.Y, p.Z));
            Console.WriteLine("----------");

            int count = Project.Entities.Count;
            var model = new Model();
            model.Entities = Project.Entities.EntityArray;
            for (int i = 0; i < count; i++)
                model.KeyPoints[i] = layout[i].ToPoint();
            if (_ModelCreated != null)
                _ModelCreated(model);
        }

        public void Generate()
        {
            int count = Project.Entities.Count;
            var stack = new Stack<PointIterator>();
            var layout = new List<PointIterator>();
            var point = new PointIterator(0, 0, 0);
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