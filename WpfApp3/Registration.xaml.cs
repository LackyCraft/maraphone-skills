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
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {

        User Users = new User();

        public Page4()
        {
            InitializeComponent();
        }
        private void buttonBack(object sender, RoutedEventArgs e)
        {
            this.Content = null;
        }

        private void btnRegister(object sender, RoutedEventArgs e)
        {
            
            if (Pass.Password.ToString() == DoublePass.Password.ToString())
            {
                User NewUser = new User
                {
                    Email = Email.Text,
                    Password = Pass.Password.ToString(),
                    FirstName = DoublePass.Password.ToString(),
                    LastName = Name.Text,
                    RoleId = "R"
                };
                ws2016Entities5.GetContext().User.Add(NewUser);
                ws2016Entities5.GetContext().SaveChanges(); 

            //this.Content = null;

            string dates = DataOfBrith.Text;
                DateTime bhirder = DataOfBrith.SelectedDate.Value.Date;


                //MessageBox.Show(dates);

                Runner NewRunner = new Runner
            {
                Email = Email.Text,
                Gender = Male.Text,
                DateOfBirth = bhirder,
                CountryCode = Countrty.Text
            };
            ws2016Entities5.GetContext().Runner.Add(NewRunner);
            ws2016Entities5.GetContext().SaveChanges(); 

            MessageBox.Show("ID до сохранения в базе: {0}", NewUser.Email);
        }

        }

    }
}
