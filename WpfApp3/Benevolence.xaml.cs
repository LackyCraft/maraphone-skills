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
    /// Логика взаимодействия для Benevolence.xaml
    /// </summary>
    public partial class Benevolence : Page
    {
        public Benevolence()
        {
            InitializeComponent();
            price.Text = Application.Current.Resources["Price"].ToString();

            //priceRunner.Text = Application.Current.Resources["PriceRunner"].ToString();
            //label11.Content = string.Format("") Application.Current.Resources["PriceRunner"];
        }

        private void buttonBack(object sender, RoutedEventArgs e)
        {
            this.Content = null; 
        }
    }
}
