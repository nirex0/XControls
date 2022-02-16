// By Nirex @ github.com/nirex0

using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Input;
using XControls.Core;

namespace XControls.Controls
{
    public class XButton : Button, IXControl
    {
        public XButton()
        {
            ControlRegistry.DefaultControlRegistry.Register(this);
            Style = (Style)FindResource("XBUTTON");

            MouseEnter += XOnMouseEnter;
            MouseLeave += XOnMouseLeave;
            GotFocus += XOnGotFocus;
            LostFocus += XOnLoseFocus;

            Height = 24;
            Width = 60;
            Content = "Button";                      
            BorderThickness = new Thickness(0, 0, 0, 0);
            FontSize = 14;

            FontWeight = FontWeights.Bold;
            FontFamily = new FontFamily("Global User Interface");

            Foreground = new SolidColorBrush(ColorContainer.Foreground);
            BorderBrush = new SolidColorBrush(ColorContainer.Foreground);
            Background = new SolidColorBrush(ColorContainer.Background);
        }

        private void XOnMouseEnter(object sender, MouseEventArgs e)
        {
            BorderThickness = new Thickness(2, 0, 0, BorderThickness.Bottom);
            ColorTransitioner.ButtonTransitioner.Foreground(this, ColorContainer.GlowForeground);
            ColorTransitioner.ButtonTransitioner.BorderBrush(this, ColorContainer.GlowForeground);
            ColorTransitioner.ButtonTransitioner.Background(this, ColorContainer.Background);
        }
        private void XOnMouseLeave(object sender, MouseEventArgs e)
        {
            BorderThickness = new Thickness(0, 0, 0, BorderThickness.Bottom);
            ColorTransitioner.ButtonTransitioner.Foreground(this, ColorContainer.Foreground);
            ColorTransitioner.ButtonTransitioner.BorderBrush(this, ColorContainer.Foreground);
            ColorTransitioner.ButtonTransitioner.Background(this, ColorContainer.Background);
        }
        private void XOnGotFocus(object sender, RoutedEventArgs e) => BorderThickness = new Thickness(BorderThickness.Left, 0, 0, 2);
        private void XOnLoseFocus(object sender, RoutedEventArgs e) => BorderThickness = new Thickness(BorderThickness.Left, 0, 0, 0);

        public void Update()
        {
            ColorTransitioner.ButtonTransitioner.Foreground(this, ColorContainer.Foreground);
            ColorTransitioner.ButtonTransitioner.BorderBrush(this, ColorContainer.Foreground);
            ColorTransitioner.ButtonTransitioner.Background(this, ColorContainer.Background);
        }
    }
}
