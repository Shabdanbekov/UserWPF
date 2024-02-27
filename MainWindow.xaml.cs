using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            RefreshUserList();
        }

        private void RefreshUserList()
        {
            try
            {
                using var db = new DataModel.ApplicationContext();
                userListView.ItemsSource = db.Users.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке списка пользователей: {ex.Message}");
            }
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            var addUserWindow = new AddUserWindow();
            addUserWindow.ShowDialog();
            RefreshUserList();
        }

        private void userListView_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (userListView.SelectedItem != null)
            {
                var selectedUser = (DataModel.User)userListView.SelectedItem;
                var updateOrDeleteUserWindow = new UpdateOrDeleteUserWindow(selectedUser.Id);
                updateOrDeleteUserWindow.ShowDialog();
                RefreshUserList();
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}