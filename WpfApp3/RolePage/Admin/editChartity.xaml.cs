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
    /// Логика взаимодействия для editChartity.xaml
    /// </summary>
    public partial class editChartity : Page
    {

        Charity editChartityItem;

        public editChartity(Charity charity)
        {
            InitializeComponent();
            editChartityItem = charity;
            textBoxChartityName.Text = charity.CharityName.ToString();
            textBoxChartityDescription.Text = charity.CharityDescription.ToString();
            textBoxChartityLogo.Text = charity.CharityLogo.ToString();

            if (textBoxChartityLogo.Text.Length > 0)
            {
                fotoRunner.Source = new BitmapImage(new Uri("/" + textBoxChartityLogo.Text, UriKind.Relative));
            }


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

        private void saveEditChartity(object sender, RoutedEventArgs e)
        {
            if (textBoxChartityName.Text.Length > 0 || textBoxChartityDescription.Text.Length > 0 || textBoxChartityLogo.Text.Length > 0)
            {
                        editChartityItem.CharityName = textBoxChartityName.Text;
                        editChartityItem.CharityDescription = textBoxChartityDescription.Text;
                        editChartityItem.CharityLogo = textBoxChartityLogo.Text;

                        ws2016Entities5.GetContext().SaveChanges();
                        MessageBox.Show("Изменения сохранены");

                        this.NavigationService.Navigate(new Uri("/RolePage/Admin/chartityControl.xaml", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("Заполните все параметры!");
            }
        }

        private void buttonCancel(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/RolePage/Admin/chartityControl.xaml", UriKind.Relative));
        }
    }
}
