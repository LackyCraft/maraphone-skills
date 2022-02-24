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
    /// Логика взаимодействия для OldResult.xaml
    /// </summary>
    public partial class OldResult : Page
    {
        List<AllResult> runnerResult = ws2016Entities5.GetContext().AllResult.ToList();
        public OldResult()
        {
            InitializeComponent();
            marathon.ItemsSource = ws2016Entities5.GetContext().Marathon.ToList();
            eventType.ItemsSource = ws2016Entities5.GetContext().EventType.ToList();
            gender.ItemsSource = ws2016Entities5.GetContext().Gender.ToList();
            dataGridOldResults.ItemsSource = runnerResult;
            wayRunner.ItemsSource = new List<string>() { "до 18", "18 - 29", "30 - 39", "40 - 55", "56-70",
                                                     "более 70"};
            //dataGridOldResults.ItemsSource = ws2016Entities3.GetContext().Registration.ToList();
            //id - comboBoxCharty.SelectedValue.ToString();
        }

        private void MyGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = e.Row.GetIndex() + 1;
        }

        private void buttonBack(object sender, RoutedEventArgs e)
        {
            this.Content = null;
        }

        private void ButtonFilterClick(object sender, RoutedEventArgs e)
        {
            DateTime NowDate = DateTime.Now;
            List<AllResult> filterListRunnerResult = runnerResult;
            if (!(marathon.SelectedValue is null))
                filterListRunnerResult = filterListRunnerResult.Where(i => i.MarathonId == byte.Parse(marathon.SelectedValue.ToString())).ToList();
            if (!(gender.SelectedValue is null))
                filterListRunnerResult = filterListRunnerResult.Where(i => i.Gender == gender.SelectedValue.ToString()).ToList();
            if (!(eventType.SelectedValue is null))
                filterListRunnerResult = filterListRunnerResult.Where(i => i.EventTypeId == eventType.SelectedValue.ToString()).ToList();
            if (!(wayRunner.SelectedValue.ToString() == "до 18"))
                filterListRunnerResult = filterListRunnerResult.Where(i => i.DateOfBirth <= DateTime.Now.AddYears(-18)).ToList();
            if (!(wayRunner.SelectedValue.ToString() == "18 - 29"))
                filterListRunnerResult = filterListRunnerResult.Where(i => i.DateOfBirth <= DateTime.Now.AddYears(-18) && i.DateOfBirth >= DateTime.Now.AddYears(-29)).ToList();
            if (!(wayRunner.SelectedValue.ToString() == "30 - 39"))
                filterListRunnerResult = filterListRunnerResult.Where(i => i.DateOfBirth <= DateTime.Now.AddYears(-30) && i.DateOfBirth >= DateTime.Now.AddYears(-39)).ToList();
            if (!(wayRunner.SelectedValue.ToString() == "40 - 55"))
                filterListRunnerResult = filterListRunnerResult.Where(i => i.DateOfBirth <= DateTime.Now.AddYears(-40) && i.DateOfBirth >= DateTime.Now.AddYears(-55)).ToList();
            if (!(wayRunner.SelectedValue.ToString() == "56-70"))
                filterListRunnerResult = filterListRunnerResult.Where(i => i.DateOfBirth <= DateTime.Now.AddYears(-56) && i.DateOfBirth >= DateTime.Now.AddYears(-70)).ToList();
            if (!(wayRunner.SelectedValue.ToString() == "более 70"))
                filterListRunnerResult = filterListRunnerResult.Where(i => i.DateOfBirth <= DateTime.Now.AddYears(-70)).ToList();




            dataGridOldResults.ItemsSource = filterListRunnerResult.OrderBy(i => i.RaceTime);
        }
    }
}

