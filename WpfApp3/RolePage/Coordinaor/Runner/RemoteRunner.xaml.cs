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
using System.IO;
using CsvHelper;
using WpfApp3.RolePage.Coordinaor.Runner;

namespace WpfApp3.RolePage.Coordinaor.runner
{
    /// <summary>
    /// Логика взаимодействия для RemoteRunner.xaml
    /// </summary>
    public partial class RemoteRunner : Page
    {
        List<Participants2022> participants2022s = ws2016Entities5.GetContext().Participants2022.ToList();
        List<Participants2022> participants2022sFilter = ws2016Entities5.GetContext().Participants2022.ToList();
        public RemoteRunner()
        {
            InitializeComponent();
            dataGridResults.ItemsSource = participants2022s;
            comboBoxEventType.ItemsSource = ws2016Entities5.GetContext().EventType.ToList();
            comboBoxStatus.ItemsSource = ws2016Entities5.GetContext().RegistrationStatus.ToList();
            comboBoxFilterSort.ItemsSource = new List<string> {"Имя","Фамилия","Email","Статус"};
            textBlockCount.Text = "Всего бегунов:" + participants2022s.Count;
        }

        private void buttonBack(object sender, RoutedEventArgs e)
        {
            this.Content = null;
        }

        private void buttonFilterClick(object sender, RoutedEventArgs e)
        {
            participants2022sFilter = participants2022s;
            if (comboBoxStatus.SelectedValue is null || comboBoxEventType.SelectedValuePath is null)
            {
                MessageBox.Show("Выберите статус и дистанцию"); 
            }
            else
            {
                participants2022sFilter = participants2022sFilter.Where(i => i.RegistrationStatusId == Byte.Parse(comboBoxStatus.SelectedValue.ToString())).ToList();
                participants2022sFilter = participants2022sFilter.Where(i => i.EventTypeId == comboBoxEventType.SelectedValue.ToString()).ToList();
                if (comboBoxFilterSort.SelectedValue.ToString() == "Имя")
                {
                    participants2022sFilter = participants2022sFilter.OrderBy(i => i.LastName).ToList();
                }
                if (comboBoxFilterSort.SelectedValue.ToString() == "Фамилия")
                {
                    participants2022sFilter = participants2022sFilter.OrderBy(i => i.FirstName).ToList();
                }
                if (comboBoxFilterSort.SelectedValue.ToString() == "Email")
                {
                    participants2022sFilter = participants2022sFilter.OrderBy(i => i.Email).ToList();
                }
                if (comboBoxFilterSort.SelectedValue.ToString() == "Статус")
                {
                    participants2022sFilter = participants2022sFilter.OrderBy(i => i.RegistrationStatus).ToList();
                }
            }
            dataGridResults.ItemsSource = participants2022sFilter;
            textBlockCount.Text = "Всего бегунов:" + participants2022sFilter.Count;
        }

        private void editRunner(object sender, RoutedEventArgs e)
        {
            EditRunner editRunners = new EditRunner(dataGridResults.SelectedItem as Participants2022);
            this.NavigationService.Navigate(editRunners);
        }

        private void importAllCSV(object sender, RoutedEventArgs e)
        {

            System.Windows.Forms.FolderBrowserDialog FBD = new System.Windows.Forms.FolderBrowserDialog();
            FBD.ShowNewFolderButton = false;
            if (FBD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show(FBD.SelectedPath);

                string pathCsvFile = FBD.SelectedPath + "import.csv";

                using (StreamWriter streamReader = new StreamWriter(pathCsvFile))
                {
                    using (CsvWriter csvReader = new CsvWriter(streamReader, System.Globalization.CultureInfo.InvariantCulture))
                    {
                        csvReader.WriteRecords(participants2022s);
                    }
                }
                MessageBox.Show("Загрузка произошла успешно, данные были импортированы по пути:\n" + FBD.SelectedPath + "import.csv");
            }
            else
            {
                MessageBox.Show("Warning 0\nПроизошла непредвиденная ошибка");
            }
        }

        private void inputEmail(object sender, RoutedEventArgs e)
        {
            WpfApp3.RolePage.Coordinaor.Runner.importEmailRunners newWindow = new WpfApp3.RolePage.Coordinaor.Runner.importEmailRunners();
            newWindow.Show();
        }

    }
}
