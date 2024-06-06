using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Project_one_EAD
{
    public partial class register_vehicle : Page
    {
        /// <summary>
        /// Interaction logic for RegisterVehicle.xaml
        /// </summary>
        
            private readonly Project1Context _context;
            private readonly Admin _adminPage;


            public register_vehicle(Project1Context context, Admin adminPage)
            {
                InitializeComponent();
            _context = context;
            _adminPage = adminPage;

            }
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Check if the vehicle number already exists in the database
                if (DoesVehicleNumberExist(vehicleNumberTextBox.Text))
                {
                    MessageBox.Show("A vehicle with the same number already exists!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                // Check if the vehicle type is selected
                if (string.IsNullOrEmpty(vehicleTypeComboBox.Text))
                {
                    MessageBox.Show("Please select a vehicle type!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                // Create a new Vehicle object with the provided details
                var newVehicle = new Vehicle
                {
                    OwnerName = ownerTextBox.Text,
                    VehicleName = vehicleNameTextBox.Text,
                    VehicleType = vehicleTypeComboBox.Text
                };

                // Add the new vehicle to the context and save changes
                _context.Vehicles.Add(newVehicle);
                _context.SaveChanges();

                // Inform the user that the vehicle has been registered successfully
                MessageBox.Show("Vehicle registered successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                // Clear the input fields
                ownerTextBox.Clear();
                vehicleNameTextBox.Clear();
                vehicleNumberTextBox.Clear();
                vehicleTypeComboBox.SelectedIndex = -1; // Reset the ComboBox selection

                // Refresh vehicle list in AdminPage
                _adminPage.RefreshVehicleList();

                // Navigate back to the Admin page
                if (NavigationService.CanGoBack)
                {
                    NavigationService.GoBack();
                }
                else
                {
                    MessageBox.Show("Cannot navigate back to the Admin page.", "Navigation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool DoesOwnerExist(string ownerName)
        {
            // Check if the owner name exists in the database
            return _context.Vehicles.Any(v => v.OwnerName == ownerName);
        }

        private bool DoesVehicleNumberExist(string vehicleNumber)
            {
                // Check if the vehicle number exists in the database
                return _context.Vehicles.Any(v => v.VehicleID == int.Parse(vehicleNumber));
            }
        }
    }