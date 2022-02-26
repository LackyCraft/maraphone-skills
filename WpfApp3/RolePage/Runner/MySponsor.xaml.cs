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

namespace WpfApp3.RolePage.Runner
{
    /// <summary>
    /// Логика взаимодействия для MySponsor.xaml
    /// </summary>
    public partial class MySponsor : Page
    {
        public MySponsor()
        {
            InitializeComponent();
            int idRunner = int.Parse(Application.Current.Resources["idRunner"].ToString());
            Registration reg = new Registration();
            reg = ws2016Entities5.GetContext().Registration.Where(i => i.RunnerId == idRunner).ToList()[0];



            listBoxSponsor.ItemsSource = ws2016Entities5.GetContext().Sponsorship.Where(i => i.RegistrationId == reg.RegistrationId).ToList();
            textBlockChartityDescription = reg.Charity[0].
        }

        private void buttonBack(object sender, RoutedEventArgs e)
        {
            this.Content = null;
        }

    }
}
