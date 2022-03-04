using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WpfApp3.RolePage.Admin
{
    /// <summary>
    /// Логика взаимодействия для editUser.xaml
    /// </summary>
    public partial class editUser : Page
    {
        User editUserItem = new User();

        public editUser(User users)
        {
            InitializeComponent();
            editUserItem = users;
            boxRole.ItemsSource = ws2016Entities5.GetContext().Role.ToList();
            boxRole.Text = editUserItem.Role.RoleName;
            Email.Text = editUserItem.Email;
            FirstName.Text = editUserItem.FirstName;
            LastName.Text = editUserItem.LastName;
        }

        private void ButtonSave(object sender, RoutedEventArgs e)
        {
            string errorMessage = "";

            if (FirstName.Text.Length <= 0)
                errorMessage += "\n Поле имя не заполнено";
            if (LastName.Text.Length <= 0)
                errorMessage += "\n Поле фамилия не заполнено ";
            if (password.Password.ToString() != doublePass.Password.ToString() || (doublePass.Password.ToString() is null) || (password.Password.ToString() is null))
            {
                errorMessage += "\n Пароли не совпадают";
            }

            if (!Regex.IsMatch(password.Password.ToString(), @"\S\S\S\S\S\S"))
                errorMessage += "\nПароль должен содержать минимум 6 символов";
            if (!Regex.IsMatch(password.Password.ToString(), @"\d"))
                errorMessage += "\nПароль должен содержать хотя бы 1 цифру";
            if (!Regex.IsMatch(password.Password.ToString(), @"([A-Z])"))
                errorMessage += "\nПароль должен содержать хотябы одну заглавную букву";


            if (errorMessage == "")
            {
                editUserItem.LastName = LastName.Text.ToString();
                editUserItem.FirstName = FirstName.Text.ToString();
                editUserItem.RoleId = boxRole.SelectedValue.ToString();
                editUserItem.Password = password.Password.ToString();

                ws2016Entities5.GetContext().SaveChanges();
                MessageBox.Show("Изменения сохранены");

                this.NavigationService.Navigate(new Uri("/RolePage/MenuAdministratorPage.xaml", UriKind.Relative));
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }

        private void ButtonBack(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("RemoteRunner.xaml", UriKind.Relative));
        }

    }
}
