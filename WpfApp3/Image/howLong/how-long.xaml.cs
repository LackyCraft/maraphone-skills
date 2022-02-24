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
    /// Логика взаимодействия для how_long.xaml
    /// </summary>
    public partial class how_long : Page
    {
        public how_long()
        {
            InitializeComponent();
        }
        private void buttonBack(object sender, RoutedEventArgs e)
        {
            this.Content = null;
        }

        private string cal_time(double dist, double time)

        {
            var t = TimeSpan.FromHours(dist /time);
            return (t.Hours.ToString() + " часов " + t.Minutes.ToString() + " минут " + t.Seconds.ToString() + " секунд.");

        }

        private void sayInfo(object sender, RoutedEventArgs e)
        {
            if(sender == f1Car)
            {
                imageBox.Source = new BitmapImage(new Uri("speed/f1-car.jpg", UriKind.Relative));
                textBlockInfo.Text = "Карту формулы-1 со скоростью 345 км/ч понадобилось бы: " + cal_time(42,345) + ", что бы пройти полный марафон в 42 км.";
            }
            if (sender == capybara)
            {
                imageBox.Source = new BitmapImage(new Uri("speed/capybara.jpg", UriKind.Relative));
                textBlockInfo.Text = "Копибаре со скоростью 35 км/ч понадобилось бы: " + cal_time(42, 35) + ", что бы пройти полный марафон в 42 км.";
            }
            if (sender == horse)
            {
                imageBox.Source = new BitmapImage(new Uri("speed/horse.png", UriKind.Relative));
                textBlockInfo.Text = "Лошади со скоростью 15 км/ч понадобилось бы: " + cal_time(42, 15) + ", что бы пройти полный марафон в 42 км.";
            }
            if (sender == jaguar)
            {
                imageBox.Source = new BitmapImage(new Uri("speed/jaguar.jpg", UriKind.Relative));
                textBlockInfo.Text = "Ягуару со скоростью 80 км/ч понадобилось бы: " + cal_time(42, 80) + ", что бы пройти полный марафон в 42 км.";
            }
            if (sender == sloth)
            {
                imageBox.Source = new BitmapImage(new Uri("speed/sloth.jpg", UriKind.Relative));
                textBlockInfo.Text = "Ленивцу со скоростью 0.12 км/ч понадобилось бы: " + cal_time(42, 0.12) + ", что бы пройти полный марафон в 42 км.";
            }
            if (sender == slug)
            {
                imageBox.Source = new BitmapImage(new Uri("speed/slug.jpg", UriKind.Relative));
                textBlockInfo.Text = "Слизню со скоростью 0.01 км/ч понадобилось бы: " + 42 / 0.01 / 24 + " дней " + ", что бы пройти полный марафон в 42 км.";
            }
            if (sender == worm)
            {
                imageBox.Source = new BitmapImage(new Uri("speed/worm.jpg", UriKind.Relative));
                textBlockInfo.Text = "Червю со скоростью 0.3 км/ч понадобилось бы: " + cal_time(42, 0.3) + ", что бы пройти полный марафон в 42 км.";
            }


            if (sender == bus)
            {
                imageBox.Source = new BitmapImage(new Uri("distance/bus.jpg", UriKind.Relative));
                textBlockInfo.Text = "Автобус примерно 10 м. в длину, что бы полностью заполнить линию марафона в 42 км. понадобиться: " + 420/10 + " автобусов";
            }
            if (sender == pairOfHar)
            {
                imageBox.Source = new BitmapImage(new Uri("distance/pair-of-havaianas.jpg", UriKind.Relative));
                textBlockInfo.Text = "Пара тапочек примерно 0.245 м. в длину, что бы полностью заполнить линию марафона в 42 км. понадобиться: " + 420/0.245 + " пар тапочек";
            }
            if (sender == airtbus)
            {
                imageBox.Source = new BitmapImage(new Uri("distance/airbus-a380.jpg", UriKind.Relative));
                textBlockInfo.Text = "Самалет примерно 73 м. в длину, что бы полностью заполнить линию марафона в 42 км. понадобиться: " + 420/73 + " самалетов";
            }
            if (sender == footbool)
            {
                imageBox.Source = new BitmapImage(new Uri("distance/football-field.jpg", UriKind.Relative));
                textBlockInfo.Text = "Футбольный стадион примерно 105 м. в длину, что бы полностью заполнить линию марафона в 42 км. понадобиться: " + 420/105 + " стадионов";
            }
            if (sender == ronaldo)
            {
                imageBox.Source = new BitmapImage(new Uri("distance/ronaldinho.jpg", UriKind.Relative));
                textBlockInfo.Text = "Рост Рональдо примерно 1.81 м., что бы полностью заполнить линию марафона в 42 км. понадобиться: " + 420 / 1.81 + " Ранольдо";
            }

        }
    }
}
