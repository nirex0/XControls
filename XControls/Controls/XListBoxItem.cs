// By Nirex @ github.com/nirex0

using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using XControls.Core;

namespace XControls.Controls
{
    public class XListBoxItem : ListBoxItem, IXControl
    {
        public XListBox XListBoxReference { get; set; }
        public bool IsSelectedItem { get; private set; }

        public XListBoxItem()
        {
            ControlRegistry.DefaultControlRegistry.Register(this);
            Style = (Style)FindResource("XLISTBOXITEM");

            Selected += OnSelectedX;

            BorderThickness = new Thickness(2, 2, 2, 2);
            FontSize = 14;
            FontWeight = FontWeights.Bold;
            FontFamily = new FontFamily("Global User Interface");

            Foreground = new SolidColorBrush(ColorContainer.Foreground);
            BorderBrush = new SolidColorBrush(ColorContainer.Background);
            Background = new SolidColorBrush(ColorContainer.Background);
        }

        private void OnSelectedX(object sender, RoutedEventArgs e)
        {
            foreach (var item in XListBoxReference.Items)
            {
                XListBoxItem tmpItem = item as XListBoxItem;
                tmpItem.IsSelectedItem = false;
                ColorTransitioner.ListBoxItemTransitioner.Foreground(tmpItem, ColorContainer.Foreground);
                ColorTransitioner.ListBoxItemTransitioner.BorderBrush(tmpItem, ColorContainer.Background);
                ColorTransitioner.ListBoxItemTransitioner.Background(tmpItem, ColorContainer.Background);
            }
            XListBoxReference.CurrentSelectedItem = this;
            IsSelectedItem = true;
            ColorTransitioner.ListBoxItemTransitioner.Foreground(this, ColorContainer.GlowForeground);
            ColorTransitioner.ListBoxItemTransitioner.BorderBrush(this, ColorContainer.GlowForeground);
            ColorTransitioner.ListBoxItemTransitioner.Background(this, ColorContainer.Background);
        }

        public void Update()
        {
            ColorTransitioner.ListBoxItemTransitioner.Foreground(this, ColorContainer.Foreground);
            ColorTransitioner.ListBoxItemTransitioner.BorderBrush(this, ColorContainer.Background);
            ColorTransitioner.ListBoxItemTransitioner.Background(this, ColorContainer.Background);
        }
    }
}