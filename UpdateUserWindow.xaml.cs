using System.Windows;


namespace WPF
{
    public partial class UpdateUserWindow : Window
    {
        private int UserId { get; }

        public UpdateUserWindow(int userId)
        {
            InitializeComponent();
            UserId = userId;
            LoadUserData();
        }

        private void LoadUserData()
        {
            try
            {
                using var db = new DataModel.ApplicationContext();
                var user = db.Users.FirstOrDefault(u => u.Id == UserId);
                if (user != null)
                {
                    fullNameTextBox.Text = user.FullName;
                    birthDateTextBox.Text = user.BirthDate.ToString();
                }
                else
                {
                    MessageBox.Show("User with specified Id not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user data: {ex.Message}");
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using var db = new DataModel.ApplicationContext();
                var user = db.Users.FirstOrDefault(u => u.Id == UserId);
                if (user != null)
                {
                    user.FullName = fullNameTextBox.Text;

                    if (DateTime.TryParse(birthDateTextBox.Text, out DateTime birthDate))
                    {
                        user.BirthDate = birthDate;
                        db.SaveChanges();
                        MessageBox.Show("Данные пользователя успешно обновлены.");
                        Close(); 
                    }
                    else
                    {
                        MessageBox.Show("Ошибка ввода даты рождения.");
                    }
                }
                else
                {
                    MessageBox.Show("Пользователь с указанным Id не найден.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении данных пользователя: {ex.Message}");
            }
        }

    }
}
