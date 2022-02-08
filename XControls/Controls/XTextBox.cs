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

        public XTextBox()
        {
            ControlRegistry.Register(this);
            Foreground = new SolidColorBrush(theme.NormalForeground);
            BorderBrush = new SolidColorBrush(theme.NormalBorderBrush);
            Background = new SolidColorBrush(theme.NormalBackground);
            SetupEvents();
            Update();

            Style = (System.Windows.Style)FindResource("XTEXTBOX");

            VerticalContentAlignment = VerticalAlignment.Center;
            BorderThickness = new Thickness(0, 0, 0, 0);
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
                        ColorTransitioner.TextBoxTransitioner.Foreground(this, theme.NormalForeground);
                        ColorTransitioner.TextBoxTransitioner.BorderBrush(this, theme.NormalBorderBrush);
                        ColorTransitioner.TextBoxTransitioner.Background(this, theme.NormalBackground);
                    }
                    break;
                case ControlState.Hovered:
                    {
                        ColorTransitioner.TextBoxTransitioner.Foreground(this, theme.HoverForeground);
                        ColorTransitioner.TextBoxTransitioner.BorderBrush(this, theme.HoverBorderBrush);
                        ColorTransitioner.TextBoxTransitioner.Background(this, theme.HoverBackground);
                    }
                    break;
                case ControlState.Pressed:
                    {
                        ColorTransitioner.TextBoxTransitioner.Foreground(this, theme.PressedForeground);
                        ColorTransitioner.TextBoxTransitioner.BorderBrush(this, theme.PressedBorderBrush);
                        ColorTransitioner.TextBoxTransitioner.Background(this, theme.PressedBackground);
                    }
                    break;
                case ControlState.Focused:
                    {
                        ColorTransitioner.TextBoxTransitioner.Foreground(this, theme.FocusedForeground);
                        ColorTransitioner.TextBoxTransitioner.BorderBrush(this, theme.FocusedBorderBrush);
                        ColorTransitioner.TextBoxTransitioner.Background(this, theme.FocusedBackground);
                    }
                    break;
                case ControlState.Disabled:
                    {
                        ColorTransitioner.TextBoxTransitioner.Foreground(this, theme.DisabledForeground);
                        ColorTransitioner.TextBoxTransitioner.BorderBrush(this, theme.DisabledBorderBrush);
                        ColorTransitioner.TextBoxTransitioner.Background(this, theme.DisabledBackground);
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
                return;
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
                BorderThickness = new Thickness(0, 0, 0, 2);
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
                BorderThickness = new Thickness(0, 0, 0, 0);
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
