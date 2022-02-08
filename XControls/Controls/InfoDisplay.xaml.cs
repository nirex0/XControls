using System.ComponentModel;
using System.Windows.Controls;

namespace XControls.Controls
{
    /// <summary>
    /// Interaction logic for InfoDisplay.xaml
    /// </summary>
    public partial class InfoDisplay : UserControl, INotifyPropertyChanged
    {
        private string _title;
        private string _info;

        public string Title
        {
            get { return _title; }
            set { _title = value; OnPropertyChanged("Title"); }
        }

        public string Info
        {
            get { return _info; }
            set { _info = value; OnPropertyChanged("Info"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new(propName));
        }

        public InfoDisplay()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
