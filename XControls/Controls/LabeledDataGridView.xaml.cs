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
using System.ComponentModel;

namespace XControls.Controls
{
    /// <summary>
    /// Interaction logic for LabeledDataGridView.xaml
    /// </summary>
    public partial class LabeledDataGridView : UserControl
    {
        public XLabel Label { get; private set; }
        public DataGrid Data { get; private set; }

        public LabeledDataGridView()
        {
            InitializeComponent();
            Label = label;
            Data = datagrid;

        }
    }
}
