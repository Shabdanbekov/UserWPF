using System.Windows;


namespace WPF
{
    public partial class UpdateOrDeleteUserWindow : Window
    {
        public int UserId { get; private set; }

        public UpdateOrDeleteUserWindow(int userId)
        {
            InitializeComponent();
            UserId = userId;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using var db = new DataModel.ApplicationContext();
                var user = db.Users.FirstOrDefault(u => u.Id == UserId);
                if (user != null)
                {
                    db.Users.Remove(user);
                    db.SaveChanges();
                    MessageBox.Show("Пользователь успешно удалён.");
                    Close();
                }
                else
                {
                    MessageBox.Show("Пользователь с указанным Id не найден.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении пользователя: {ex.Message}");
            }
        }


        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            var updateUserWindow = new UpdateUserWindow(UserId);
            updateUserWindow.ShowDialog();
            Close();
        }
    }
}
