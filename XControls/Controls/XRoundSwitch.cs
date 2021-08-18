// By Nirex @ github.com/nirex0

using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Input;
using XControls.Core;

namespace XControls.Controls
{
    public class XRoundSwitch : ProgressBar, IXControl
    {
        private uint valueToSet;
        private bool _isActive;
        private Lerp ProgressLerp;

        public bool IsActive
        {
            get { return _isActive; }
            set
            {
                _isActive = value;
                if (_isActive)
                {
                    ColorTransitioner.ProgressBarTransitioner.Foreground(this, Color.FromArgb(0x0, 0x0, 0x0, 0x0));
                    SetValue(0);
                }
                else
                {
                    ColorTransitioner.ProgressBarTransitioner.Foreground(this, ColorContainer.Foreground);
                    SetValue(100);
                }
            }
        }

        public XRoundSwitch()
        {
            ControlRegistry.Register(this);
            Style = (Style)FindResource("XROUNDSWITCH");

            MouseEnter += OnMouseEnterX;
            MouseLeave += OnMouseLeaveX;
            PreviewMouseDown += OnPreviewMouseDownX;

            Value = 0;
            Height = 20;
            Width = 46;

            Foreground = new SolidColorBrush(ColorContainer.Foreground);
            BorderBrush = new SolidColorBrush(ColorContainer.Foreground);
            Background = new SolidColorBrush(ColorContainer.Background);
        }

        private void OnMouseEnterX(object sender, MouseEventArgs e)
        {
            ColorTransitioner.ProgressBarTransitioner.Foreground(this, ColorContainer.GlowForeground);
            ColorTransitioner.ProgressBarTransitioner.BorderBrush(this, ColorContainer.GlowForeground);
            ColorTransitioner.ProgressBarTransitioner.Background(this, ColorContainer.Background);
        }
        private void OnMouseLeaveX(object sender, MouseEventArgs e)
        {
            ColorTransitioner.ProgressBarTransitioner.Foreground(this, ColorContainer.Foreground);
            ColorTransitioner.ProgressBarTransitioner.BorderBrush(this, ColorContainer.Foreground);
            ColorTransitioner.ProgressBarTransitioner.Background(this, ColorContainer.Background);
        }
        private void OnPreviewMouseDownX(object sender, MouseButtonEventArgs e)
        {
            if (_isActive)
            {
                ColorTransitioner.ProgressBarTransitioner.Foreground(this, Color.FromArgb(0x0, 0x0, 0x0, 0x0));
                SetValue(0);
            }
            else
            {
                ColorTransitioner.ProgressBarTransitioner.Foreground(this, ColorContainer.Foreground);
                SetValue(100);
            }

            _isActive = !_isActive;
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

        private void ProgressLerp_LerpTick(object sender, float value) => Value = value;        
        private void ProgressLerp_LerpDone(object sender, float value) => Value = valueToSet;

        public void Update()
        {
            ColorTransitioner.ProgressBarTransitioner.Foreground(this, ColorContainer.Foreground);
            ColorTransitioner.ProgressBarTransitioner.BorderBrush(this, ColorContainer.Foreground);
            ColorTransitioner.ProgressBarTransitioner.Background(this, ColorContainer.Background);
        }
    }
}
