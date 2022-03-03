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
    /// Логика взаимодействия для BMRcalculator.xaml
    /// </summary>
    public partial class BMRcalculator : Page
    {

        char gender = 'M';

        public BMRcalculator()
        {
            InitializeComponent();
        }




        private void TextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            double bmr;

            if(gender == 'M')
            {
                bmr = (13.7 * float.Parse(weight.Text)) + (5 * float.Parse(height.Text)) - (6.8 * float.Parse(age.Text)) + 66;
            }
            else
            {
                bmr = (9.6 * float.Parse(weight.Text)) + (1.8 * float.Parse(height.Text)) - (4.7 * float.Parse(age.Text)) + 655;
            }


            textBlockBMR.Text = (Decimal.Round(decimal.Parse(bmr.ToString()), 2)).ToString();

            textBlockSit.Text = (Decimal.Round(decimal.Parse((bmr*1.2).ToString()), 2)).ToString();
            textBlockMin.Text = (Decimal.Round(decimal.Parse((bmr * 1.375).ToString()), 2)).ToString();
            textBlockPol.Text = (Decimal.Round(decimal.Parse((bmr * 1.55).ToString()), 2)).ToString();
            textBlockSil.Text = (Decimal.Round(decimal.Parse((bmr * 1.725).ToString()), 2)).ToString();
            textBlockMax.Text = (Decimal.Round(decimal.Parse((bmr * 1.9).ToString()), 2)).ToString();
        }



        private void buttonBack(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Info.xaml", UriKind.Relative));
        }

        private void ButtonGender(object sender, RoutedEventArgs e)
        {
            female.Background = (Brush)new BrushConverter().ConvertFrom("#ebebeb");
            male.Background = (Brush)new BrushConverter().ConvertFrom("#ebebeb");
            if (sender == female)
            {
                gender = 'F';
                female.Background = (Brush)new BrushConverter().ConvertFrom("#FFA2A2A2");
            }
            if (sender == male)
            {
                gender = 'M';
                male.Background = (Brush)new BrushConverter().ConvertFrom("#FFA2A2A2");
            }
        }

        private void ButtonInfo(object sender, RoutedEventArgs e)
        {
            infoBMRCalculator info = new infoBMRCalculator();
            info.Show();
         }
    }
}
