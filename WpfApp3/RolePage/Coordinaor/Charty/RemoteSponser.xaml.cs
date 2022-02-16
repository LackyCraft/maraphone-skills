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

namespace WpfApp3.RolePage.Coordinaor.Charty
{
    /// <summary>
    /// Логика взаимодействия для RemoteSponser.xaml
    /// </summary>
    public partial class RemoteSponser : Page
    {
        public RemoteSponser()
        {
            InitializeComponent();
        }
        private void buttonBack(object sender, RoutedEventArgs e)
        {
            this.Content = null;
        }
    }
}
