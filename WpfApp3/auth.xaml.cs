using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для auth.xaml
    /// </summary>
    public partial class auth : Page
    {
        public auth()
        {
            InitializeComponent();
            if (!(Application.Current.Resources["Role"] is null || Application.Current.Resources["Email"].ToString() is null))
            {
                MessageBox.Show("Вы уже вошли под учетной записью: " + Application.Current.Resources["Email"].ToString());
                this.Content = null;
            }
        }
        private void buttonBack(object sender, RoutedEventArgs e)
        {
            this.Content = null;
        }

        private void btnLogin(object sender, RoutedEventArgs e)
        {
            string login = Login.Text;
            string pass = Pass.Password.ToString();
            //MessageBox.Show(login+"\n"+pass);
            //List<string> people = new List<string>();
            var authInfo = ws2016Entities5.GetContext().User.Where(i => i.Email == login && i.Password == pass).ToList();

            if (authInfo.Count > 0)
            {
                // For test  //
                MessageBox.Show("Email: " + authInfo[0].Email.ToString() + "\n" + authInfo[0].Password.ToString()+"\n"+ authInfo[0].RoleId.ToString());

                Application.Current.Resources["Email"] = authInfo[0].Email.ToString();
                Application.Current.Resources["Role"] = authInfo[0].RoleId.ToString();
                try
                {
                    
                    if(authInfo[0].RoleId.ToString() == "R")
                        this.NavigationService.Navigate(new Uri("RolePage/MenuRunnerPage.xaml", UriKind.Relative));
                    if (authInfo[0].RoleId.ToString() == "C")
                        this.NavigationService.Navigate(new Uri("RolePage/MenuCoordinatorPage.xaml", UriKind.Relative));
                    if (authInfo[0].RoleId.ToString() == "A")
                        this.NavigationService.Navigate(new Uri("RolePage/MenuAdministratorPage.xaml", UriKind.Relative));
                }
                catch
                {
                    MessageBox.Show("Warning: 0\nПроизошла не предвидиная ошибка");
                }
            }
            else
            {
                MessageBox.Show("Warning: 301\nНеправильный логин или пароль");
            }

        }



    }
}