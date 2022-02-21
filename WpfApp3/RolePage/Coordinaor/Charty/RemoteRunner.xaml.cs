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

namespace WpfApp3.RolePage.Coordinaor.Charty
{
    /// <summary>
    /// Логика взаимодействия для RemoteRunner.xaml
    /// </summary>
    public partial class RemoteRunner : Page
    {

        //List<runner> materialList = new List<runner>();
        List<string> listSort = new List<string>() { "Сортировка", "Наименование по возрастанию", "Наименование по убыванию", "Остаток по возрастанию", "Остаток по убыванию",
                                                     "Стоимость по возрастанию", "Стоимость по убыванию"};
        List<string> listFilter = new List<string>() { "Фильтрация", "Краска", "Резина", "Силикон" };

        public RemoteRunner()
        {
            InitializeComponent();
        }
        private void buttonBack(object sender, RoutedEventArgs e)
        {
            this.Content = null;
        }
    }
}
