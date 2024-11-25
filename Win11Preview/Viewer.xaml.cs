using DataModel;
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
using System.Windows.Shapes;

namespace Win11Preview
{
    /// <summary>
    /// Viewer.xaml の相互作用ロジック
    /// </summary>
    public partial class Viewer : Window
    {
        public Viewer(FixedDocument mydata)
        {
            InitializeComponent();
            var vm = new ViewViewModel(mydata);
            this.DataContext = vm;
        }
    }
}
