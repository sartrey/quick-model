using System;
using System.Collections.Generic;

namespace QuickModel3D.Model
{
    public class ModelHub
    {
        private object _SyncRoot
            = new object();
        private List<Model> _Models
            = new List<Model>();
        private Model _CurrentModel
            = null;

        private event Action<Model> _ModelAdded;
        private event Action<Model> _ModelRemoved;

        public Model this[string name] 
        {
            get 
            {
                foreach (var model in _Models)
                    if (model.Name == name)
                        return model;
                return null;
            }
        }

        public int Count 
        {
            get { return _Models.Count; }
        }

        public Model CurrentModel 
        {
            get { return _CurrentModel; }
            set { _CurrentModel = value; }
        }

        public event Action<Model> ModelAdded 
        {
            add { _ModelAdded += value; }
            remove { _ModelAdded -= value; }
        }

        public event Action<Model> ModelRemoved
        {
            add { _ModelRemoved += value; }
            remove { _ModelRemoved -= value; }
        }

        public ModelHub() 
        {
        }

        public void AddModel(Model model) 
        {
            if (this[model.Name] == null)
            {
                _Models.Add(model);
                if (_ModelAdded != null)
                    _ModelAdded(model);
            }
        }

        public void RemoveModel(Model model) 
        {
            if (this[model.Name] != null)
            {
                _Models.Remove(model);
                if (_ModelRemoved != null)
                    _ModelRemoved(model);
            }
        }

        public void RemoveAllModels()
        {

            if (_ModelRemoved != null)
                foreach (var model in _Models)
                    _ModelRemoved(model);
            _Models.Clear();
        }
    }
}
