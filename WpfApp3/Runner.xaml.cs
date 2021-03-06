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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }
        private void buttonBack(object sender, RoutedEventArgs e)
        {
            this.Content = null;
        }

        private void ScrolPage(object sender, RoutedEventArgs e)
        {

            //NavigationService nav;
            //nav = NavigationService.GetNavigationService(this);
            if (sender == canRun)
                this.NavigationService.Navigate(new Uri("auth.xaml", UriKind.Relative));
            if(sender == NewRunner)
                this.NavigationService.Navigate(new Uri("RegistrationRunner.xaml", UriKind.Relative));
        }
    }
}
