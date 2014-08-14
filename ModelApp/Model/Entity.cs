using System.Drawing;

namespace QuickModel3D.Model
{
    public class Entity 
    {
        private int _Id = -1;
        private string _Name = null;
        private Shape _Shape = null;
        private Image _Texture = null;

        public Entity(int id) 
        {
            _Id = id;
        }

        public int Id 
        { 
            get { return _Id; } 
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
