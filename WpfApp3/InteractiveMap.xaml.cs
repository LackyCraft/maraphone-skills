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
    /// Логика взаимодействия для InteractiveMap.xaml
    /// </summary>
    public partial class InteractiveMap : Window
    {
        public InteractiveMap()
        {
            InitializeComponent();
        }

        private void startMaraphon(object sender, RoutedEventArgs e)
        {
            if (sender == fullMaraphon) {
                labelInfoMaraphon.Text = "Race Start";
                textInfoPoint.Text = "Samba Full Maraphon";
            }
            if(sender == funRunMaraphon)
            {
                labelInfoMaraphon.Text = "Race Start";
                textInfoPoint.Text = "Samba Fun Maraphon";
            }
            if (sender == halfRunMaraphon)
            {
                labelInfoMaraphon.Text = "Race Start";
                textInfoPoint.Text = "Samba Half Maraphon";
            }
        }


        private void infoPoint(object sender, RoutedEventArgs e)
        {
            stackPanel.Children.Clear();
            if (sender == point1)
            {
                StackPanel sp = new StackPanel();
                sp.Orientation = System.Windows.Controls.Orientation.Horizontal;
                TextBlock texting = new TextBlock();
                Image images = new Image();
                images.Source = new BitmapImage(new Uri("Image/icon/map-icon-drinks.png", UriKind.Relative));
                images.Height = 30;
                texting.Text = " - Drinks";
                texting.TextAlignment = System.Windows.TextAlignment.Center;
                sp.Children.Add(images);
                sp.Children.Add(texting);
                stackPanel.Children.Add(sp);

                StackPanel sp1 = new StackPanel();
                sp1.Orientation = System.Windows.Controls.Orientation.Horizontal;
                TextBlock texting1 = new TextBlock();
                Image images1 = new Image();
                images1.Source = new BitmapImage(new Uri("Image/icon/map-icon-energy-bars.png", UriKind.Relative));
                images1.Height = 30;
                texting1.Text = " - Energy Bars";
                texting1.TextAlignment = System.Windows.TextAlignment.Center;
                sp1.Children.Add(images1);
                sp1.Children.Add(texting1);
                stackPanel.Children.Add(sp1);
            }

            if (sender == point2)
            {
                labelInfoMaraphon.Text = "Checkpoint 2";
                textInfoPoint.Text = "Theatro Municipal";
                StackPanel sp = new StackPanel();
                sp.Orientation = System.Windows.Controls.Orientation.Horizontal;
                TextBlock texting = new TextBlock();
                Image images = new Image();
                images.Source = new BitmapImage(new Uri("Image/icon/map-icon-drinks.png", UriKind.Relative));
                images.Height = 30;
                texting.Text = " - Drinks";
                texting.TextAlignment = System.Windows.TextAlignment.Center;
                sp.Children.Add(images);
                sp.Children.Add(texting);
                stackPanel.Children.Add(sp);

                StackPanel sp1 = new StackPanel();
                sp1.Orientation = System.Windows.Controls.Orientation.Horizontal;
                TextBlock texting1 = new TextBlock();
                Image images1 = new Image();
                images1.Source = new BitmapImage(new Uri("Image/icon/map-icon-energy-bars.png", UriKind.Relative));
                images1.Height = 30;
                texting1.Text = " - Energy Bars";
                texting1.TextAlignment = System.Windows.TextAlignment.Center;
                sp1.Children.Add(images1);
                sp1.Children.Add(texting1);
                stackPanel.Children.Add(sp1);

                StackPanel sp2 = new StackPanel();
                sp2.Orientation = System.Windows.Controls.Orientation.Horizontal;
                TextBlock texting2 = new TextBlock();
                Image images2 = new Image();
                images2.Source = new BitmapImage(new Uri("Image/icon/map-icon-toilets.png", UriKind.Relative));
                images2.Height = 30;
                texting2.Text = " - Toilets";
                texting2.TextAlignment = System.Windows.TextAlignment.Center;
                sp2.Children.Add(images2);
                sp2.Children.Add(texting2);
                stackPanel.Children.Add(sp2);


                StackPanel sp3 = new StackPanel();
                sp3.Orientation = System.Windows.Controls.Orientation.Horizontal;
                TextBlock texting3 = new TextBlock();
                Image images3 = new Image();
                images3.Source = new BitmapImage(new Uri("Image/icon/map-icon-information.png", UriKind.Relative));
                images3.Height = 30;
                texting3.Text = " - Information";
                texting3.TextAlignment = System.Windows.TextAlignment.Center;
                sp3.Children.Add(images3);
                sp3.Children.Add(texting3);
                stackPanel.Children.Add(sp3);

                StackPanel sp4 = new StackPanel();
                sp4.Orientation = System.Windows.Controls.Orientation.Horizontal;
                TextBlock texting4 = new TextBlock();
                Image images4 = new Image();
                images4.Source = new BitmapImage(new Uri("Image/icon/map-icon-medical.png", UriKind.Relative));
                images4.Height = 30;
                texting4.Text = " - Medical";
                texting4.TextAlignment = System.Windows.TextAlignment.Center;
                sp4.Children.Add(images4);
                sp4.Children.Add(texting4);
                stackPanel.Children.Add(sp4);
            }

        }
    }
}
