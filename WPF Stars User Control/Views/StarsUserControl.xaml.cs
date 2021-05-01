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
using WPF_Stars_User_Control.ViewModels;

namespace WPF_Stars_User_Control.Views
{
    /// <summary>
    /// Interaction logic for StarsUserControl.xaml
    /// </summary>
    public partial class StarsUserControl : UserControl
    {
        public StarsUserControl()
        {
            InitializeComponent();
            this.DataContext = new StarsViewModel();
        }
    }
}
