// By Nirex @ github.com/nirex0

using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
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
            Style = (Style)FindResource("XPROGRESSBAR");

            MouseEnter += OnMouseEnterX;
            MouseLeave += OnMouseLeaveX;

            Height = 60;
            Width = 120;
            Value = 0;
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

        public void Update()
        {
            ColorTransitioner.ProgressBarTransitioner.Foreground(this, ColorContainer.Foreground);
            ColorTransitioner.ProgressBarTransitioner.BorderBrush(this, ColorContainer.Foreground);
            ColorTransitioner.ProgressBarTransitioner.Background(this, ColorContainer.Background);
        }
    }
}
