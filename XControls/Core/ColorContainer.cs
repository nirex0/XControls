// By Nirex @ github.com/nirex0

using System.Windows.Media;

namespace XControls.Core
{
    public static class ColorContainer
    {
        public static Color FromHexString(string hexstr) => (Color)ColorConverter.ConvertFromString(hexstr);

        public static Color Foreground { get; set; } = FromHexString("#d1a400");
        public static Color GlowForeground { get; set; } = FromHexString("#bbff00");
        public static Color Disabled { get; set; } = FromHexString("#171717");
        public static Color Background { get; set; } = FromHexString("#12151e");
        public static Color AlternativeBackground { get; set; } = FromHexString("#06080f");
    }
}
