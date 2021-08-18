// By Nirex @ github.com/nirex0

using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Input;
using XControls.Core;

namespace XControls.Controls
{
    public class XRoundButton : Button, IXControl
    {
        public XRoundButton()
        {
            ControlRegistry.Register(this);
            Style = (Style)FindResource("XROUND_BUTTON");

            MouseEnter += OnMouseEnterX;
            MouseLeave += OnMouseLeaveX;
            GotFocus += OnGotFocusX;
            LostFocus += OnLostFocusX;

            Height = 42;
            Width = 42;
            Content = "Button";
            BorderThickness = new Thickness(0, 0, 0, 0);
            FontSize = 14;
            FontWeight = FontWeights.Bold;
            FontFamily = new FontFamily("Global User Interface");

            Foreground = new SolidColorBrush(ColorContainer.Foreground);
            BorderBrush = new SolidColorBrush(ColorContainer.Foreground);
            Background = new SolidColorBrush(ColorContainer.Background);
        }

        private void OnMouseEnterX(object sender, MouseEventArgs e)
        {
            ColorTransitioner.ButtonTransitioner.Foreground(this, ColorContainer.GlowForeground);
            ColorTransitioner.ButtonTransitioner.BorderBrush(this, ColorContainer.GlowForeground);
            ColorTransitioner.ButtonTransitioner.Background(this, ColorContainer.Background);
        }
        private void OnMouseLeaveX(object sender, MouseEventArgs e)
        {
            ColorTransitioner.ButtonTransitioner.Foreground(this, ColorContainer.Foreground);
            ColorTransitioner.ButtonTransitioner.BorderBrush(this, ColorContainer.Foreground);
            ColorTransitioner.ButtonTransitioner.Background(this, ColorContainer.Background);
        }
        private void OnGotFocusX(object sender, RoutedEventArgs e) => BorderThickness = new Thickness(2);
        private void OnLostFocusX(object sender, RoutedEventArgs e) => BorderThickness = new Thickness(0);

        public void Update()
        {
            ColorTransitioner.ButtonTransitioner.Foreground(this, ColorContainer.Foreground);
            ColorTransitioner.ButtonTransitioner.BorderBrush(this, ColorContainer.Foreground);
            ColorTransitioner.ButtonTransitioner.Background(this, ColorContainer.Background);
        }
    }
}