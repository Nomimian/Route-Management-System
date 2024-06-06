using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Project_one_EAD
{
    //public partial class guardpage : Page
    //{
    //    private readonly Project1Context db;

    //    public guardpage(Project1Context dbcontext)
    //    {
    //        InitializeComponent();
    //        var options = new DbContextOptionsBuilder<Project1Context>()
    //            .UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Project1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
    //            .Options;
    //        db = dbcontext;
    //        LoadVehicleNoPlates();
    //        LoadEntries();
    //    }

    //    private void LoadVehicleNoPlates()
    //    {
    //        try
    //        {
    //            var vehiclePlates = db.Vehicles.Select(v => v.VehicleID.ToString()).ToList();
    //            cmbVehicleNoPlate.ItemsSource = vehiclePlates;
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show($"Error loading vehicle plates: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
    //        }
    //    }


    //    private void InBtn_Click(object sender, RoutedEventArgs e)
    //    {
    //        if (cmbVehicleNoPlate.SelectedItem != null)
    //        {
    //            // Ensure selectedPlate is not null and is of type string
    //            if (cmbVehicleNoPlate.SelectedItem is string selectedPlate)
    //            {
    //                // Convert selectedPlate to integer for comparison
    //                if (int.TryParse(selectedPlate, out int selectedVehicleID))
    //                {
    //                    // Find the vehicle with the matching ID
    //                    var selectedVehicle = db.Vehicles.FirstOrDefault(v => v.VehicleID == selectedVehicleID);
    //                    if (selectedVehicle != null)
    //                    {
    //                        // Check if the owner exists
    //                        if (DoesOwnerExist(selectedVehicle.OwnerName))
    //                        {
    //                            MessageBoxResult result = MessageBox.Show($"Vehicle Name: {selectedVehicle.VehicleName}\n" +
    //                                                                        $"Vehicle Type: {selectedVehicle.VehicleType}\n" +
    //                                                                        $"Vehicle Plate: {selectedVehicle.VehicleID}\n" +
    //                                                                        $"Vehicle Owner: {selectedVehicle.OwnerName}\n\n" +
    //                                                                        $"Confirm vehicle entry?", "Confirm Entry", MessageBoxButton.OKCancel, MessageBoxImage.Information);

    //                            if (result == MessageBoxResult.OK)
    //                            {
    //                                db.CheckIns.Add(new CheckIn
    //                                {
    //                                    VehicleID = selectedVehicle.VehicleID,
    //                                    CheckInTime = DateTime.Now
    //                                });
    //                                db.SaveChanges();

    //                                LoadEntries();
    //                            }
    //                        }
    //                        else
    //                        {
    //                            MessageBox.Show("Owner does not exist.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
    //                        }
    //                    }
    //                    else
    //                    {
    //                        MessageBox.Show("Selected vehicle not found.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
    //                    }
    //                }
    //                else
    //                {
    //                    MessageBox.Show("Invalid vehicle plate format.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
    //                }
    //            }
    //            else
    //            {
    //                MessageBox.Show("Invalid selection.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
    //            }
    //        }
    //        else
    //        {
    //            MessageBox.Show("Please select a vehicle plate.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
    //        }
    //    }


    //    private void OutBtn_Click(object sender, RoutedEventArgs e)
    //    {
    //        if (cmbVehicleNoPlate.SelectedItem != null)
    //        {
    //            // Ensure selectedPlate is not null and is of type string
    //            if (cmbVehicleNoPlate.SelectedItem is string selectedPlate)
    //            {
    //                // Find the entry with the matching vehicle plate
    //                var selectedEntry = db.CheckIns.FirstOrDefault(ci => ci.Vehicle.VehicleID.ToString() == selectedPlate && ci.CheckOutTime == null);

    //                if (selectedEntry != null)
    //                {
    //                    selectedEntry.CheckOutTime = DateTime.Now;
    //                    db.SaveChanges();
    //                    LoadEntries();
    //                }
    //                else
    //                {
    //                    MessageBox.Show("No entry found for the selected vehicle plate or the vehicle has already exited.");
    //                }
    //            }
    //            else
    //            {
    //                MessageBox.Show("Invalid selection.");
    //            }
    //        }
    //        else
    //        {
    //            MessageBox.Show("Please select a vehicle plate.");
    //        }
    //    }

    //    private bool DoesOwnerExist(string ownerName)
    //    {
    //        // Check if the owner name exists in the database
    //        return db.Vehicles.Any(v => v.OwnerName == ownerName);
    //    }

    //    private void mygrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
    //    {
    //        if (mygrid.SelectedItem != null)
    //        {
    //            CheckIn selectedEntry = mygrid.SelectedItem as CheckIn;
    //            Vehicle selectedVehicle = db.Vehicles.FirstOrDefault(v => v.VehicleID == selectedEntry.VehicleID);

    //            if (selectedVehicle != null)
    //            {
    //                MessageBox.Show($"Vehicle Name: {selectedVehicle.VehicleName}\n" +
    //                                $"Vehicle Type: {selectedVehicle.VehicleType}\n" +
    //                                $"Vehicle Plate: {selectedVehicle.VehicleID}\n" +
    //                                $"Vehicle Owner: {selectedVehicle.OwnerName}");
    //            }
    //            else
    //            {
    //                MessageBox.Show("Selected vehicle information not found.");
    //            }
    //        }
    //    }

    //    private void LoadEntries()
    //    {
    //        mygrid.ItemsSource = db.CheckIns.ToList();
    //    }
    //}

    //public partial class guardpage : Page
    //{
    //    private readonly Project1Context dbContext;

    //    public guardpage(Project1Context context)
    //    {
    //        InitializeComponent();
    //        dbContext = context;
    //        LoadVehicleIDs();
    //    }

    //    private void LoadVehicleIDs()
    //    {
    //        try
    //        {
    //            var vehicleIDs = dbContext.Vehicles.Select(v => v.VehicleID).ToList();
    //            foreach (var vehicleID in vehicleIDs)
    //            {
    //                cmbVehicleNoPlate.Items.Add(vehicleID);
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show("Error loading Vehicle IDs: " + ex.Message);
    //        }
    //    }

    //    private void InBtn_Click(object sender, RoutedEventArgs e)
    //    {
    //        try
    //        {
    //            if (cmbVehicleNoPlate.SelectedItem == null)
    //            {
    //                MessageBox.Show("Please select a vehicle ID.");
    //                return;
    //            }

    //            int vehicleID = (int)cmbVehicleNoPlate.SelectedItem;
    //            DateTime currentDateTime = DateTime.Now;

    //            CheckIn checkIn = new CheckIn
    //            {
    //                UserID = 1, // Assuming there's a User ID associated with the check-in.
    //                VehicleID = vehicleID,
    //                CheckInTime = currentDateTime
    //            };

    //            dbContext.CheckIns.Add(checkIn);
    //            dbContext.SaveChanges();

    //            MessageBox.Show("Check-in recorded successfully.");
    //            // Refresh DataGrid
    //            LoadCheckIns();
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show("Error during check-in: " + ex.Message);
    //        }
    //    }

    //    private void LoadCheckIns()
    //    {
    //        try
    //        {
    //            var checkIns = dbContext.CheckIns.ToList();
    //            mygrid.ItemsSource = checkIns;
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show("Error loading Check-ins: " + ex.Message);
    //        }
    //    }

    //    private void OutBtn_Click(object sender, RoutedEventArgs e)
    //    {
    //        try
    //        {
    //            if (mygrid.SelectedItem == null)
    //            {
    //                MessageBox.Show("Please select a check-in record.");
    //                return;
    //            }

    //            CheckIn selectedCheckIn = (CheckIn)mygrid.SelectedItem;
    //            selectedCheckIn.CheckOutTime = DateTime.Now;

    //            dbContext.SaveChanges();

    //            MessageBox.Show("Check-out recorded successfully.");
    //            // Refresh DataGrid
    //            LoadCheckIns();
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show("Error during check-out: " + ex.Message);
    //        }
    //    }
    //}


    public partial class guardpage : Page
    {
        private readonly Project1Context dbContext;

        public guardpage(Project1Context context)
        {
            InitializeComponent();
            dbContext = context;
            LoadVehicleIDs();
            LoadCheckIns();
        }

        private void LoadVehicleIDs()
        {
            try
            {
                var vehicleIDs = dbContext.Vehicles.Select(v => v.VehicleID).ToList();
                foreach (var vehicleID in vehicleIDs)
                {
                    cmbVehicleNoPlate.Items.Add(vehicleID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Vehicle IDs: " + ex.Message);
            }
        }

        private void InBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (cmbVehicleNoPlate.SelectedItem == null)
                {
                    MessageBox.Show("Please select a vehicle ID.");
                    return;
                }

                int vehicleID = (int)cmbVehicleNoPlate.SelectedItem;
                DateTime currentDateTime = DateTime.Now;

                CheckIn checkIn = new CheckIn
                {
                    UserID = 1, // Assuming there's a User ID associated with the check-in.
                    VehicleID = vehicleID,
                    CheckInTime = currentDateTime
                };

                dbContext.CheckIns.Add(checkIn);
                dbContext.SaveChanges();

                MessageBox.Show("Check-in recorded successfully.");
                // Refresh DataGrid
                LoadCheckIns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during check-in: " + ex.Message);
            }
        }

        private void LoadCheckIns()
        {
            try
            {
                var checkIns = dbContext.CheckIns.ToList();
                mygrid.ItemsSource = checkIns;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Check-ins: " + ex.Message);
            }
        }


        private void OutBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (mygrid.SelectedItem == null)
                {
                    MessageBox.Show("Please select a check-in record.");
                    return;
                }

                CheckIn selectedCheckIn = (CheckIn)mygrid.SelectedItem;
                selectedCheckIn.CheckOutTime = DateTime.Now; // Set the check-out time

                dbContext.SaveChanges(); // Save changes to the database

                MessageBox.Show("Check-out recorded successfully.");
                // Refresh DataGrid
                LoadCheckIns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during check-out: " + ex.Message);
            }
        }

        private void mygrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }


        //    private void OutBtn_Click(object sender, RoutedEventArgs e)
        //    {
        //        try
        //        {
        //            if (cmbVehicleNoPlate.SelectedItem == null)
        //            {
        //                MessageBox.Show("Please select a vehicle ID.");
        //                return;
        //            }

        //            int vehicleID = (int)cmbVehicleNoPlate.SelectedItem;
        //            var checkInRecord = dbContext.CheckIns.FirstOrDefault(c => c.VehicleID == vehicleID && c.CheckOutTime == null);

        //            if (checkInRecord == null)
        //            {
        //                MessageBox.Show("There is no active check-in record for this vehicle ID.");
        //                return;
        //            }

        //            checkInRecord.CheckOutTime = DateTime.Now;
        //            dbContext.SaveChanges();

        //            MessageBox.Show("Check-out recorded successfully.");
        //            // Refresh DataGrid
        //            LoadCheckIns();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error during check-out: " + ex.Message);
        //        }
        //    }

        //}



    }
