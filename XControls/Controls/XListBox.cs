// By Nirex @ github.com/nirex0

using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Input;
using System.Linq;
using XControls.Core;
using System;

namespace XControls.Controls
{
    public class XListBox : ListBox, IXControl
    {
        public XListBoxItem CurrentSelectedItem { get; set; }

        public XListBox()
        {
            ControlRegistry.Register(this);
            Style = (Style)FindResource("XLISTBOX");

            MouseEnter += OnMouseEnterX;
            MouseLeave += OnMouseLeaveX;
            GotFocus += OnGotFocusX;
            LostFocus += OnLostFocus;

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
            BorderThickness = new Thickness(2, 0, 0, BorderThickness.Bottom);
            ColorTransitioner.ListBoxTransitioner.Foreground(this, ColorContainer.GlowForeground);
            ColorTransitioner.ListBoxTransitioner.BorderBrush(this, ColorContainer.GlowForeground);
            ColorTransitioner.ListBoxTransitioner.Background(this, ColorContainer.Background);
        }
        private void OnMouseLeaveX(object sender, MouseEventArgs e)
        {
            BorderThickness = new Thickness(0, 0, 0, BorderThickness.Bottom);
            ColorTransitioner.ListBoxTransitioner.Foreground(this, ColorContainer.Foreground);
            ColorTransitioner.ListBoxTransitioner.BorderBrush(this, ColorContainer.Foreground);
            ColorTransitioner.ListBoxTransitioner.Background(this, ColorContainer.Background);
        }
        private void OnGotFocusX(object sender, RoutedEventArgs e) => BorderThickness = new Thickness(BorderThickness.Left, 0, 0, 2);
        private void OnLostFocus(object sender, RoutedEventArgs e) => BorderThickness = new Thickness(BorderThickness.Left, 0, 0, 0);

        public int Add(string content)
        {
            XListBoxItem item = new XListBoxItem
            {
                XListBoxReference = this,
                Content = content
            };
            Items.Add(item);
            return Items.Count;
        }
        public int Push(string content) => Add(content);        
        public XListBoxItem Get(int index) => Items.GetItemAt(index) as XListBoxItem;
        public XListBoxItem GetRemove(int index)
        {
            XListBoxItem item = Items.GetItemAt(index) as XListBoxItem;
            Items.RemoveAt(index);
            return item;
        }
        public XListBoxItem Pop()
        {
            XListBoxItem item = Items.GetItemAt(Items.Count - 1) as XListBoxItem;
            Items.RemoveAt(Items.Count - 1);
            return item;
        }
        public bool Remove(XListBoxItem item)
        {
            if (Items.Contains(item))
            {
                Items.Remove(item);
                return true;
            }
            return false;
        }

        public void Update()
        {
            ColorTransitioner.ListBoxTransitioner.Foreground(this, ColorContainer.Foreground);
            ColorTransitioner.ListBoxTransitioner.BorderBrush(this, ColorContainer.Foreground);
            ColorTransitioner.ListBoxTransitioner.Background(this, ColorContainer.Background);
        }
    }
}
