﻿using System.Drawing;

namespace QuickModel3D.Model
{
    public class Entity 
    {
        private int _Id = -1;
        private string _Name = null;
        private Image _Texture = null;

        public Entity() 
        {
        }

        public int Id 
        { 
            get { return _Id; }
            set { _Id = value; }
        }

        public string Name 
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public Image Texture 
        {
            get { return _Texture; }
            set 
            {
                if (value == _Texture)
                    return;
                if (_Texture != null)
                    _Texture.Dispose();
                _Texture = value; 
            }
        }
    }
}
