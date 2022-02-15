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
            var authInfo = ws2016Entities4.GetContext().User.Where(i => i.Email == login && i.Password == pass).ToList();

            if (authInfo.Count > 0)
            {
                MessageBox.Show("Email: " + authInfo[0].Email.ToString() + "\n" + authInfo[0].Password.ToString());
                //foreach (var item in authInfo)
                //{
                //    MessageBox.Show("Email: "+ item.Email.ToString() +""+ item.Password.ToString());
                //}
            }
            else
            {
                MessageBox.Show("Errors");
            }

        }
    }
}
