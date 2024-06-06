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
    /// Interaction logic for AdminPage.xaml
    /// </summary>
    public partial class Admin : Page
    {
        public readonly Project1Context _dbContext;

        public Admin(Project1Context dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;

            RefreshGuardList();
            RefreshVehicleList(); // Call method to load registered vehicle data
        }

        private void GuardListDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public void RefreshGuardList()
        {
            // Clear existing items
            GuardListDataGrid.Items.Clear();

            // Retrieve guards from the database with role 2 using LINQ query
            var guards = _dbContext.Users.Where(u => u.Role == 2).ToList();

            // Add guards to the DataGrid
            foreach (var guard in guards)
            {
                GuardListDataGrid.Items.Add(guard);
            }
        }

        private void AddGuard_Click(object sender, RoutedEventArgs e)
        {
             NavigationService?.Navigate(new Add_Gurd(this));
        }

        private void DeleteGuard_Click(object sender, RoutedEventArgs e)
        {
            // Ensure an item is selected
            if (GuardListDataGrid.SelectedItem != null)
            {
                try
                {
                    // Get the selected guard
                    var selectedGuard = (User)GuardListDataGrid.SelectedItem;

                    // Remove the guard from the database using LINQ
                    var guardToRemove = _dbContext.Users.FirstOrDefault(u => u.UserID == selectedGuard.UserID);
                    if (guardToRemove != null)
                    {
                        _dbContext.Users.Remove(guardToRemove);
                        _dbContext.SaveChanges();

                        // Refresh the guard list
                        RefreshGuardList();
                    }
                    else
                    {
                        MessageBox.Show("Guard not found in the database.", "Delete Guard", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a guard to delete.", "Delete Guard", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void RegisterVehicle_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the RegisterVehicle page
            NavigationService?.Navigate(new register_vehicle(_dbContext, this));
        }

        private void EditGuard_Click(object sender, RoutedEventArgs e)
        {
            // Ensure a guard is selected
            if (GuardListDataGrid.SelectedItem != null)
            {
                // Get the selected guard
                var selectedGuard = (User)GuardListDataGrid.SelectedItem;

               // Navigate to the EditGuardPage and pass the selected guard as a parameter
                NavigationService?.Navigate(new editgurd(this, selectedGuard));
            }
            else
            {
                MessageBox.Show("Please select a guard to edit.", "Edit Guard", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        public void RefreshVehicleList()
        {
            // Clear existing items
            VehicleDataGrid.Items.Clear();

            // Retrieve registered vehicles from the database
            var vehicles = _dbContext.Vehicles.ToList();

            // Add vehicles to the DataGrid
            foreach (var vehicle in vehicles)
            {
                VehicleDataGrid.Items.Add(vehicle);
            }
        }

        private void GenerateReport_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new p2.report(this._dbContext));
        }


        //private void GenerateReport_Click(object sender, RoutedEventArgs e)
        //{
        //    // Assuming you're navigating to the 'report' page
        //    NavigationService?.Navigate(new Uri("reportPage.xaml", UriKind.Relative));
        //}

        private void EditVehicle_Click(object sender, RoutedEventArgs e)
        {
            if (VehicleDataGrid.SelectedItem != null)
            {
                var selectedVehicle = (Vehicle)VehicleDataGrid.SelectedItem;
                var editVehiclePage = new EditVehiclePage();
                editVehiclePage.AdminPage = this;
                editVehiclePage.SelectedVehicle = selectedVehicle;
                NavigationService?.Navigate(editVehiclePage);
            }
            else
            {
                MessageBox.Show("Please select a vehicle to edit.", "Edit Vehicle", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }


        private void DeleteVehicle_Click(object sender, RoutedEventArgs e)
        {
            if (VehicleDataGrid.SelectedItem != null)
            {
                try
                {
                    var selectedVehicle = (Vehicle)VehicleDataGrid.SelectedItem;

                    // Delete the selected vehicle from the database
                    _dbContext.Vehicles.Remove(selectedVehicle);
                    _dbContext.SaveChanges();

                    // Refresh the vehicle list
                    RefreshVehicleList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a vehicle to delete.", "Delete Vehicle", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}