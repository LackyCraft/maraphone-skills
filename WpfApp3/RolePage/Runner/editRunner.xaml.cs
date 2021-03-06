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

namespace WpfApp3.RolePage.Runner
{
    /// <summary>
    /// Логика взаимодействия для editRunner.xaml
    /// </summary>
    public partial class editRunner : Page
    {
        public editRunner()
        {
            InitializeComponent();
            Email.Text = Application.Current.Resources["Email"].ToString();
            LastName.Text = Application.Current.Resources["LastName"].ToString();
            FirstName.Text = Application.Current.Resources["FirstName"].ToString();
            if (Application.Current.Resources["PhotoPatch"].ToString() != "null")
            {
                fotoRunner.Source = new BitmapImage(new Uri(Application.Current.Resources["PhotoPatch"].ToString()));
                textBoxFotoName.Text = Application.Current.Resources["PhotoPatch"].ToString();
            }
            comboBoxCountrty.ItemsSource = ws2016Entities5.GetContext().Country.ToList();
            comboBoxCountrty.SelectedValue = Application.Current.Resources["CountryCode"].ToString();
            boxGender.ItemsSource = ws2016Entities5.GetContext().Gender.ToList();
            boxGender.SelectedValue = Application.Current.Resources["Gender"].ToString();
            DataOfBrith.Text = Application.Current.Resources["DateOfBirth"].ToString();
        }

        private void buttonBack(object sender, RoutedEventArgs e)
        {
            this.Content = null;
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

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage = "";

            string cond = @"(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)";

            if (!Regex.IsMatch(Email.Text, cond))
                errorMessage += "\n Email Введен не корректно";
            if (FirstName.Text.Length <= 0)
                errorMessage += "\n Поле имя не заполнено";
            if (LastName.Text.Length <= 0)
                errorMessage += "\n Поле фамилия не заполнено ";

            if (textBoxFotoName.Text == "Выберите фотографию")
            {
                errorMessage += "\n Выберите фотографию или оставьте фото по умолчанию";
            }
            if (comboBoxCountrty.SelectedValue.ToString().Length <= 0)
                errorMessage += "\n Выберите вашу страну";
            DateTime d1 = DateTime.Now.AddYears(-1);
            if (DataOfBrith.SelectedDate > d1 || DataOfBrith.SelectedDate is null)
                errorMessage += "\n Дата рождения должна быть меньше " + d1;

            if (errorMessage.Length > 2)
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                var EditUser = ws2016Entities5.GetContext().User.Find(Email.Text.ToString());
                var EditRunner = ws2016Entities5.GetContext().Runner.Find(int.Parse(Application.Current.Resources["idRunner"].ToString()));

                string dates = DataOfBrith.Text;
                DateTime bhirder = DataOfBrith.SelectedDate.Value.Date;

                if (EditUser != null && EditRunner != null)
                {
                    EditUser.FirstName = FirstName.Text;
                    EditUser.LastName = LastName.Text;
                    EditUser.Patch = textBoxFotoName.Text;
                    ws2016Entities5.GetContext().SaveChanges();

                    EditRunner.Gender = boxGender.Text;
                    EditRunner.DateOfBirth = bhirder;
                    EditRunner.CountryCode = comboBoxCountrty.SelectedValue.ToString();
                    ws2016Entities5.GetContext().SaveChanges();
                    MessageBox.Show("Изменения были сохранены");
                }
                else
                {
                    MessageBox.Show("Warning 0:\n Произошла непредвиденная ошибка.\n Не удалось распознать информацию о пользователе");
                }
            }
        }
    }
}
