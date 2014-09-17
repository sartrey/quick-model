using System.Xml.Linq;

namespace QuickModel3D.Model
{
    public class Arrange
    {
        private int[] _Ids = null;

        public int[] Ids 
        {
            get { return _Ids; }
            set { _Ids = value; }
        }

        public int this[int index]
        {
            get { return _Ids[index]; }
            set { _Ids[index] = value; }
        }

        public Arrange(int count) 
        {
            _Ids = new int[count];
        }

        public int GetIndexById(int id) 
        {
            for (int i = 0; i < _Ids.Length; i++) 
                if (id == _Ids[i])
                    return i;
            return -1;
        }

        public XElement ToXML() 
        {
            var xml_arrange = new XElement(
                "arrange", string.Join(",", _Ids));
            return xml_arrange;
        }
    }
}
