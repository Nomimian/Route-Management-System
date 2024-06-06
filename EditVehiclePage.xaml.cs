using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Microsoft.EntityFrameworkCore;

namespace Project_one_EAD
{
    public partial class EditVehiclePage : Page
    {
        public Admin AdminPage { get; set; }
        public Vehicle SelectedVehicle { get; set; }

        public EditVehiclePage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (SelectedVehicle != null)
            {
                // Populate the textboxes and combobox with the data of the selected vehicle
                ownerTextBox.Text = SelectedVehicle.OwnerName;
                vehicleNameTextBox.Text = SelectedVehicle.VehicleName;
                vehicleTypeComboBox.Text = SelectedVehicle.VehicleType;
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Update the selected vehicle with the new data
                SelectedVehicle.OwnerName = ownerTextBox.Text;
                SelectedVehicle.VehicleName = vehicleNameTextBox.Text;
                SelectedVehicle.VehicleType = vehicleTypeComboBox.Text;

                // Save changes to the database
                AdminPage._dbContext.SaveChanges();

                // Inform the user that the vehicle has been updated successfully
                MessageBox.Show("Vehicle updated successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                // Refresh vehicle list in AdminPage
                AdminPage.RefreshVehicleList();

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
    }
}
