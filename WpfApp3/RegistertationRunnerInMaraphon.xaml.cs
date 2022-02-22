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
    /// Логика взаимодействия для RegistertationRunnerInMaraphon.xaml
    /// </summary>
    public partial class RegistertationRunnerInMaraphon : Page
    {

        int price = 0;

        public RegistertationRunnerInMaraphon()
        {
            InitializeComponent();
            comboBoxCharty.ItemsSource = ws2016Entities5.GetContext().Charity.ToList();
        }

        private void buttonBack(object sender, RoutedEventArgs e)
        {
            this.Content = null;
        }

        private void ComboBoxCharty_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //id - comboBoxCharty.SelectedValue.ToString();
            
        }

        private void ChekBoxCheckedWayMarafon(object sender, RoutedEventArgs e)
        {
            price = 0;
            if (typeB.IsChecked == true)
                price += 20;
            if (typeC.IsChecked == true)
                price += 45;
            if (chekBox42km.IsChecked == true)
                price += 145;
            if (chekBox21km.IsChecked == true)
                price += 75;
            if (chekBox5km.IsChecked == true)
                price += 20;
            payTextBlock.Text = "$" + (price + int.Parse(priceInCharty.Text)).ToString();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {    
             payTextBlock.Text = "$" + (price + int.Parse(priceInCharty.Text)).ToString();
        }

        private void infoCharity(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("1");
            InfoCharity infoCharity = new InfoCharity(comboBoxCharty.SelectedItem as Charity);
            infoCharity.Show();
        }

        private void ScrolPage(object sender, RoutedEventArgs e)
        {
            string raceKitOptionId = "A";
            if (typeA.IsChecked == true)
                raceKitOptionId = "A";
            if (typeB.IsChecked == true)
                raceKitOptionId = "B";
            if (typeC.IsChecked == true)
                raceKitOptionId = "C";


                if (sender == nextRegister)
            {
                Registration NewReg = new Registration
                {
                    RunnerId = int.Parse(Application.Current.Resources["idRunner"].ToString()),
                    RegistrationDateTime = DateTime.Now,
                    RaceKitOptionId = raceKitOptionId,
                    RegistrationStatusId = 1,
                    Cost = price,
                    CharityId = int.Parse(comboBoxCharty.SelectedValue.ToString()),
                    SponsorshipTarget = int.Parse(priceInCharty.Text)
                };
                ws2016Entities5.GetContext().Registration.Add(NewReg);
                ws2016Entities5.GetContext().SaveChanges();
                this.NavigationService.Navigate(new Uri("thankRegister.xaml", UriKind.Relative));
            }

        }
    }
}
