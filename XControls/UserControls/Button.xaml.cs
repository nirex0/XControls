using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using XControls.Core;
using XControls.Core.Models;

namespace XControls.UserControls
{
    public class ButtonViewModel 
    {

    }

    public class ButtonModel : ControlModel
    {


        private string _TextContent;
        public string TextContent 
        { 
            get => _TextContent; set
            {
                _TextContent = value;
                OnPropertyChanged(nameof(TextContent));
            }        
        }

        private FontWeight _TextFontWeight;
        public FontWeight TextFontWeight
        {
            get => _TextFontWeight; set
            {
                _TextFontWeight = value;
                OnPropertyChanged(nameof(TextFontWeight));
            }
        }

        private FontFamily _TextFontFamily;
        public FontFamily TextFontFamily
        {
            get => _TextFontFamily; set
            {
                _TextFontFamily = value;
                OnPropertyChanged(nameof(TextFontFamily));
            }
        }

        private FontStyle _TextFontStyle;
        public FontStyle TextFontStyle
        {
            get => _TextFontStyle; set
            {
                _TextFontStyle = value;
                OnPropertyChanged(nameof(TextFontStyle));
            }
        }


        private double _TextFontSize;
        public double TextFontSize
        {
            get => _TextFontSize; set
            {
                _TextFontSize = value;
                OnPropertyChanged(nameof(TextFontSize));
            }
        }



        private double _TextOpacity;
        public double TextOpacity
        {
            get => _TextOpacity; set
            {
                _TextOpacity = value;
                OnPropertyChanged(nameof(TextOpacity));
            }
        }

        private Brush _TextColorBrush;
        public Brush TextColorBrush
        {
            get => _TextColorBrush; set
            {
                _TextColorBrush = value;
                OnPropertyChanged(nameof(TextColorBrush));
            }
        }


        private TextWrapping _TextContentWrapping;
        public TextWrapping TextContentWrapping
        {
            get => _TextContentWrapping; set
            {
                _TextContentWrapping = value;
                OnPropertyChanged(nameof(TextContentWrapping));
            }
        }

        public ButtonModel(bool UseDefaults = true)
        {
            if (UseDefaults)
            {
                IsEnabled = true;
                Height = 40;
                Width = 120;

                BackgroundColorBrush = new SolidColorBrush(Color.FromArgb(255, 18, 21, 30));
                BackgroundOpacity = 1.0;
                
                BorderColorBrush = new SolidColorBrush(Color.FromArgb(255, 00, 255, 64));
                BorderThickness = new Thickness(2, 2, 2, 2);
                BorderOpacity = 1.0;

                TextColorBrush = new SolidColorBrush(Color.FromArgb(255, 00, 255, 64));
                TextFontWeight = FontWeights.Bold;
                TextFontFamily = new FontFamily("Tahoma");
                TextFontSize = 16;
                TextOpacity = 1.0;
                TextContent = "Button";
                TextContentWrapping = TextWrapping.Wrap;
            }
        }

    }

    public partial class Button : UserControl, IXControl
    {
        public ButtonViewModel ViewModel { get; set; }
        public ButtonModel Model { get; set; }
        public ControlRegistry Registry;

        public event MouseButtonEventHandler Click;

        public Button()
        {            
            InitializeComponent();
            ViewModel = new ButtonViewModel();
            Model = new ButtonModel();
            Registry = ControlRegistry.DefaultControlRegistry;
            Registry.Register(this);

            DataContext = Model;

            SetupEvents();
        }


        #region Private Behavioar

        private bool IsMouseOn;

        private bool IsBeingClicked;

        private void SetupEvents()
        {
            #region Click Behavior
            MouseDown += (sender, e) => { IsBeingClicked = true; };
            MouseUp += (sender, e) => { if (IsBeingClicked && IsMouseOn) Click?.Invoke(this, e); };
            MouseEnter += (sender, e) => { IsMouseOn = true; };
            MouseLeave += (sender, e) => { IsMouseOn = false; };
            #endregion
        }

        public void Update()
        {

        }


        #endregion

    }
}
