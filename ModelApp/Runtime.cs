using QuickModel3D.Model;
using Sartrey;
using Sartrey.UI;
using System.Windows.Forms;

namespace QuickModel3D
{
    public class Runtime
    {
        private static object _CtorLock
            = new object();
        private static Runtime _Instance 
            = null;

        public static Runtime Instance 
        {
            get 
            {
                if(_Instance == null)
                    lock (_CtorLock) {
                        if(_Instance == null)
                            _Instance = new Runtime();
                    }
                return _Instance;
            }
        }

        private WindowHub _WindowHub
            = new WindowHub();
        private Project _Project
            = null;
        private Engine _Engine
            = new Engine();
        private ModelHub _ModelHub
            = new ModelHub();

        public WindowHub WindowHub 
        {
            get { return _WindowHub; }
        }

        public Project Project
        {
            get { return _Project; }
            set 
            {
                _Project = value;
                _Engine.Project = value;
            }
        }

        public Engine Engine 
        {
            get { return _Engine; }
        }

        public ModelHub ModelHub 
        {
            get { return _ModelHub; }
        }

        public Control GetViewById(string id) 
        {
            var panel = _WindowHub[id] as UI.Panel;
            return panel.View;
        }
    }
}
