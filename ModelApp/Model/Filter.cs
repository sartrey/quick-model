
namespace QuickModel3D.Model
{
    public enum FilterType
    {
        Unknown = 0,
        Extreme = 1,
        Absolute = 2,
        Relative = 3
    }

    public abstract class Filter
    {
        protected static string[] _TypeNames
            = new string[] {
                "未知", "极限", "绝对", "相对"
            };

        public static string GetTypeName(FilterType type)
        {
            return _TypeNames[(int)type];
        }

        protected int _Id
            = -1;
        protected string _Name 
            = null;

        public Filter()
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

        public abstract FilterType Type { get; }

        public abstract int DoWith(Project project);
    }
}
