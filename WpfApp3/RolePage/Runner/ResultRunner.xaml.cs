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
    /// Логика взаимодействия для ResultRunner.xaml
    /// </summary>
    public partial class ResultRunner : Page
    {
        public ResultRunner()
        {
            InitializeComponent();
            int idUserRunner = int.Parse(Application.Current.Resources["idRunner"].ToString());
            dataGridOldResults.ItemsSource = ws2016Entities5.GetContext().RunnerResult.Where(i => i.RunnerId == idUserRunner).ToList();
        }
        private void buttonBack(object sender, RoutedEventArgs e)
        {
            this.Content = null;
        }
    }
}
