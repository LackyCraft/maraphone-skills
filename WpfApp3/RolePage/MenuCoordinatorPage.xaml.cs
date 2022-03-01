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

namespace WpfApp3.RolePage
{
    /// <summary>
    /// Логика взаимодействия для CoordinatorPage.xaml
    /// </summary>
    public partial class CoordinatorPage : Page
    {
        public CoordinatorPage()
        {
            InitializeComponent();
            if (Application.Current.Resources["Role"].ToString() != "C" || Application.Current.Resources["Role"].ToString() is null)
            {
                this.Content = null;
                MessageBox.Show("403 Forbidden \n Попытка перейти на страницу несоответствующей вашей роли");
            }
        }
        private void buttonBack(object sender, RoutedEventArgs e)
        {
            this.Content = null;
        }

        private void ScrolPage(object sender, RoutedEventArgs e)
        {
            if(sender == remoteRunner)
            {
                this.NavigationService.Navigate(new Uri("RolePage/Coordinaor/Runner/RemoteRunner.xaml", UriKind.Relative));
            }
        }
    }
}
