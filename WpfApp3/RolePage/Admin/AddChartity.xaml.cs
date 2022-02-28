using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;

using System.Text.RegularExpressions;
using System.Windows.Media.Imaging;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3.RolePage.Admin
{
    /// <summary>
    /// Логика взаимодействия для AddChartity.xaml
    /// </summary>
    public partial class AddChartity : Page
    {
        public AddChartity()
        {
            InitializeComponent();
        }

        private void buttonBack(object sender, RoutedEventArgs e)
        {
            this.Content = null;
        }

        private void selectedFoto(object sender, RoutedEventArgs e)
        {

            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";

            if (op.ShowDialog() == true)
            {
                fotoRunner.Source = new BitmapImage(new Uri(op.FileName));
                textBoxChartityLogo.Text = op.FileName;
            }
        }

        private void buttonCancel(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/RolePage/Admin/chartityControl.xaml", UriKind.Relative));
        }

        private void saveEditChartity(object sender, RoutedEventArgs e)
        {
            if (textBoxChartityName.Text.Length > 2 && textBoxChartityDescription.Text.Length > 2 && textBoxChartityLogo.Text.Length > 2)
            {
                Charity addChartity = new Charity
                {
                    CharityName = textBoxChartityName.Text,
                    CharityDescription = textBoxChartityDescription.Text,
                    CharityLogo = textBoxChartityLogo.Text
                };

                ws2016Entities5.GetContext().Charity.Add(addChartity);
                ws2016Entities5.GetContext().SaveChanges();
                MessageBox.Show("Изменения сохранены");

                this.NavigationService.Navigate(new Uri("/RolePage/Admin/chartityControl.xaml", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("Заполните все параметры!");
            }
        }


    }
}
