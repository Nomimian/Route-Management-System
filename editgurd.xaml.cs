using System;
using System.Collections.Generic;
using System.Data;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_one_EAD
{
    /// <summary>
    /// Interaction logic for editgurd.xaml
    /// </summary>
    public partial class editgurd : Page
    {
        
            private readonly Admin _adminPage;
            private readonly User _guardToUpdate;

            public editgurd(Admin adminPage, User guardToUpdate)
            {
                InitializeComponent();
                _adminPage = adminPage;
                _guardToUpdate = guardToUpdate;

                // Populate TextBoxes with current guard details
                username.Text = _guardToUpdate.Username;
                password.Password = _guardToUpdate.Password;
            role.Text = _guardToUpdate.Role.ToString(); // Ensure Role is converted to string if it's not already
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
                    // Update guard details
                    _guardToUpdate.Username = username.Text;
                    _guardToUpdate.Password = password.Password;

                    // Update guard in the database
                    _adminPage._dbContext.SaveChanges();

                    // Inform the user that the guard has been updated successfully
                    MessageBox.Show("Guard updated successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                    // Refresh guard list in AdminPage
                    _adminPage.RefreshGuardList();

                    // Navigate back to the previous page
                    NavigationService?.GoBack();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        private void role_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
    }