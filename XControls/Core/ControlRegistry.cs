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

        public static void UpdateAll()
        {
            foreach (var control in Controls)
                control.Update();
        }
    }
}
