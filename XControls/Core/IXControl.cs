// By Nirex @ github.com/nirex0

using System.ComponentModel;

namespace XControls.Core
{
    public enum ControlState
    {
        Invalid,
        Normal,
        Hovered,
        Pressed,
        Focused,
        Disabled,
    }
    public interface IXControl
    {
        public abstract ColorTheme Theme { get; set; }
        public abstract void Update();
        public abstract ControlState GetState();
        public abstract void RemoveFocus();
    }

}
