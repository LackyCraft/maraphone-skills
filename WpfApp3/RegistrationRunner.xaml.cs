
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

using System.Text.RegularExpressions;
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

        string stringCodeCountry="";

        public RegisterRunner()
        {
            InitializeComponent();
            boxGender.ItemsSource = ws2016Entities5.GetContext().Gender.ToList();
            comboBoxCountrty.ItemsSource = ws2016Entities5.GetContext().Country.ToList();
        }

        private void buttonBack(object sender, RoutedEventArgs e)
        {
            this.Content = null;
        }

        private void btnRegister(object sender, RoutedEventArgs e)
        {
            string errorMessage = "";

            string cond = @"(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)";

            if (!Regex.IsMatch(Email.Text, cond))
                errorMessage += "\n Email Введен не корректно";
            if (FirstName.Text.Length <= 0)
                errorMessage += "\n Поле имя не заполнено";
            if (LastName.Text.Length <= 0)
                errorMessage += "\n Поле фамилия не заполнено ";
            if (Pass.Password.ToString() != DoublePass.Password.ToString() || (DoublePass.Password.ToString() is null) || (Pass.Password.ToString() is null))
            {
                errorMessage += "\n Пароли не совпадают";
            }
            if (textBoxFotoName.Text == "Выберите фотографию")
            {
                errorMessage += "\n Выберите фотографию или оставьте фото по умолчанию";
                textBoxFotoName.Text = "Image/User/runner-default.jpg";
            }if (stringCodeCountry.Length <= 0)
                errorMessage += "\n Выберите вашу страну";
            if(DataOfBrith is null)
                errorMessage += "\n Заполните дату";

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

                    Application.Current.Resources["LastName"] = NewUser.LastName;
                    Application.Current.Resources["FirstName"] = NewUser.FirstName;
                    Application.Current.Resources["Role"] = "R";
                    Application.Current.Resources["PhotoPatch"] = NewUser.Patch;
                    Application.Current.Resources["Email"] = NewUser.Email;


                    //this.Content = null;

                    string dates = DataOfBrith.Text;
                    DateTime bhirder = DataOfBrith.SelectedDate.Value.Date;


                    //MessageBox.Show(stringCodeCountry);


                    Runner NewRunner = new Runner
                    {
                        Email = Email.Text,
                        Gender = boxGender.Text,
                        DateOfBirth = bhirder,
                        CountryCode = stringCodeCountry
                    };
                    ws2016Entities5.GetContext().Runner.Add(NewRunner);
                    ws2016Entities5.GetContext().SaveChanges();

                    Application.Current.Resources["idRunner"] = NewRunner.RunnerId;
                    Application.Current.Resources["Gender"] = NewRunner.Gender;
                    Application.Current.Resources["CountryCode"] = NewRunner.CountryCode;

                    MessageBox.Show("Вы были зарегистрированы на марафон!");
                    ScrolPage(sender,e);
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

        private void Gender_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                boxGender.Text = (boxGender.SelectedItem as Gender).Gender1.ToString();
                //MessageBox.Show("Selected Item Text: " + (boxGender.SelectedItem as Gender).Gender1.ToString());
            }
            catch
            {

            }
        }

        private void Countrty_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show(comboBoxCountrty.SelectedValue.ToString());
            try
            {

            
            string selectCountry = (comboBoxCountrty.SelectedItem as Country).CountryName.ToString();
                //MessageBox.Show(selectCountry);
                
            var codeGender = ws2016Entities5.GetContext().Country.Where(i => i.CountryName == selectCountry).ToList();

            stringCodeCountry = codeGender[0].CountryCode.ToString();
            }
            catch
            {

            }
        }

        private void ScrolPage(object sender, RoutedEventArgs e)
        {

            //NavigationService nav;
            //nav = NavigationService.GetNavigationService(this);
            if (sender == Register)
                this.NavigationService.Navigate(new Uri("RegistertationRunnerInMaraphon.xaml", UriKind.Relative));
        }

    }
}
