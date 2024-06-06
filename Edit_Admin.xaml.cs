using System;
using System.Windows;
using System.Windows.Controls;
using Microsoft.EntityFrameworkCore;

namespace Project_one_EAD
{
    /// <summary>
    /// Interaction logic for Edit_Admin.xaml
    /// </summary>
    public partial class Edit_Admin : Page
    {
        private readonly SuperAdmin _superAdminPage;
        private readonly User _userToUpdate;

        public Edit_Admin(SuperAdmin superAdminPage, User userToUpdate)
        {
            InitializeComponent();
            _superAdminPage = superAdminPage;
            _userToUpdate = userToUpdate;
            DataContext = _userToUpdate;
            // Populate TextBoxes with current user details
            username.Text = _userToUpdate.Username;
            password.Password = _userToUpdate.Password;
            role.Text = _userToUpdate.Role.ToString();
        }

        private void Password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            // Get the password from the PasswordBox
            var passwordBox = sender as PasswordBox;
            var password = passwordBox.Password;

            // Now you can use the password as needed
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Update the user details
                _userToUpdate.Username = username.Text;
                _userToUpdate.Password = password.Password;
                _userToUpdate.Role = Convert.ToInt32(role.Text);

                // Update user in the database
                using (var db = new Project1Context(new DbContextOptions<Project1Context>())) // Correct instantiation
                {
                    db.Users.Update(_userToUpdate);
                    db.SaveChanges();
                }

                // Inform the user that the user has been updated successfully
                MessageBox.Show("User updated successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                // Refresh user list in SuperAdminPage
                _superAdminPage.RefreshUserList();

                // Navigate back to the previous page
                NavigationService?.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click_exit(object sender, RoutedEventArgs e)
        {
            // Exiting application. 
            System.Environment.Exit(0);
        }
    }
}
