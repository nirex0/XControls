// By Nirex @ github.com/nirex0

using System.Windows.Media;

namespace XControls.Core
{
    public abstract class ColorTheme
    {
        public static Color FromHexString(string hexstr) => (Color)ColorConverter.ConvertFromString(hexstr);

        public virtual Color NormalForeground { get; set; }
        public virtual Color NormalBorderBrush { get; set; }
        public virtual Color NormalBackground { get; set; }

        public virtual Color HoverForeground { get; set; }
        public virtual Color HoverBorderBrush { get; set; }
        public virtual Color HoverBackground { get; set; }

        public virtual Color PressedForeground { get; set; }
        public virtual Color PressedBorderBrush { get; set; }
        public virtual Color PressedBackground { get; set; }

        public virtual Color FocusedForeground { get; set; }
        public virtual Color FocusedBorderBrush { get; set; }
        public virtual Color FocusedBackground { get; set; }

        public virtual Color DisabledForeground { get; set; }
        public virtual Color DisabledBorderBrush { get; set; }
        public virtual Color DisabledBackground { get; set; }
    }

    public sealed class Militia : ColorTheme
    {
        public override Color NormalForeground { get; set; } = FromHexString("#FFDC00");
        public override Color NormalBorderBrush { get; set; } = FromHexString("#FFDC00");
        public override Color NormalBackground { get; set; } = FromHexString("#12151e");

        public override Color HoverForeground { get; set; } = FromHexString("#5cb800");
        public override Color HoverBorderBrush { get; set; } = FromHexString("#5cb800");
        public override Color HoverBackground { get; set; } = FromHexString("#12151e");

        public override Color PressedForeground { get; set; } = FromHexString("#80FF00");
        public override Color PressedBorderBrush { get; set; } = FromHexString("#80FF00");
        public override Color PressedBackground { get; set; } = FromHexString("#12151e");

        public override Color FocusedForeground { get; set; } = FromHexString("#00ffbb");
        public override Color FocusedBorderBrush { get; set; } = FromHexString("#00ffbb");
        public override Color FocusedBackground { get; set; } = FromHexString("#12151e");

        public override Color DisabledForeground { get; set; } = FromHexString("#ffffff");
        public override Color DisabledBorderBrush { get; set; } = FromHexString("#ffffff");
        public override Color DisabledBackground { get; set; } = FromHexString("#12151e");
    }
    public sealed class Militia_Default : ColorTheme
    {
        public override Color NormalForeground { get; set; } = FromHexString("#00c000");
        public override Color NormalBorderBrush { get; set; } = FromHexString("#30ff60");
        public override Color NormalBackground { get; set; } = FromHexString("#183030");

        public override Color HoverForeground { get; set; } = FromHexString("#a8ff49");
        public override Color HoverBorderBrush { get; set; } = FromHexString("#a8ff49");
        public override Color HoverBackground { get; set; } = FromHexString("#183030");

        public override Color PressedForeground { get; set; } = FromHexString("#00a890");
        public override Color PressedBorderBrush { get; set; } = FromHexString("#00a890");
        public override Color PressedBackground { get; set; } = FromHexString("#486060");

        public override Color FocusedForeground { get; set; } = FromHexString("#183030");
        public override Color FocusedBorderBrush { get; set; } = FromHexString("#f0fff0");
        public override Color FocusedBackground { get; set; } = FromHexString("#00a890");

        public override Color DisabledForeground { get; set; } = FromHexString("#183030");
        public override Color DisabledBorderBrush { get; set; } = FromHexString("#486060");
        public override Color DisabledBackground { get; set; } = FromHexString("#90C0C0");
    }
}