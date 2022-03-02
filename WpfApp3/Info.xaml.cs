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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }
        private void buttonBack(object sender, RoutedEventArgs e)
        {
            this.Content = null;
        }
        private void ScrolPage(object sender, RoutedEventArgs e)
        {
            if (sender == infoWorldSkills)
            {
                frame.NavigationService.Navigate(new Uri("InfoWorldSkills.xaml", UriKind.Relative));
            }
            if (sender == oldResult)
                frame.NavigationService.Navigate(new Uri("OldResult.xaml", UriKind.Relative));
            if(sender == ListCompany)
                frame.NavigationService.Navigate(new Uri("company.xaml", UriKind.Relative));
            if (sender == longMaraphon)
                frame.NavigationService.Navigate(new Uri("Image/howLong/how-long.xaml", UriKind.Relative));
            if (sender == calculatorBMI)
                frame.NavigationService.Navigate(new Uri("BMICalculator.xaml", UriKind.Relative));
        }

        private void InfoWorldSkills_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
