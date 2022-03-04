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

namespace WpfApp3.RolePage.Admin
{
    /// <summary>
    /// Логика взаимодействия для RemoteRunner.xaml
    /// </summary>
    public partial class RemoteRunner : Page
    {
        public RemoteRunner()
        {
            InitializeComponent();
            dataGridResults.ItemsSource = ws2016Entities5.GetContext().User.ToList();
        }

        private void editRunner(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonBack(object sender, RoutedEventArgs e)
        {
            this.Content = null;
        }
    }
}
