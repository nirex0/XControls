// By Nirex @ github.com/nirex0

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace XControls.Core
{
    public static class ColorTransitioner
    {
        public static class ButtonTransitioner
        {
            public static void Foreground(Button ctrl, Color to, int duration = 200)
            {
                if (ctrl.Foreground == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Foreground = new SolidColorBrush(((SolidColorBrush)ctrl.Foreground).Color);
                ctrl.Foreground.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void Background(Button ctrl, Color to, int duration = 200)
            {
                if (ctrl.Background == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Background = new SolidColorBrush(((SolidColorBrush)ctrl.Background).Color);
                ctrl.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void BorderBrush(Button ctrl, Color to, int duration = 200)
            {
                if (ctrl.BorderBrush == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.BorderBrush = new SolidColorBrush(((SolidColorBrush)ctrl.BorderBrush).Color);
                ctrl.BorderBrush.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void Foreground(Button ctrl, Color from, Color to, int duration = 200)
            {
                if (ctrl.Foreground == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Foreground = new SolidColorBrush(from);
                ctrl.Foreground.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void Background(Button ctrl, Color from, Color to, int duration = 200)
            {
                if (ctrl.Background == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Background = new SolidColorBrush(from);
                ctrl.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void BorderBrush(Button ctrl, Color from, Color to, int duration = 200)
            {
                if (ctrl.BorderBrush == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.BorderBrush = new SolidColorBrush(from);
                ctrl.BorderBrush.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
        }

        public static class BorderTransitioner
        {
            public static void Background(Border ctrl, Color to, int duration = 200)
            {
                if (ctrl.Background == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Background = new SolidColorBrush(((SolidColorBrush)ctrl.Background).Color);
                ctrl.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void BorderBrush(Border ctrl, Color to, int duration = 200)
            {
                if (ctrl.BorderBrush == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.BorderBrush = new SolidColorBrush(((SolidColorBrush)ctrl.BorderBrush).Color);
                ctrl.BorderBrush.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void Background(Border ctrl, Color from, Color to, int duration = 200)
            {
                if (ctrl.Background == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Background = new SolidColorBrush(from);
                ctrl.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void BorderBrush(Border ctrl, Color from, Color to, int duration = 200)
            {
                if (ctrl.BorderBrush == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.BorderBrush = new SolidColorBrush(from);
                ctrl.BorderBrush.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
        }

        public static class LabelTransitioner
        {
            public static void Foreground(Label ctrl, Color to, int duration = 200)
            {
                if (ctrl.Foreground == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Foreground = new SolidColorBrush(((SolidColorBrush)ctrl.Foreground).Color);
                ctrl.Foreground.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void Background(Label ctrl, Color to, int duration = 200)
            {
                if (ctrl.Background == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Background = new SolidColorBrush(((SolidColorBrush)ctrl.Background).Color);
                ctrl.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void BorderBrush(Label ctrl, Color to, int duration = 200)
            {
                if (ctrl.BorderBrush == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.BorderBrush = new SolidColorBrush(((SolidColorBrush)ctrl.BorderBrush).Color);
                ctrl.BorderBrush.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void Foreground(Label ctrl, Color from, Color to, int duration = 200)
            {
                if (ctrl.Foreground == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Foreground = new SolidColorBrush(from);
                ctrl.Foreground.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void Background(Label ctrl, Color from, Color to, int duration = 200)
            {
                if (ctrl.Background == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Background = new SolidColorBrush(from);
                ctrl.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void BorderBrush(Label ctrl, Color from, Color to, int duration = 200)
            {
                if (ctrl.BorderBrush == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.BorderBrush = new SolidColorBrush(from);
                ctrl.BorderBrush.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
        }

        public static class ListBoxTransitioner
        {
            public static void Foreground(ListBox ctrl, Color to, int duration = 200)
            {
                if (ctrl.Foreground == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Foreground = new SolidColorBrush(((SolidColorBrush)ctrl.Foreground).Color);
                ctrl.Foreground.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void Background(ListBox ctrl, Color to, int duration = 200)
            {
                if (ctrl.Background == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Background = new SolidColorBrush(((SolidColorBrush)ctrl.Background).Color);
                ctrl.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void BorderBrush(ListBox ctrl, Color to, int duration = 200)
            {
                if (ctrl.BorderBrush == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.BorderBrush = new SolidColorBrush(((SolidColorBrush)ctrl.BorderBrush).Color);
                ctrl.BorderBrush.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void Foreground(ListBox ctrl, Color from, Color to, int duration = 200)
            {
                if (ctrl.Foreground == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Foreground = new SolidColorBrush(from);
                ctrl.Foreground.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void Background(ListBox ctrl, Color from, Color to, int duration = 200)
            {
                if (ctrl.Background == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Background = new SolidColorBrush(from);
                ctrl.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void BorderBrush(ListBox ctrl, Color from, Color to, int duration = 200)
            {
                if (ctrl.BorderBrush == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.BorderBrush = new SolidColorBrush(from);
                ctrl.BorderBrush.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
        }

        public static class ListBoxItemTransitioner
        {
            public static void Foreground(ListBoxItem ctrl, Color to, int duration = 200)
            {
                if (ctrl.Foreground == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Foreground = new SolidColorBrush(((SolidColorBrush)ctrl.Foreground).Color);
                ctrl.Foreground.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void Background(ListBoxItem ctrl, Color to, int duration = 200)
            {
                if (ctrl.Background == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Background = new SolidColorBrush(((SolidColorBrush)ctrl.Background).Color);
                ctrl.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void BorderBrush(ListBoxItem ctrl, Color to, int duration = 200)
            {
                if (ctrl.BorderBrush == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.BorderBrush = new SolidColorBrush(((SolidColorBrush)ctrl.BorderBrush).Color);
                ctrl.BorderBrush.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void Foreground(ListBoxItem ctrl, Color from, Color to, int duration = 200)
            {
                if (ctrl.Foreground == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Foreground = new SolidColorBrush(from);
                ctrl.Foreground.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void Background(ListBoxItem ctrl, Color from, Color to, int duration = 200)
            {
                if (ctrl.Background == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Background = new SolidColorBrush(from);
                ctrl.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void BorderBrush(ListBoxItem ctrl, Color from, Color to, int duration = 200)
            {
                if (ctrl.BorderBrush == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.BorderBrush = new SolidColorBrush(from);
                ctrl.BorderBrush.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
        }

        public static class ProgressBarTransitioner
        {
            public static void Foreground(ProgressBar ctrl, Color to, int duration = 200)
            {
                if (ctrl.Foreground == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Foreground = new SolidColorBrush(((SolidColorBrush)ctrl.Foreground).Color);
                ctrl.Foreground.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void Background(ProgressBar ctrl, Color to, int duration = 200)
            {
                if (ctrl.Background == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Background = new SolidColorBrush(((SolidColorBrush)ctrl.Background).Color);
                ctrl.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void BorderBrush(ProgressBar ctrl, Color to, int duration = 200)
            {
                if (ctrl.BorderBrush == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.BorderBrush = new SolidColorBrush(((SolidColorBrush)ctrl.BorderBrush).Color);
                ctrl.BorderBrush.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void Foreground(ProgressBar ctrl, Color from, Color to, int duration = 200)
            {
                if (ctrl.Foreground == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Foreground = new SolidColorBrush(from);
                ctrl.Foreground.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void Background(ProgressBar ctrl, Color from, Color to, int duration = 200)
            {
                if (ctrl.Background == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Background = new SolidColorBrush(from);
                ctrl.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            } 
            public static void BorderBrush(ProgressBar ctrl, Color from, Color to, int duration = 200)
            {
                if (ctrl.BorderBrush == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.BorderBrush = new SolidColorBrush(from);
                ctrl.BorderBrush.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
        }

        public static class TextBoxTransitioner
        {
            public static void Foreground(TextBox ctrl, Color to, int duration = 200)
            {
                if (ctrl.Foreground == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Foreground = new SolidColorBrush(((SolidColorBrush)ctrl.Foreground).Color);
                ctrl.Foreground.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void Background(TextBox ctrl, Color to, int duration = 200)
            {
                if (ctrl.Background == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Background = new SolidColorBrush(((SolidColorBrush)ctrl.Background).Color);
                ctrl.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void BorderBrush(TextBox ctrl, Color to, int duration = 200)
            {
                if (ctrl.BorderBrush == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.BorderBrush = new SolidColorBrush(((SolidColorBrush)ctrl.BorderBrush).Color);
                ctrl.BorderBrush.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void CaretBrush(TextBox ctrl, Color to, int duration = 200)
            {
                if (ctrl.CaretBrush == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.CaretBrush = new SolidColorBrush(((SolidColorBrush)ctrl.CaretBrush).Color);
                ctrl.CaretBrush.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void SelectionBrush(TextBox ctrl, Color to, int duration = 200)
            {
                if (ctrl.SelectionBrush == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.SelectionBrush = new SolidColorBrush(((SolidColorBrush)ctrl.SelectionBrush).Color);
                ctrl.SelectionBrush.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void Foreground(TextBox ctrl, Color from, Color to, int duration = 200)
            {
                if (ctrl.Foreground == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Foreground = new SolidColorBrush(from);
                ctrl.Foreground.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void Background(TextBox ctrl, Color from, Color to, int duration = 200)
            {
                if (ctrl.Background == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Background = new SolidColorBrush(from);
                ctrl.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void BorderBrush(TextBox ctrl, Color from, Color to, int duration = 200)
            {
                if (ctrl.BorderBrush == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.BorderBrush = new SolidColorBrush(from);
                ctrl.BorderBrush.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void CaretBrush(TextBox ctrl, Color from, Color to, int duration = 200)
            {
                if (ctrl.CaretBrush == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.CaretBrush = new SolidColorBrush(from);
                ctrl.CaretBrush.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void SelectionBrush(TextBox ctrl, Color from, Color to, int duration = 200)
            {
                if (ctrl.SelectionBrush == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.SelectionBrush = new SolidColorBrush(from);
                ctrl.SelectionBrush.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
        }

        public static class RectangleTransitioner
        {
            public static void Fill(Rectangle ctrl, Color to, int duration = 200)
            {
                if (ctrl.Fill == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Fill = new SolidColorBrush(((SolidColorBrush)ctrl.Fill).Color);
                ctrl.Fill.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void Stroke(Rectangle ctrl, Color to, int duration = 200)
            {
                if (ctrl.Stroke == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Stroke = new SolidColorBrush(((SolidColorBrush)ctrl.Stroke).Color);
                ctrl.Stroke.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void Fill(Rectangle ctrl, Color from, Color to, int duration = 200)
            {
                if (ctrl.Fill == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Fill = new SolidColorBrush(from);
                ctrl.Fill.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void Stroke(Rectangle ctrl, Color from, Color to, int duration = 200)
            {
                if (ctrl.Stroke == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Stroke = new SolidColorBrush(from);
                ctrl.Stroke.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
        }

        public static class CheckBoxTransitioner
        {
            public static void Foreground(CheckBox ctrl, Color to, int duration = 200)
            {
                if (ctrl.Foreground == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Foreground = new SolidColorBrush(((SolidColorBrush)ctrl.Foreground).Color);
                ctrl.Foreground.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void Background(CheckBox ctrl, Color to, int duration = 200)
            {
                if (ctrl.Background == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Background = new SolidColorBrush(((SolidColorBrush)ctrl.Background).Color);
                ctrl.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void BorderBrush(CheckBox ctrl, Color to, int duration = 200)
            {
                if (ctrl.BorderBrush == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.BorderBrush = new SolidColorBrush(((SolidColorBrush)ctrl.BorderBrush).Color);
                ctrl.BorderBrush.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void Foreground(CheckBox ctrl, Color from, Color to, int duration = 200)
            {
                if (ctrl.Foreground == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Foreground = new SolidColorBrush(from);
                ctrl.Foreground.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void Background(CheckBox ctrl, Color from, Color to, int duration = 200)
            {
                if (ctrl.Background == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Background = new SolidColorBrush(from);
                ctrl.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void BorderBrush(CheckBox ctrl, Color from, Color to, int duration = 200)
            {
                if (ctrl.BorderBrush == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.BorderBrush = new SolidColorBrush(from);
                ctrl.BorderBrush.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
        }

        public static class ScrollViewerTransitioner
        {
            public static void Foreground(ScrollViewer ctrl, Color to, int duration = 200)
            {
                if (ctrl.Foreground == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Foreground = new SolidColorBrush(((SolidColorBrush)ctrl.Foreground).Color);
                ctrl.Foreground.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void Background(ScrollViewer ctrl, Color to, int duration = 200)
            {
                if (ctrl.Background == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Background = new SolidColorBrush(((SolidColorBrush)ctrl.Background).Color);
                ctrl.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void BorderBrush(ScrollViewer ctrl, Color to, int duration = 200)
            {
                if (ctrl.BorderBrush == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.BorderBrush = new SolidColorBrush(((SolidColorBrush)ctrl.BorderBrush).Color);
                ctrl.BorderBrush.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void Foreground(ScrollViewer ctrl, Color from, Color to, int duration = 200)
            {
                if (ctrl.Foreground == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Foreground = new SolidColorBrush(from);
                ctrl.Foreground.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void Background(ScrollViewer ctrl, Color from, Color to, int duration = 200)
            {
                if (ctrl.Background == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.Background = new SolidColorBrush(from);
                ctrl.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            public static void BorderBrush(ScrollViewer ctrl, Color from, Color to, int duration = 200)
            {
                if (ctrl.BorderBrush == null) return;

                ColorAnimation animation = new ColorAnimation(to, new Duration(TimeSpan.FromMilliseconds(duration = 200)));
                ctrl.BorderBrush = new SolidColorBrush(from);
                ctrl.BorderBrush.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
        }

    }
}
