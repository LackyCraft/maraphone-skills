using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
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

namespace WpfApp3.RolePage.Admin
{
    public partial class RemoteRunner : Page
    {

        List<User> usersList =  ws2016Entities5.GetContext().User.ToList();

        public RemoteRunner()
        {
            InitializeComponent();
            dataGridResults.ItemsSource = usersList;
            selectedRole.ItemsSource = ws2016Entities5.GetContext().Role.ToList(); ;
            wayColumn.ItemsSource = new List<string>() { "Имя", "Фамилия", "Email", "Роль"};
        }

        private void editRunner(object sender, RoutedEventArgs e)
        {
            editUser editPageUSer = new editUser(dataGridResults.SelectedItem as User);
            //this.NavigationService.Navigate(editPageUSer);
            this.NavigationService.Navigate(editPageUSer);
            //editPageUSer.NavigationService.Navigate(new Uri("RolePage/Admin/editUser.xaml", UriKind.Relative));
        }

        private void ButtonBack(object sender, RoutedEventArgs e)
        {
            this.Content = null;
        }

        private void ButtonUpdate(object sender, RoutedEventArgs e)
        {
            List<User> usersFilter = usersList;
            if (!(selectedRole.SelectedValue.ToString() is null))
            {
                usersFilter = usersFilter.Where(i => i.Role.RoleId == selectedRole.SelectedValue.ToString()).ToList();
            }
             if (wayColumn.SelectedValue.ToString() == "Имя")
             {
                usersFilter = usersFilter.OrderBy(i => i.FirstName).ToList();
             }
            if (wayColumn.SelectedValue.ToString() == "Фамилия")
            {
                usersFilter = usersFilter.OrderBy(i => i.LastName).ToList();
            }
            if (wayColumn.SelectedValue.ToString() == "Email")
            {
                usersFilter = usersFilter.OrderBy(i => i.Email).ToList();
            }
            if (wayColumn.SelectedValue.ToString() == "Роль")
            {
                usersFilter = usersFilter.OrderBy(i => i.Role.RoleName).ToList();
            }
            if (!(textBoxSearch.Text.ToString() is null))
            {
                usersFilter = usersFilter.Where(i => (i.FirstName.Contains(textBoxSearch.Text.ToString()) || i.LastName.Contains(textBoxSearch.Text.ToString()) || i.Email.Contains(textBoxSearch.Text.ToString()) || i.Role.RoleName.Contains(textBoxSearch.Text.ToString()))).ToList();
                //(i.FirstName == textBoxSearch.Text.ToString()) || (i.FirstName == textBoxSearch.Text.ToString()) || (i.Email == textBoxSearch.Text.ToString()) || (i.Role.RoleName == textBoxSearch.Text.ToString())
            }
            dataGridResults.ItemsSource = usersFilter;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
