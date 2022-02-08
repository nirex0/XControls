// By Nirex @ github.com/nirex0

using System.Collections.Generic;

namespace XControls.Core
{
    public static class ControlRegistry
    {
        public static List<IXControl> Controls { get; private set; } = new();
        public static bool Register(IXControl control)
        {
            if (Controls.Contains(control))
                return false;
            Controls.Add(control);
            control.Theme = new Militia();
            return true;
        }
        public static bool Unregister(IXControl control)
        {
            if (Controls.Contains(control))
            {
                Controls.Remove(control);
                return true;
            }
            return false;
        }

        public static void UnFocus(IXControl caller)
        {
            foreach (IXControl control in Controls)
                if(caller != control)
                    control.RemoveFocus();            
        }

        public static void UpdateAll()
        {
            foreach (IXControl control in Controls)
            {
                control.Theme = new Militia();
                control.Update();
            }
        }
    }
}
