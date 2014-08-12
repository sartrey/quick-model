
namespace QuickModel3D.Model
{
    public class Point
    {
        private int _X;
        private int _Y;
        private int _Z;

        private int _Skip; //1-X+, 2-X-, 3-Y+, 4-Y-, 5-Z+, 6-Z- 0
        private int _Step; //1-X+, 2-X-, 3-Y+, 4-Y-, 5-Z+, 6-Z- 0

        public Point(int x, int y, int z)
        {
            ResetStep();
            _X = x;
            _Y = y;
            _Z = z;
        }

        public int X { get { return _X; } }

        public int Y { get { return _Y; } }

        public int Z { get { return _Z; } }

        public Point NextPoint
        {
            get
            {
                Point point = null;
                if (_Step == _Skip)
                    NextStep();
                switch (_Step)
                {
                    case 1:
                        point = new Point(_X + 1, _Y, _Z);
                        point._Skip = 2;
                        break;
                    case 2:
                        point = new Point(_X - 1, _Y, _Z);
                        point._Skip = 1;
                        break;
                    case 3:
                        point = new Point(_X, _Y + 1, _Z);
                        point._Skip = 4;
                        break;
                    case 4:
                        point = new Point(_X, _Y - 1, _Z);
                        point._Skip = 3;
                        break;
                    case 5:
                        point = new Point(_X, _Y, _Z + 1);
                        point._Skip = 6;
                        break;
                    case 6:
                        point = new Point(_X, _Y, _Z - 1);
                        point._Skip = 5;
                        break;
                }
                return point;
            }
        }

        public void NextStep()
        {
            if (_Step > 0 && _Step < 6)
            {
                _Step++;
                if (_Step == _Skip)
                    _Step++;
            }
            else if (_Step >= 6)
                _Step = 0;
        }

        public void ResetStep()
        {
            _Step = 1;
            _Skip = 0;
        }
    }
}