// By Nirex @ github.com/nirex0

using System.Windows.Controls;

namespace XControls.Core
{
    public static class Modulaton
    {
        public class ScrollViewerModulation
        {
            private ScrollViewer Current;
            private ScrollViewer Previous;

            public void LinearSwitch(ScrollViewer ToShow)
            {
                if (ToShow == Current) return;
                Current = ToShow;

                if (Previous != null)
                    Previous.Visibility = System.Windows.Visibility.Hidden;
                Previous = Current;

                Current.Visibility = System.Windows.Visibility.Visible;
            }
        }
    }
}
