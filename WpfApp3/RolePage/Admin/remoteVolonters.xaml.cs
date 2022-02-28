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
    /// Логика взаимодействия для remoteVolonters.xaml
    /// </summary>
    public partial class remoteVolonters : Page
    {

        List<Volunteer> filterList = ws2016Entities5.GetContext().Volunteer.ToList();

        public remoteVolonters()
        {
            InitializeComponent();
            comboBoxSelectFilter.ItemsSource = new List<string>() { "фамилия", "имя", "страна","пол"};
            dataGridRemoteVolontors.ItemsSource = filterList;
        }
        private void buttonBack(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/RolePage/MenuAdministratorPage.xaml", UriKind.Relative));
        }

        private void buttonUpdate(object sender, RoutedEventArgs e)
        {
            if (comboBoxSelectFilter.SelectedItem.ToString() == "фамилия")
                filterList = filterList.OrderBy(i => i.FirstName).ToList();
            if (comboBoxSelectFilter.SelectedItem.ToString() == "имя")
                filterList = filterList.OrderBy(i => i.LastName).ToList();
            if (comboBoxSelectFilter.SelectedItem.ToString() == "Страна")
                filterList = filterList.OrderBy(i => i.CountryCode).ToList();
            if (comboBoxSelectFilter.SelectedItem.ToString() == "пол")
                filterList = filterList.OrderBy(i => i.Gender).ToList();
            dataGridRemoteVolontors.ItemsSource = filterList;
        }
    }
}
