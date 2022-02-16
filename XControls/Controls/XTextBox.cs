// By Nirex @ github.com/nirex0

using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using XControls.Core;

namespace XControls.Controls
{
    public class XTextBox : TextBox, IXControl
    {
        public bool HasPlaceHolder { get; set; }
        public bool ShouldFlash { get; set; } = true;
        public Label PlaceHolderText_LabelReference { get; set; }

        public XTextBox()
        {
            ControlRegistry.DefaultControlRegistry.Register(this);
            Style = (Style)FindResource("XTEXTBOX");

            MouseEnter += XOnMouseEnter;
            MouseLeave += XOnMouseLeave;
            GotFocus += XOnGotFocus;
            LostFocus += XOnLoseFocus;
            TextChanged += XOnTextChanged;

            VerticalContentAlignment = VerticalAlignment.Center;
            BorderThickness = new Thickness(0, 0, 0, 0);
            FontSize = 14;
            FontWeight = FontWeights.Bold;
            FontFamily = new FontFamily("Global User Interface");

            Foreground = new SolidColorBrush(ColorContainer.Foreground);
            BorderBrush = new SolidColorBrush(ColorContainer.Foreground);
            Background = new SolidColorBrush(ColorContainer.Background);
            SelectionBrush = new SolidColorBrush(ColorContainer.Foreground);
        }

        private void XOnMouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            BorderThickness = new Thickness(2, 0, 0, BorderThickness.Bottom);
            if (!ShouldFlash)
                ColorTransitioner.TextBoxTransitioner.Foreground(this, ColorContainer.GlowForeground);
            ColorTransitioner.TextBoxTransitioner.BorderBrush(this, ColorContainer.GlowForeground);
            ColorTransitioner.TextBoxTransitioner.Background(this, ColorContainer.Background);
            ColorTransitioner.TextBoxTransitioner.SelectionBrush(this, ColorContainer.GlowForeground);
        }
        private void XOnMouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            BorderThickness = new Thickness(0, 0, 0, BorderThickness.Bottom);
            if (!ShouldFlash)
                ColorTransitioner.TextBoxTransitioner.Foreground(this, ColorContainer.Foreground);
            ColorTransitioner.TextBoxTransitioner.BorderBrush(this, ColorContainer.Foreground);
            ColorTransitioner.TextBoxTransitioner.Background(this, ColorContainer.Background);
            ColorTransitioner.TextBoxTransitioner.SelectionBrush(this, ColorContainer.Foreground);
        }
        private void XOnGotFocus(object sender, RoutedEventArgs e)
        {
            BorderThickness = new Thickness(BorderThickness.Left, 0, 0, 2);
        }
        private void XOnLoseFocus(object sender, RoutedEventArgs e)
        {
            BorderThickness = new Thickness(BorderThickness.Left, 0, 0, 0);
        }
        private void XOnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (ShouldFlash)            
                ColorTransitioner.TextBoxTransitioner.Foreground(this, ColorContainer.Foreground, ColorContainer.GlowForeground, 1000);            
            if (Text == string.Empty)
            {
                if (PlaceHolderText_LabelReference != null)
                    PlaceHolderText_LabelReference.Visibility = Visibility.Visible;
            }
            else if (PlaceHolderText_LabelReference != null)
                PlaceHolderText_LabelReference.Visibility = Visibility.Hidden;
        }

        public void SetPlaceHolderLabel(Label lbl)
        {
            PlaceHolderText_LabelReference = lbl;
            HasPlaceHolder = true;
        }

        public void Update()
        {
            if (!ShouldFlash)
                ColorTransitioner.TextBoxTransitioner.Foreground(this, ColorContainer.Foreground);
            ColorTransitioner.TextBoxTransitioner.BorderBrush(this, ColorContainer.Foreground);
            ColorTransitioner.TextBoxTransitioner.Background(this, ColorContainer.Background);
            ColorTransitioner.TextBoxTransitioner.SelectionBrush(this, ColorContainer.Foreground);
        }
    }
}
