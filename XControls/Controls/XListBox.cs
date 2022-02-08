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
        public XListBox()
        {
            ControlRegistry.Register(this);
            Foreground = new SolidColorBrush(theme.NormalForeground);
            BorderBrush = new SolidColorBrush(theme.NormalBorderBrush);
            Background = new SolidColorBrush(theme.NormalBackground);
            SetupEvents();
            Update();

            Style = (System.Windows.Style)FindResource("XLISTBOX");


            BorderThickness = new Thickness(0, 0, 0, 0);
            FontSize = 14;
            FontWeight = FontWeights.Bold;
            FontFamily = new FontFamily("Global User Interface");
        }

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
        public XListBoxItem CurrentSelectedItem { get; set; }
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
                        ColorTransitioner.ListBoxTransitioner.Foreground(this, theme.NormalForeground);
                        ColorTransitioner.ListBoxTransitioner.BorderBrush(this, theme.NormalBorderBrush);
                        ColorTransitioner.ListBoxTransitioner.Background(this, theme.NormalBackground);
                    }
                    break;
                case ControlState.Hovered:
                    {
                        ColorTransitioner.ListBoxTransitioner.Foreground(this, theme.HoverForeground);
                        ColorTransitioner.ListBoxTransitioner.BorderBrush(this, theme.HoverBorderBrush);
                        ColorTransitioner.ListBoxTransitioner.Background(this, theme.HoverBackground);
                    }
                    break;
                case ControlState.Pressed:
                    {
                        ColorTransitioner.ListBoxTransitioner.Foreground(this, theme.PressedForeground);
                        ColorTransitioner.ListBoxTransitioner.BorderBrush(this, theme.PressedBorderBrush);
                        ColorTransitioner.ListBoxTransitioner.Background(this, theme.PressedBackground);
                    }
                    break;
                case ControlState.Focused:
                    {
                        ColorTransitioner.ListBoxTransitioner.Foreground(this, theme.FocusedForeground);
                        ColorTransitioner.ListBoxTransitioner.BorderBrush(this, theme.FocusedBorderBrush);
                        ColorTransitioner.ListBoxTransitioner.Background(this, theme.FocusedBackground);
                    }
                    break;
                case ControlState.Disabled:
                    {
                        ColorTransitioner.ListBoxTransitioner.Foreground(this, theme.DisabledForeground);
                        ColorTransitioner.ListBoxTransitioner.BorderBrush(this, theme.DisabledBorderBrush);
                        ColorTransitioner.ListBoxTransitioner.Background(this, theme.DisabledBackground);
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
