
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;

using System.Windows.Media.Imaging;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для RegisterRunner.xaml
    /// </summary>
    public partial class RegisterRunner : Page
    {
        public RegisterRunner()
        {
            InitializeComponent();
        }

        private void buttonBack(object sender, RoutedEventArgs e)
        {
            this.Content = null;
        }

        private void btnRegister(object sender, RoutedEventArgs e)
        {
            string errorMessage = "";

            if (Email.Text is null)
                errorMessage += "/n Email";
            if (Pass.Password.ToString() is null)
                errorMessage += "/n Email";
            if (DoublePass.Password.ToString() is null)
                errorMessage += "/n Email";
            if (FirstName.Text is null)
                errorMessage += "/n Email";
            if (LastName.Text is null)
                errorMessage += "/n Email";
            if (Pass.Password.ToString() != DoublePass.Password.ToString())
            {
                errorMessage += "/n Пароли не совпадают";
            }
            if (textBoxFotoName.Text == "Выберите фотографию")
            {
                errorMessage += "/n Выберите фотографию";
                textBoxFotoName.Text = "Image/User/runner-default.jpg";
            }

            if (errorMessage == "")
            {
                try
                {
                    User NewUser = new User
                    {
                        Email = Email.Text,
                        Password = Pass.Password.ToString(),
                        FirstName = FirstName.Text,
                        LastName = LastName.Text,
                        RoleId = "R",
                        Patch = textBoxFotoName.Text
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

                    MessageBox.Show("Вы были зарегистрированы на марафон!");
                }
                catch
                {
                    MessageBox.Show("Error 0\n Произошла непредвидиная ошибка \nНе установленно соиденение с базой");
                }
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }

        private void selectedFoto(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";

            if (op.ShowDialog() == true)
            {
                fotoRunner.Source = new BitmapImage(new Uri(op.FileName));
                textBoxFotoName.Text = op.FileName;
            }

        }
    }
}
