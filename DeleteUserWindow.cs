using System.Windows;
using WPF.DataModel;

namespace WPF
{
    public partial class DeleteUserWindow : Window
    {
        private int UserId { get; }

        public DeleteUserWindow(int userId)
        {
            InitializeComponent();
            UserId = userId;
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void ConfirmDeleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using var db = new ApplicationContext();
                var userToDelete = db.Users.FirstOrDefault(u => u.Id == UserId);
                if (userToDelete != null)
                {
                    db.Users.Remove(userToDelete);
                    db.SaveChanges();
                    Close();
                    MessageBox.Show("Пользователь успешно удален.");
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
            finally
            {
                Close();
            }
        }
    }
}
