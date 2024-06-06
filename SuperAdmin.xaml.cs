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
    /// Interaction logic for SuperAdminPage.xaml
    /// </summary>
    public partial class SuperAdmin : Page
    {
        private readonly Project1Context _dbContext;

        public SuperAdmin()
        {
            InitializeComponent();
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Project1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            var optionsBuilder = new DbContextOptionsBuilder<Project1Context>();
            optionsBuilder.UseSqlServer(connectionString);
            _dbContext = new Project1Context(optionsBuilder.Options); RefreshUserList();
        }
        public void RefreshUserList()
        {
            // Clear existing items
            UserListDataGrid.Items.Clear();

            // Retrieve users from the database
            var users = _dbContext.Users.ToList();

            // Add users to the DataGrid
            foreach (var user in users)
            {
                UserListDataGrid.Items.Add(user);
            }
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Add_Admin(this));
        }

        private void DeleteUser_Click(object sender, RoutedEventArgs e)
        {

            // Ensure an item is selected
            if (UserListDataGrid.SelectedItem != null)
            {
                // Get the selected user
                var selectedUser = (User)UserListDataGrid.SelectedItem;

                // Remove the user from the database
                _dbContext.Users.Remove(selectedUser);
                _dbContext.SaveChanges();

                // Refresh the user list
                RefreshUserList();
            }
            else
            {
                MessageBox.Show("Please select a user to delete.", "Delete User", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void EditUser_Click(object sender, RoutedEventArgs e)
        {
            // Ensure an item is selected
            if (UserListDataGrid.SelectedItem != null)
            {
                // Get the selected user
                var selectedUser = (User)UserListDataGrid.SelectedItem;

                // Navigate to the EditUserPage and pass the selected user as a parameter
                Edit_Admin editAdminPage = new Edit_Admin(this, selectedUser);
                NavigationService?.Navigate(editAdminPage);
            }
            else
            {
                MessageBox.Show("Please select a user to edit.", "Edit User", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Button_Click_exit(object sender, RoutedEventArgs e)
        {

            // Exiting application. 
            System.Environment.Exit(0);
        }

        private void UserListDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void UserListDataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}



