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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            Chartity.ItemsSource = ws2016Entities5.GetContext().Charity.ToList();
        }


        private void buttonBack(object sender, RoutedEventArgs e)
        {
            this.Content = null;
        }

        private void editChartity(object sender, RoutedEventArgs e)
        {
            editChartity editPageChartity = new editChartity(Chartity.SelectedItem as Charity);
            this.NavigationService.Navigate(editPageChartity);
        }

        private void addChartity(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/RolePage/Admin/AddChartity.xaml", UriKind.Relative));
        }
    }
}
