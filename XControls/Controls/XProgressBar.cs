// By Nirex @ github.com/nirex0

using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using XControls.Core;

namespace XControls.Controls
{
    public class XProgressBar : ProgressBar, IXControl
    {
        private uint valueToSet;
        private Lerp ProgressLerp;

        public XProgressBar()
        {
            ControlRegistry.Register(this);
            Foreground = new SolidColorBrush(theme.NormalForeground);
            BorderBrush = new SolidColorBrush(theme.NormalBorderBrush);
            Background = new SolidColorBrush(theme.NormalBackground);
            SetupEvents();
            Update();

            Style = (System.Windows.Style)FindResource("XPROGRESSBAR");


            Height = 60;
            Width = 120;
            Value = 0;
        }


        public void SetValue(uint newValue, float speed = 0.025f)
        {
            if (speed < 0.01f) { speed = 0.01f; }
            if (speed > 0.05f) { speed = 0.05f; }
            if (newValue >= 100) { newValue = 100; }
            if (newValue <= 000) { newValue = 000; }
            if (ProgressLerp != null) { ProgressLerp.Pause(); Value = valueToSet; }

            valueToSet = newValue;
            ProgressLerp = new Lerp((int)Value, newValue, speed, 0.1f, 1);
            ProgressLerp.OnTick += ProgressLerp_LerpTick;
            ProgressLerp.OnDone += ProgressLerp_LerpDone;
            ProgressLerp.Start();

        }

        private void ProgressLerp_LerpTick(object sender, float value) =>  Value = value;
        private void ProgressLerp_LerpDone(object sender, float value) => Value = valueToSet;


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
                        ColorTransitioner.ProgressBarTransitioner.Foreground(this, theme.NormalForeground);
                        ColorTransitioner.ProgressBarTransitioner.BorderBrush(this, theme.NormalBorderBrush);
                        ColorTransitioner.ProgressBarTransitioner.Background(this, theme.NormalBackground);
                    }
                    break;
                case ControlState.Hovered:
                    {
                        ColorTransitioner.ProgressBarTransitioner.Foreground(this, theme.HoverForeground);
                        ColorTransitioner.ProgressBarTransitioner.BorderBrush(this, theme.HoverBorderBrush);
                        ColorTransitioner.ProgressBarTransitioner.Background(this, theme.HoverBackground);
                    }
                    break;
                case ControlState.Pressed:
                    {
                        ColorTransitioner.ProgressBarTransitioner.Foreground(this, theme.PressedForeground);
                        ColorTransitioner.ProgressBarTransitioner.BorderBrush(this, theme.PressedBorderBrush);
                        ColorTransitioner.ProgressBarTransitioner.Background(this, theme.PressedBackground);
                    }
                    break;
                case ControlState.Focused:
                    {
                        ColorTransitioner.ProgressBarTransitioner.Foreground(this, theme.FocusedForeground);
                        ColorTransitioner.ProgressBarTransitioner.BorderBrush(this, theme.FocusedBorderBrush);
                        ColorTransitioner.ProgressBarTransitioner.Background(this, theme.FocusedBackground);
                    }
                    break;
                case ControlState.Disabled:
                    {
                        ColorTransitioner.ProgressBarTransitioner.Foreground(this, theme.DisabledForeground);
                        ColorTransitioner.ProgressBarTransitioner.BorderBrush(this, theme.DisabledBorderBrush);
                        ColorTransitioner.ProgressBarTransitioner.Background(this, theme.DisabledBackground);
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
