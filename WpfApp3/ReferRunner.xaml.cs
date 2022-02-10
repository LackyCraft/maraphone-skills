using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {

        public Page2()
        {
            InitializeComponent();

            //Заменить потом на имя через users

            Runner.ItemsSource = ws2016Entities10.GetContext().User.ToList().ToList();
        }

        private void payBoxTextChanged(object sender, TextChangedEventArgs e)
        {
            int intRes;
            bool isInt = Int32.TryParse(payBox.Text, out intRes);
            if (isInt && intRes >= 0)
            payTextBlock.Text = "$" + payBox.Text;
            else
            {
                MessageBox.Show("Введите целое, положительное число");
                payTextBlock.Text = "$0";
                payBox.Text = "0";
            }
        }

        private void buttonBack(object sender, RoutedEventArgs e)
        {
            this.Content = null;
        }
    }
}