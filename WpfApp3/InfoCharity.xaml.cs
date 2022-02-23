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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для InfoCharity.xaml
    /// </summary>
    public partial class InfoCharity : Window
    {
        public InfoCharity(Charity charity)
        {
            InitializeComponent();
            nameChartity.Text = charity.CharityName.ToString();
            chartityPhoto.Source = new BitmapImage(new Uri(charity.CharityLogo.ToString(), UriKind.Relative));
            description.Text = charity.CharityDescription.ToString();
        }
    }
}
