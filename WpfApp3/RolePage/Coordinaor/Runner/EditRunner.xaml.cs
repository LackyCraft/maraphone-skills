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

            

        }
    }
}
