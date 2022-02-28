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
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        public AdminPage()
        {
            InitializeComponent();
            try
            {
                if (Application.Current.Resources["Role"].ToString() != "A")
                {
                    this.Content = null;
                    MessageBox.Show("403 Forbidden \n Попытка перейти на страницу несоответствующей вашей роли");
                }
            }
            catch
            {
                MessageBox.Show("403 Forbidden \n Access denied");
                this.Content = null;
            }
        }
        private void buttonBack(object sender, RoutedEventArgs e)
        {
            this.Content = null;
        }

        private void ScrolPage(object sender, RoutedEventArgs e)
        {
            if(sender == chartity)
            {
                this.NavigationService.Navigate(new Uri("RolePage/Admin/chartityControl.xaml", UriKind.Relative));
            }
            if(sender == remoteVolonters)
            {
                this.NavigationService.Navigate(new Uri("RolePage/Admin/remoteVolonters.xaml", UriKind.Relative));
            }
        }
    }
}
