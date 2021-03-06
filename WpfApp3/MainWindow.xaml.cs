using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
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
using System.ComponentModel;

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        public string Time
        {
            get
            {
                DateTime dt1 = DateTime.Now;
                DateTime dt2 = DateTime.Parse("2022-07-11 10:00");

                TimeSpan ts = dt2 - dt1;

                return string.Format("{0} дн {1} ч {2} мин {3} с до начала марофона!", ts.Days, ts.Hours, ts.Minutes, ts.Seconds);
            }
        }

        public string ButtonAuth
        {
            get
            {
                if (Application.Current.Resources["Email"] is null)
                {
                    return "Login";
                }
                else
                {
                    return "LogOut";
                }
                //return string.Format("{0} дн {1} ч {2} мин {3} с до начала марофона!", ts.Days, ts.Hours, ts.Minutes, ts.Seconds);
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            //frame.Navigate(new login);
            this.DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;


        private void Windows_Loaded(object sender, RoutedEventArgs e)
        {
            

            Timer tmr = new Timer();

            tmr.Interval = 1000;
            tmr.Elapsed += editTimerText;
            tmr.Elapsed += buttonAuthEdit;

            tmr.Start();

            
        }

        private void editTimerText(object sender, ElapsedEventArgs e)
        {
            PropertyChange("Time");
        }

        private void buttonAuthEdit(object sender, ElapsedEventArgs e)
        {
            PropertyChange("ButtonAuth");
        }

        private void PropertyChange(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        private void ScrolPage(object sender, RoutedEventArgs e)
        {

            //NavigationService nav;
            //nav = NavigationService.GetNavigationService(this);
            if (sender == runnerMain)
                frame.NavigationService.Navigate(new Uri("Runner.xaml", UriKind.Relative));
       if (sender == ReferRunner)
                frame.NavigationService.Navigate(new Uri("ReferRunner.xaml", UriKind.Relative));
       if (sender == Info)
                frame.NavigationService.Navigate(new Uri("Info.xaml", UriKind.Relative));
       if (sender == Auth && Auth.Content.ToString() == "Login")
                frame.NavigationService.Navigate(new Uri("Auth.xaml", UriKind.Relative));
       if (sender == Auth && Auth.Content.ToString() == "LogOut")
            {
                Application.Current.Resources["Email"] = null;
                Application.Current.Resources["Role"] = null;
                //frame.NavigationService.Navigate(new Uri("MainWindow.xaml", UriKind.Relative));
                frame.Content = null;
            }
                
        }
    }
}
