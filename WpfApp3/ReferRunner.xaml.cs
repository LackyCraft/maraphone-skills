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

            Runner.ItemsSource = ws2016Entities5.GetContext().Runner.ToList();
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

        private void buttonPlus(object sender, RoutedEventArgs e)
        {
            int intRes;
            Int32.TryParse(payBox.Text, out intRes);
            intRes += 10;
            payBox.Text = intRes.ToString();
        }
        private void buttonMinus(object sender, RoutedEventArgs e)
        {
            int intRes;
            Int32.TryParse(payBox.Text, out intRes);
            intRes -= 10;
            payBox.Text = intRes.ToString();
        }

        private void buttonAdd(object sender, RoutedEventArgs e)
        {

            ErrorMessage.Text = "";
            textName.Background = Brushes.White;
            textCard.Background = Brushes.White;
            textCardNumber.Background = Brushes.White;
            Runner.Background = Brushes.White;
            textPeriod.Background = Brushes.White;
            textCodeCVC.Background = Brushes.White;

            if (Runner.Text == "")
            {
                ErrorMessage.Text += "Выберите бегуна\n";
            }
            if (textName.Text == "")
            {
                textName.Background = Brushes.Red;
                ErrorMessage.Text += "Введите ваше имя\n";
            }
            if (textCard.Text == "")
            {
                textCard.Background = Brushes.Red;
                ErrorMessage.Text += "Введите имя держателя карты\n";
            }
            long intRes;
            long.TryParse(textCardNumber.Text, out intRes);
            if (intRes >= 10000000000000000 || intRes <= 999999999999999)
            {
                textCardNumber.Background = Brushes.Red;
                ErrorMessage.Text += "Номер карты должен состоять из 16 цифр\n";
            }

            DateTime dt;
            string myDate = textPeriod.Text;
            bool success = DateTime.TryParse(myDate, out dt);

            if (!success)
            {
                textPeriod.Background = Brushes.Red;
                ErrorMessage.Text += "Введите срок действия в виде 2016-12-10\n";
            }
            long.TryParse(textCodeCVC.Text, out intRes);
            if (intRes <= 99 || intRes >= 999)
            {
                textCodeCVC.Background = Brushes.Red;
                ErrorMessage.Text += "CVC код должен состоять из трех цифр\n";
            }

            if (payTextBlock.Text == "$0")
            {
                payTextBlock.Background = Brushes.Red;
                ErrorMessage.Text += "Нельзя пожертвовать 0 доларов\n";
            }
            if (ErrorMessage.Text == "")
            {
                Application.Current.Resources["Price"] = payTextBlock.Text; 
                Application.Current.Resources["PriceRunner"] = Runner.SelectedItem;
                this.NavigationService.Navigate(new Uri("Benevolence.xaml?parameter=", UriKind.Relative),textRunner.Text);
                //this.NavigationService.Navigate(new Benevolence(ws2016Entities4.GetContext().Runner.ToList()));
            }
            
        }

        private void buttonCancel(object sender, RoutedEventArgs e)
        {
            payBox.Text = "0";
            ErrorMessage.Text = "";
            textName.Text = "";
            textCard.Text = "";
            textCardNumber.Text = "";
            Runner.Text = "";
            textPeriod.Text = "";
            textCodeCVC.Text = "";
            textName.Background = Brushes.White;
            textCard.Background = Brushes.White;
            textCardNumber.Background = Brushes.White;
            Runner.Background = Brushes.White;
            textPeriod.Background = Brushes.White;
            textCodeCVC.Background = Brushes.White;
        }

    }
}