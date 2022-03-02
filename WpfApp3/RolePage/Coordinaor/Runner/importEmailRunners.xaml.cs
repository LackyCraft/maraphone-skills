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
using System.Windows.Shapes;

namespace WpfApp3.RolePage.Coordinaor.Runner
{
    /// <summary>
    /// Логика взаимодействия для importEmailRunners.xaml
    /// </summary>
    public partial class importEmailRunners : Window
    {
        public importEmailRunners()
        {
            InitializeComponent();
            dataGridEmail.ItemsSource = ws2016Entities5.GetContext().Participants2022.ToList();
            InitializeComponent();
        }
    }
}
