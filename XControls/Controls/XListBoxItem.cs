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
            ControlRegistry.Register(this);
            Foreground = new SolidColorBrush(theme.NormalForeground);
            BorderBrush = new SolidColorBrush(theme.NormalBorderBrush);
            Background = new SolidColorBrush(theme.NormalBackground);
            SetupEvents();
            Update();

            Style = (System.Windows.Style)FindResource("XLISTBOXITEM");



            BorderThickness = new Thickness(2, 2, 2, 2);
            FontSize = 14;
            FontWeight = FontWeights.Bold;
            FontFamily = new FontFamily("Global User Interface");
        }

        #region XCONTROL
        private ColorTheme theme;
        public ColorTheme Theme { get { return theme; } set { theme = value; } }
        public ControlState CurrentState { get; protected set; }
        public bool HandleColors { get; set; } = true;

        public void RemoveFocus()
        {
            switch (CurrentState)
            {
                default:
                case ControlState.Invalid:
                    CurrentState = ControlState.Normal;
                    break;
                case ControlState.Normal:
                    CurrentState = ControlState.Normal;
                    break;
                case ControlState.Hovered:
                    CurrentState = ControlState.Hovered;
                    break;
                case ControlState.Pressed:
                    CurrentState = ControlState.Pressed;
                    break;
                case ControlState.Focused:
                    CurrentState = ControlState.Normal;
                    break;
                case ControlState.Disabled:
                    CurrentState = ControlState.Disabled;
                    break;
            }
            Update();
        }

        public void Update()
        {
            if (!HandleColors) return;


            switch (CurrentState)
            {
                default:
                case ControlState.Invalid:
                case ControlState.Normal:
                    {
                        ColorTransitioner.ListBoxItemTransitioner.Foreground(this, theme.NormalForeground);
                        ColorTransitioner.ListBoxItemTransitioner.BorderBrush(this, theme.NormalBorderBrush);
                        ColorTransitioner.ListBoxItemTransitioner.Background(this, theme.NormalBackground);
                    }
                    break;
                case ControlState.Hovered:
                    {
                        ColorTransitioner.ListBoxItemTransitioner.Foreground(this, theme.HoverForeground);
                        ColorTransitioner.ListBoxItemTransitioner.BorderBrush(this, theme.HoverBorderBrush);
                        ColorTransitioner.ListBoxItemTransitioner.Background(this, theme.HoverBackground);
                    }
                    break;
                case ControlState.Pressed:
                    {
                        ColorTransitioner.ListBoxItemTransitioner.Foreground(this, theme.PressedForeground);
                        ColorTransitioner.ListBoxItemTransitioner.BorderBrush(this, theme.PressedBorderBrush);
                        ColorTransitioner.ListBoxItemTransitioner.Background(this, theme.PressedBackground);
                    }
                    break;
                case ControlState.Focused:
                    {
                        ColorTransitioner.ListBoxItemTransitioner.Foreground(this, theme.FocusedForeground);
                        ColorTransitioner.ListBoxItemTransitioner.BorderBrush(this, theme.FocusedBorderBrush);
                        ColorTransitioner.ListBoxItemTransitioner.Background(this, theme.FocusedBackground);
                    }
                    break;
                case ControlState.Disabled:
                    {
                        ColorTransitioner.ListBoxItemTransitioner.Foreground(this, theme.DisabledForeground);
                        ColorTransitioner.ListBoxItemTransitioner.BorderBrush(this, theme.DisabledBorderBrush);
                        ColorTransitioner.ListBoxItemTransitioner.Background(this, theme.DisabledBackground);
                    }
                    break;
            }
        }

        public ControlState GetState()
        {
            return CurrentState;
        }

        public void SetupEvents()
        {
            Selected += (sender, e) =>
            {
                foreach (var item in XListBoxReference.Items)
                {
                    XListBoxItem tmpItem = item as XListBoxItem;
                    tmpItem.IsSelectedItem = false;
                    tmpItem.CurrentState = ControlState.Normal;
                }
                XListBoxReference.CurrentSelectedItem = this;
                IsSelectedItem = true;
                CurrentState = ControlState.Focused;
            };
            MouseEnter += (sender, e) =>
            {
                switch (CurrentState)
                {
                    default:
                    case ControlState.Invalid:
                    case ControlState.Normal:
                    case ControlState.Hovered:
                        CurrentState = ControlState.Hovered;
                        break;
                    case ControlState.Pressed:
                        CurrentState = ControlState.Pressed;
                        break;
                    case ControlState.Focused:
                        CurrentState = ControlState.Focused;
                        break;
                    case ControlState.Disabled:
                        CurrentState = ControlState.Disabled;
                        break;
                }
                Update();
            };
            MouseLeave += (sender, e) =>
            {
                switch (CurrentState)
                {
                    default:
                    case ControlState.Invalid:
                    case ControlState.Normal:
                    case ControlState.Hovered:
                        CurrentState = ControlState.Normal;
                        break;
                    case ControlState.Pressed:
                        CurrentState = ControlState.Pressed;
                        break;
                    case ControlState.Focused:
                        CurrentState = ControlState.Focused;
                        break;
                    case ControlState.Disabled:
                        CurrentState = ControlState.Disabled;
                        break;
                }
                Update();
            };
            MouseDown += (sender, e) =>
            {
                switch (CurrentState)
                {
                    default:
                    case ControlState.Invalid:
                    case ControlState.Normal:
                    case ControlState.Hovered:
                    case ControlState.Pressed:
                    case ControlState.Focused:
                        CurrentState = ControlState.Pressed;
                        break;
                    case ControlState.Disabled:
                        CurrentState = ControlState.Disabled;
                        break;
                }
                Update();
            };
            PreviewMouseDown += (sender, e) =>
            {           
                switch (CurrentState)
                {
                    default:
                    case ControlState.Invalid:
                    case ControlState.Normal:
                    case ControlState.Hovered:
                    case ControlState.Pressed:
                    case ControlState.Focused:
                        CurrentState = ControlState.Pressed;
                        break;
                    case ControlState.Disabled:
                        CurrentState = ControlState.Disabled;
                        break;
                }
                Update();
            };
            MouseUp += (sender, e) =>
            {
                switch (CurrentState)
                {
                    default:
                    case ControlState.Invalid:
                    case ControlState.Normal: // Impossible Case
                    case ControlState.Hovered:
                        CurrentState = ControlState.Normal;
                        break;
                    case ControlState.Pressed:
                    case ControlState.Focused:
                        CurrentState = ControlState.Focused;
                        break;
                    case ControlState.Disabled:
                        CurrentState = ControlState.Disabled;
                        break;
                }
                Update();
            };
            PreviewMouseUp += (sender, e) =>
            {
                switch (CurrentState)
                {
                    default:
                    case ControlState.Invalid:
                    case ControlState.Normal: // Impossible Case
                    case ControlState.Hovered:
                        CurrentState = ControlState.Normal;
                        break;
                    case ControlState.Pressed:
                    case ControlState.Focused:
                        CurrentState = ControlState.Focused;
                        break;
                    case ControlState.Disabled:
                        CurrentState = ControlState.Disabled;
                        break;
                }
                Update();
            };
            GotFocus += (sender, e) =>
            {
                ControlRegistry.UnFocus(this);
                switch (CurrentState)
                {
                    default:
                    case ControlState.Invalid:
                    case ControlState.Normal:
                    case ControlState.Hovered:
                    case ControlState.Focused:
                        CurrentState = ControlState.Focused;
                        break;
                    case ControlState.Pressed:
                        CurrentState = ControlState.Pressed;
                        break;
                    case ControlState.Disabled:
                        CurrentState = ControlState.Disabled;
                        break;
                }
                Update();
            };
            LostFocus += (sender, e) =>
            {
                switch (CurrentState)
                {
                    default:
                    case ControlState.Invalid:
                    case ControlState.Normal:
                        CurrentState = ControlState.Normal;
                        break;
                    case ControlState.Hovered:
                        CurrentState = ControlState.Hovered;
                        break;
                    case ControlState.Pressed:
                        CurrentState = ControlState.Pressed;
                        break;
                    case ControlState.Focused:
                        CurrentState = ControlState.Normal;
                        break;
                    case ControlState.Disabled:
                        CurrentState = ControlState.Disabled;
                        break;
                }
                Update();
            };
        }
        #endregion
    }
}