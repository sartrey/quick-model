﻿using System.Drawing;

namespace QuickModel3D.Model
{
    public class Entity 
    {
        private int _Id = -1;
        private string _Name = null;
        private Shape _Shape 
            = new Shape();
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

        public Shape Shape 
        {
            get { return _Shape; }
            set { _Shape = value; }
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
