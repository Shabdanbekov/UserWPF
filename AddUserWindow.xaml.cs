using System;
using System.Windows;

namespace WPF
{
    public partial class AddUserWindow : Window
    {
        public AddUserWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string fullName = fullNameTextBox.Text;
            DateTime? birthDate = birthDatePicker.SelectedDate;
            if (birthDate.HasValue)
            {
                try
                {
                    var newUser = new DataModel.User { FullName = fullName, BirthDate = birthDate };
                    using (var db = new DataModel.ApplicationContext())
                    {
                        db.Users.Add(newUser);
                        db.SaveChanges();
                        Close();
                    }
                    MessageBox.Show("Пользователь успешно добавлен.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении пользователя: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите дату рождения.");
            }
        }


    }
}
