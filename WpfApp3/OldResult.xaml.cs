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
            //dataGridOldResults.ItemsSource = ws2016Entities3.GetContext().Registration.ToList();
            //id - comboBoxCharty.SelectedValue.ToString();
        }
        private void buttonBack(object sender, RoutedEventArgs e)
        {
            this.Content = null;
        }

        private void ButtonFilterClick(object sender, RoutedEventArgs e)
        {
            List<AllResult> filterListRunnerResult = runnerResult;
            if (!(marathon.SelectedValue is null))
                filterListRunnerResult = filterListRunnerResult.Where(i => i.MarathonId == byte.Parse(marathon.SelectedValue.ToString())).ToList();
            if (!(gender.SelectedValue is null))
                filterListRunnerResult = filterListRunnerResult.Where(i => i.Gender == gender.SelectedValue.ToString()).ToList();
            if (!(eventType.SelectedValue is null))
                filterListRunnerResult = filterListRunnerResult.Where(i => i.EventTypeId == eventType.SelectedValue.ToString()).ToList();
            dataGridOldResults.ItemsSource = filterListRunnerResult;
        }
    }
}

