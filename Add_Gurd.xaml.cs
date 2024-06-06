using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project_one_EAD
{
    /// <summary>
    /// Interaction logic for AddUserPage.xaml
    /// </summary>
    public partial class Add_Gurd : Page
    {
        private readonly Admin _superAdminPage;

        public Add_Gurd(Admin superAdminPage)
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

                // Create a new User object and assign values
                User newUser = new User
                {
                    Username = username,
                    Password = password,
                    Role = 2 // Set the role to 2 for guard
                };

                // Add the new user to the database context and save changes
                using (var db = new Project1Context(new DbContextOptions<Project1Context>()))
                {
                    db.Users.Add(newUser);
                    db.SaveChanges();
                }

                MessageBox.Show("User added successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

               
                // Refresh the guard list in the super admin page
                _superAdminPage.RefreshGuardList();


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
