using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace XControls.Controls
{
    /// <summary>
    /// Interaction logic for ImagedButton.xaml
    /// </summary>
    public partial class ImagedButton : UserControl
    {
        public XButton Button { get; private set; }

        // public string ImageSourceURI
        // { 
        //     get
        //     {
        //         return rectangle_image.ImageSource.ToString();
        //     }
        //     set 
        //     {
        //         BitmapImage bitmapImage = new BitmapImage();
        //         Uri uri = new Uri("/XControls;component/Icons/3D Rotate.png");
        //         bitmapImage.UriSource = uri;
        //         rectangle_image.ImageSource = bitmapImage;
        //     }
        // }

        public class UserControlDefaultButtonCommandClass : ICommand
        {
            private ImagedButton Button;

            public UserControlDefaultButtonCommandClass(ImagedButton btn)
            {
                Button = btn;
            }

            public event EventHandler CanExecuteChanged;

            public bool CanExecute(object parameter)
            {
                return Button.IsEnabled;
            }

            public void Execute(object parameter)
            {
                Button.OnClick(parameter as RoutedEventArgs);
            }
        }

        public event EventHandler Click;

        public ICommand UserControlDefaultButtonCommand { get; }

        public ImagedButton()
        {
            DataContext = this;
            UserControlDefaultButtonCommand = new UserControlDefaultButtonCommandClass(this);
            InitializeComponent();
            Button = button;
            Button.Update();
        }

        public void OnClick(RoutedEventArgs parameter = null)
        {
            if(parameter != null)
                Click?.Invoke(this, parameter);
            else
                Click?.Invoke(this, new RoutedEventArgs());
        }

        public void SetMainText(string text)
        {
            button.Content = "  " + text;
        }

        public void SetImageURI(string uri)
        {
            BitmapImage logo = new();
            logo.BeginInit();
            logo.UriSource = new Uri(uri);
            logo.EndInit();

            // rectangle_image.ImageSource = logo;
        }
    }
}
