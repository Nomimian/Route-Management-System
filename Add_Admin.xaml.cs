using Microsoft.EntityFrameworkCore;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Project_one_EAD
{
    /// <summary>
    /// Interaction logic for Add_Admin.xaml
    /// </summary>
    public partial class Add_Admin : Page
    {
        private readonly SuperAdmin _superAdminPage;

        public Add_Admin(SuperAdmin superAdminPage)
        {
            InitializeComponent();
            _superAdminPage = superAdminPage;
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
                string username = this.username.Text;
                string password = this.password.Password;
                int role = Convert.ToInt32(this.role.Text);

                if (role > 2)
                {
                    MessageBox.Show("Cannot set this role.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                // Create a new User object and assign values
                User newUser = new User
                {
                    Username = username,
                    Password = password,
                    Role = role
                };

                // Add the new user to the database context and save changes
                using (var db = new Project1Context(new DbContextOptions<Project1Context>()))
                {
                    db.Users.Add(newUser);
                    db.SaveChanges();
                }

                MessageBox.Show("User added successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                // Refresh the user list in the super admin page
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
