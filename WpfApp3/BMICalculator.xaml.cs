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
    /// Логика взаимодействия для BMICalculator.xaml
    /// </summary>
    public partial class BMICalculator : Page
    {
        public BMICalculator()
        {
            InitializeComponent();
        }

        private void TextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            float bmi = float.Parse(weight.Text) / ((float.Parse(height.Text) / 100) * (float.Parse(height.Text) / 100));

            textBlockBMIcount.Text = (Decimal.Round(decimal.Parse(bmi.ToString()), 2)).ToString();
            stackPanelBMI.Margin = new Thickness(bmi * 6,0,0,0);
            
            if (bmi < 18.5)
                health.Content = "Недостаточный вес";
            if (bmi > 18.5 && bmi <24.9)
                health.Content = "Здоровый";
            if (bmi > 25 && bmi < 29.9)
                health.Content = "Избыточный вес";
            if (bmi > 30)
                health.Content = "Ожирение";
        }


        private void buttonBack(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Info.xaml", UriKind.Relative));
        }


    }
}
