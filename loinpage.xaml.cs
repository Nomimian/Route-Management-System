using System;
using System.Collections.Generic;
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
using Microsoft.EntityFrameworkCore;

namespace Project_one_EAD
{
    public partial class loinpage : Page
    {
        private readonly Project1Context _context;

        public loinpage()
        {
            InitializeComponent();

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Project1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            var optionsBuilder = new DbContextOptionsBuilder<Project1Context>();
            optionsBuilder.UseSqlServer(connectionString);

            _context = new Project1Context(optionsBuilder.Options);
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;

            // Check if the username and password match in the database
            var user = _context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                // If user is found, login is successful
                lblMessage.Text = "Login Successful!";
                lblMessage.Foreground = Brushes.Green;
                // Change color to green or any other color
                //  SuperAdmin superAdminPage = new SuperAdmin();
                //   NavigationService.Navigate(superAdminPage);


                if (user.Role == 0)
                {
                    // Super Admin
                    SuperAdmin superAdminPage = new SuperAdmin();
                    NavigationService.Navigate(superAdminPage);
                }
                else if (user.Role == 1)
                {
                    // Admin
                    Admin adminPage = new Admin(_context); // Pass the Project1Context object to the Admin constructor
                    NavigationService.Navigate(adminPage);
                }
                else if (user.Role == 2)
                {
                    
                    guardpage admnPage = new guardpage(_context); // Pass the Project1Context object to the Admin constructor
                    NavigationService.Navigate(admnPage);
                }
            }
            else
            {
                // If user is not found, display error message
                lblMessage.Text = "Invalid username or password";
                lblMessage.Foreground = Brushes.Red; // Change color to red or any other color
            }
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            // Get the parent window of the page
            Window parentWindow = Window.GetWindow(this);

            // Close the parent window
            if (parentWindow != null)
            {
                parentWindow.Close();
            }
        }
    }
}