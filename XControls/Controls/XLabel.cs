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
        public bool UseTheme { get; set; } = false;
        public bool IsPlaceHolder { get; set; }
        public TextBox PlaceHolderText_TextBoxReference { get; set; }


        public void SetColor(Color c)
        {
           ColorTransitioner.LabelTransitioner.Foreground(this, c);            
        }

        public XLabel()
        {
            ControlRegistry.Register(this);
            Foreground = new SolidColorBrush(theme.NormalForeground);
            BorderBrush = new SolidColorBrush(theme.NormalBorderBrush);
            Background = null;
            SetupEvents();
            Update();

            BorderThickness = new Thickness(0);
            FontSize = 14;
            FontWeight = FontWeights.Bold;
            FontFamily = new FontFamily("Global User Interface");
        }
        
        public void SetPlaceHolderTextBox(TextBox tb)
        {
            PlaceHolderText_TextBoxReference = tb;
            IsPlaceHolder = true;
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
                        ColorTransitioner.LabelTransitioner.Foreground(this, theme.NormalForeground);
                        // ColorTransitioner.LabelTransitioner.BorderBrush(this, theme.NormalBorderBrush);
                        // ColorTransitioner.LabelTransitioner.Background(this, theme.NormalBackground);
                    }
                    break;
                case ControlState.Hovered:
                    {
                        ColorTransitioner.LabelTransitioner.Foreground(this, theme.HoverForeground);
                        // ColorTransitioner.LabelTransitioner.BorderBrush(this, theme.HoverBorderBrush);
                        // ColorTransitioner.LabelTransitioner.Background(this, theme.HoverBackground);
                    }
                    break;
                case ControlState.Pressed:
                    {
                        ColorTransitioner.LabelTransitioner.Foreground(this, theme.PressedForeground);
                        // ColorTransitioner.LabelTransitioner.BorderBrush(this, theme.PressedBorderBrush);
                        // ColorTransitioner.LabelTransitioner.Background(this, theme.PressedBackground);
                    }
                    break;
                case ControlState.Focused:
                    {
                        ColorTransitioner.LabelTransitioner.Foreground(this, theme.FocusedForeground);
                        // ColorTransitioner.LabelTransitioner.BorderBrush(this, theme.FocusedBorderBrush);
                        // ColorTransitioner.LabelTransitioner.Background(this, theme.FocusedBackground);
                    }
                    break;
                case ControlState.Disabled:
                    {
                        ColorTransitioner.LabelTransitioner.Foreground(this, theme.DisabledForeground);
                        // ColorTransitioner.LabelTransitioner.BorderBrush(this, theme.DisabledBorderBrush);
                        // ColorTransitioner.LabelTransitioner.Background(this, theme.DisabledBackground);
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
                if (IsPlaceHolder)
                {
                    Mouse.OverrideCursor = null;
                    Cursor = Cursors.IBeam;
                }
                switch (CurrentState)
                {
                    default:
                    case ControlState.Invalid:
                        CurrentState = ControlState.Pressed;
                        break;
                    case ControlState.Normal:
                        CurrentState = ControlState.Pressed;
                        break;
                    case ControlState.Hovered:
                        CurrentState = ControlState.Pressed;
                        break;
                    case ControlState.Pressed:
                        CurrentState = ControlState.Pressed;
                        break;
                    case ControlState.Focused:
                        CurrentState = ControlState.Pressed;
                        break;
                    case ControlState.Disabled:
                        CurrentState = ControlState.Disabled;
                        break;
                }
                Update();
            };
            MouseLeave += (sender, e) =>
            {
                if (IsPlaceHolder)
                {
                    Mouse.OverrideCursor = null;
                    Cursor = Cursors.Arrow;
                }
                switch (CurrentState)
                {
                    default:
                    case ControlState.Invalid:
                    case ControlState.Normal:
                    case ControlState.Hovered:
                    case ControlState.Pressed:
                    case ControlState.Focused:
                        CurrentState = ControlState.Normal;
                        break;
                    case ControlState.Disabled:
                        CurrentState = ControlState.Disabled;
                        break;
                }
                Update();
            };
            MouseDown += (sender, e) =>
            {
                if (PlaceHolderText_TextBoxReference != null)
                {
                    PlaceHolderText_TextBoxReference.Focusable = true;
                    PlaceHolderText_TextBoxReference.Focus();
                }
                Update();
            };
            PreviewMouseDown += (sender, e) =>
            {
                if (PlaceHolderText_TextBoxReference != null)
                {
                    PlaceHolderText_TextBoxReference.Focusable = true;
                    PlaceHolderText_TextBoxReference.Focus();
                }
                Update();
            };
            MouseUp += (sender, e) => { Update(); };
            PreviewMouseUp += (sender, e) => { Update(); };
            GotFocus += (sender, e) => { Update(); };
            LostFocus += (sender, e) => { Update(); };
        }
        #endregion
    }
}
