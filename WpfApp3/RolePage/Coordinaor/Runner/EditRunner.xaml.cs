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

namespace WpfApp3.RolePage.Coordinaor.Runner
{
    /// <summary>
    /// Логика взаимодействия для EditRunner.xaml
    /// </summary>
    public partial class EditRunner : Page
    {
        public EditRunner(Participants2022 runnerInfo)
        {

            InitializeComponent();

            textBlockEmail.Text = runnerInfo.Email;
            textBlockFirstName.Text = runnerInfo.FirstName;
            textLastName.Text = runnerInfo.LastName;
            textBlockGender.Text = runnerInfo.Gender;
            textBlockBerthDay.Text = runnerInfo.DateOfBirth.ToString();
            textBlockCountry.Text = runnerInfo.CountryName;
            textBlockChartity.Text = ws2016Entities5.GetContext().Charity.Where(i => i.CharityId == runnerInfo.CharityId).ToList()[0].CharityName;
            TextBlockCategory.Text = runnerInfo.RaceKitOptionId;

            if (runnerInfo.Patch != "null")
            {
                fotoRunner.Source = new BitmapImage(new Uri(runnerInfo.Patch));
                //textBoxFotoName.Text = runnerInfo.Patch;
            }
            if (runnerInfo.RegistrationStatusId == 1)
                statusReg.Source = new BitmapImage(new Uri("/Image/icon/tick-icon.png",UriKind.Relative));
            if (runnerInfo.RegistrationStatusId == 2)
            {
                statusReg.Source = new BitmapImage(new Uri("/Image/icon/tick-icon.png", UriKind.Relative));
                statusDinedPay.Source = new BitmapImage(new Uri("/Image/icon/tick-icon.png", UriKind.Relative));
            }

            if (runnerInfo.RegistrationStatusId == 3)
            {
                statusReg.Source = new BitmapImage(new Uri("/Image/icon/tick-icon.png", UriKind.Relative));
                statusDinedPay.Source = new BitmapImage(new Uri("/Image/icon/tick-icon.png", UriKind.Relative));
                statusGiveRaceKit.Source = new BitmapImage(new Uri("/Image/icon/tick-icon.png", UriKind.Relative));
            }
            if (runnerInfo.RegistrationStatusId == 4)
            {
                statusReg.Source = new BitmapImage(new Uri("/Image/icon/tick-icon.png", UriKind.Relative));
                statusDinedPay.Source = new BitmapImage(new Uri("/Image/icon/tick-icon.png", UriKind.Relative));
                statusGiveRaceKit.Source = new BitmapImage(new Uri("/Image/icon/tick-icon.png", UriKind.Relative));
                statusStart.Source = new BitmapImage(new Uri("/Image/icon/tick-icon.png", UriKind.Relative));
            }

        }

        private void buttonBack(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/RolePage/MenuCoordinatorPage.xaml",UriKind.Relative));
        }

        private void EditDataRunner(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/RolePage/Coordinaor/Runner/editDataRunner.xaml", UriKind.Relative));
            editDataRunner nextPage = new editDataRunner(textBlockEmail.Text);
            this.NavigationService.Navigate(nextPage);
        }

        private void SaySertificate(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ранее участник не участвовал в марафоне");
        }
    }
}
