using System;
using System.Collections.Generic;

namespace QuickModel3D.Model
{
    public class LayoutHub
    {
        private object _SyncRoot
            = new object();
        private List<Layout> _Layouts
            = new List<Layout>();
        private event Action<Layout> _LayoutAdded;

        public Layout this[int index] 
        {
            get { return _Layouts[index]; }
        }

        public int Count 
        {
            get { return _Layouts.Count; }
        }

        public event Action<Layout> LayoutAdded 
        {
            add { _LayoutAdded += value; }
            remove { _LayoutAdded -= value; }
        }
        public LayoutHub() 
        {
        }

        public void AddLayout(Layout layout)
        {
            _Layouts.Add(layout);
            if (_LayoutAdded != null)
                _LayoutAdded(layout);
        }

        public void RemoveAllLayouts() 
        {
            _Layouts.Clear();
        }
    }
}
