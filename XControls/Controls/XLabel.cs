// By Nirex @ github.com/nirex0

using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using XControls.Core;

namespace XControls.Controls
{
    public class XLabel : Label, IXControl
    {
        public bool IsPlaceHolder { get; set; }
        public TextBox PlaceHolderText_TextBoxReference { get; set; }

        public XLabel()
        {
            ControlRegistry.Register(this);

            MouseEnter += OnMouseEnterX;
            MouseLeave += OnMouseLeaveX;
            MouseDown += OnMouseDownX;

            BorderThickness = new Thickness(0);
            FontSize = 14;
            FontWeight = FontWeights.Bold;
            FontFamily = new FontFamily("Global User Interface");

            Foreground = new SolidColorBrush(ColorContainer.Foreground);
        }

        private void OnMouseEnterX(object sender, MouseEventArgs e)
        {
            ColorTransitioner.LabelTransitioner.Foreground(this, ColorContainer.GlowForeground);
            if (IsPlaceHolder)
            {
                Mouse.OverrideCursor = null;
                Cursor = Cursors.IBeam;
            }
        }
        private void OnMouseLeaveX(object sender, MouseEventArgs e)
        {
            ColorTransitioner.LabelTransitioner.Foreground(this, ColorContainer.Foreground);
            if (IsPlaceHolder)
            {
                Mouse.OverrideCursor = null;
                Cursor = Cursors.Arrow;
            }
        }
        private void OnMouseDownX(object sender, MouseButtonEventArgs e)
        {
            if (PlaceHolderText_TextBoxReference != null)
            {
                PlaceHolderText_TextBoxReference.Focusable = true;
                PlaceHolderText_TextBoxReference.Focus();
            }
        }

        public void SetPlaceHolderTextBox(TextBox tb)
        {
            PlaceHolderText_TextBoxReference = tb;
            IsPlaceHolder = true;
        }

        public void Update()
        {
            ColorTransitioner.LabelTransitioner.Foreground(this, ColorContainer.Foreground);
        }
    }
}
