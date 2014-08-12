using System;
using System.Collections.Generic;

namespace QuickModel3D.Model
{
    public class FilterHub
    {
        private object _SyncRoot
            = new object();
        private List<Filter> _Filters
            = new List<Filter>();
        private Filter _CurrentFilter
            = null;

        private event Action<Filter> _FilterAdded;
        private event Action<Filter> _FilterRemoved;
        private event Action<Filter> _FilterSelected;

        public Filter this[int id] 
        {
            get 
            {
                foreach (var filter in _Filters)
                    if (filter.Id == id)
                        return filter;
                return null;
            }
        }

        public int NewId 
        {
            get 
            {
                var ids = new List<int>();
                foreach (Filter filter in _Filters)
                    ids.Add(filter.Id);
                ids.Sort();
                for (int i = 0; i < ids.Count; i++) 
                    if (i != ids[i] - 1)
                        return i + 1;
                return ids.Count + 1;
            }
        }

        public int Count 
        {
            get { return _Filters.Count; }
        }

        public Filter CurrentFilter 
        {
            get { return _CurrentFilter; }
            set 
            {
                _CurrentFilter = value;
                if(_FilterSelected != null)
                    _FilterSelected(value);
            }
        }

        public event Action<Filter> FilterAdded 
        {
            add { _FilterAdded += value; }
            remove { _FilterAdded -= value; }
        }

        public event Action<Filter> FilterRemoved
        {
            add { _FilterRemoved += value; }
            remove { _FilterRemoved -= value; }
        }

        public event Action<Filter> FilterSelected
        {
            add { _FilterSelected += value; }
            remove { _FilterSelected -= value; }
        }

        public FilterHub() 
        {
        }

        public void LinkFilter(Filter filter) 
        {
            if (this[filter.Id] == null)
            {
                _Filters.Add(filter);
                if (_FilterAdded != null)
                    _FilterAdded(filter);
            }
        }

        public void KickFilter(Filter filter) 
        {
            if (this[filter.Id] != null)
            {
                _Filters.Remove(filter);
                if (_FilterRemoved != null)
                    _FilterRemoved(filter);
            }
        }
    }
}
