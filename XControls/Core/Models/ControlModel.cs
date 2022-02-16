using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace XControls.Core.Models
{
    public class ControlModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private bool _IsEnabled;
        public bool IsEnabled
        {
            get => _IsEnabled; set
            {
                _IsEnabled = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsEnabled)));
            }
        }


        private double _Height;
        public double Height
        {
            get => _Height; set
            {
                _Height = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Height)));
            }
        }

        private double _Width;
        public double Width
        {
            get => _Width; set
            {
                _Width = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Width)));
            }
        }

        private Visibility _ControlVisibility;
        public Visibility ControlVisibility
        {
            get => _ControlVisibility; set
            {
                _ControlVisibility = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ControlVisibility)));
            }
        }

        private double _BackgroundOpacity;
        public double BackgroundOpacity
        {
            get => _BackgroundOpacity; set
            {
                _BackgroundOpacity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(BackgroundOpacity)));
            }
        }

        private Brush _BackgroundColorBrush;
        public Brush BackgroundColorBrush
        {
            get => _BackgroundColorBrush; set
            {
                _BackgroundColorBrush = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(BackgroundColorBrush)));
            }
        }

        private Thickness _BorderThickness;
        public Thickness BorderThickness
        {
            get => _BorderThickness; set
            {
                _BorderThickness = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(BorderThickness)));
            }
        }

        private double _BorderOpacity;
        public double BorderOpacity
        {
            get => _BorderOpacity; set
            {
                _BorderOpacity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(BorderOpacity)));
            }
        }

        private Brush _BorderColorBrush;
        public Brush BorderColorBrush
        {
            get => _BorderColorBrush; set
            {
                _BorderColorBrush = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(BorderColorBrush)));
            }
        }

        private ToolTip _ControlToolTip;
        public ToolTip ControlToolTip
        {
            get => _ControlToolTip; set
            {
                _ControlToolTip = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ControlToolTip)));
            }
        }
    }
}
