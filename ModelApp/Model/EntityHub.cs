using System;
using System.Collections.Generic;

namespace QuickModel3D.Model
{
    public class EntityHub
    {
        private object _SyncRoot
            = new object();
        private List<Entity> _Entities
            = new List<Entity>();
        private Entity _CurrentEntity
            = null;
        private Entity[] _EntityArray
            = null;

        private event Action<Entity> _EntityAdded;
        private event Action<Entity> _EntityRemoved;
        private event Action<Entity> _EntityUpdated;

        public Entity this[int id] 
        {
            get 
            {
                foreach (var entity in _Entities)
                    if (entity.Id == id)
                        return entity;
                return null;
            }
        }

        public int NewId 
        {
            get 
            {
                var ids = new List<int>();
                foreach (Entity entity in _Entities)
                    ids.Add(entity.Id);
                ids.Sort();
                for (int i = 0; i < ids.Count; i++) 
                    if (i != ids[i] - 1)
                        return i + 1;
                return ids.Count + 1;
            }
        }

        public int Count 
        {
            get { return _Entities.Count; }
        }

        public Entity CurrentEntity 
        {
            get { return _CurrentEntity; }
            set { _CurrentEntity = value; }
        }

        public Entity[] EntityArray 
        {
            get
            {
                if (_EntityArray == null)
                    _EntityArray = _Entities.ToArray();
                return _EntityArray;
            }
        }

        public event Action<Entity> EntityAdded 
        {
            add { _EntityAdded += value; }
            remove { _EntityAdded -= value; }
        }

        public event Action<Entity> EntityRemoved
        {
            add { _EntityRemoved += value; }
            remove { _EntityRemoved -= value; }
        }

        public event Action<Entity> EntityUpdated
        {
            add { _EntityUpdated += value; }
            remove { _EntityUpdated -= value; }
        }

        public EntityHub() 
        {
        }

        public void AddEntity(Entity entity) 
        {
            if (this[entity.Id] == null)
            {
                _Entities.Add(entity);
                if (_EntityAdded != null)
                    _EntityAdded(entity);
            }
        }

        public void RemoveEntity(Entity entity) 
        {
            if (this[entity.Id] != null)
            {
                _Entities.Remove(entity);
                if (_EntityRemoved != null)
                    _EntityRemoved(entity);
            }
        }

        public void UpdateEntity(Entity entity) 
        {
            if (_EntityUpdated != null)
                _EntityUpdated(entity);
        }
    }
}
