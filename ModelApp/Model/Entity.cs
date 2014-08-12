using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace QuickModel3D.Model
{
    public class Entity 
    {
        private int _Id;
        private string _Name;
        private int _X;
        private int _Y;
        private int _Z;

        public Entity(int id) 
        {
            _Id = id;
        }

        [Category("基本")]
        public int Id 
        { 
            get { return _Id; } 
        }

        [Category("基本")]
        public string Name 
        {
            get { return _Name; }
        }

        [Category("质心")]
        public int X 
        {
            get { return _X; }
        }

        [Category("质心")]
        public int Y 
        {
            get { return _Y; }
        }

        [Category("质心")]
        public int Z 
        {
            get { return _Z; }
        }
    }
}
