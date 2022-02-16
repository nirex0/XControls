// By Nirex @ github.com/nirex0

using System.Collections.Generic;
using System.ComponentModel;

namespace XControls.Core
{
    public class ControlRegistry
    {
        public List<IXControl> Controls { get; private set; }

        public ControlRegistry()
        {
            Controls = new();
        }
        
        public bool Register(IXControl control)
        {
            if (Controls.Contains(control))
                return false;
            Controls.Add(control);
            return true;
        }

        public bool Unregister(IXControl control)
        {
            if (Controls.Contains(control))
            {
                Controls.Remove(control);
                return true;
            }
            return false;
        }

        public void UpdateAll()
        {
            foreach (var control in Controls)
                control.Update();
        }


        public static ControlRegistry DefaultControlRegistry { get; private set; } = new();
    }
}
