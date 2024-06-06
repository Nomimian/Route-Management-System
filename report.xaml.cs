using Microsoft.EntityFrameworkCore;
using Project_one_EAD;
using System;
using System.Collections.Generic;
using System.IO; // Added for file operations
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace p2 // Correct namespace
{
    public partial class report : Page
    {
        private readonly Project1Context _dbContext;

        public report(Project1Context dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private void GenerateReportButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected start and end dates from the DatePicker controls
            DateTime startDate = startDatePicker.SelectedDate ?? DateTime.MinValue;
            DateTime endDate = endDatePicker.SelectedDate ?? DateTime.MaxValue;

            try
            {
                // Retrieve reports data based on the date range
                var reports = _dbContext.CheckIns
                    .Where(ci => ci.CheckInTime >= startDate && ci.CheckInTime <= endDate)
                    .ToList();

                // Bind the filtered reports data to the DataGrid
                mygrid.ItemsSource = reports;

                // Generate report text
                string reportText = "CheckInID, VehicleID, CheckInTime, CheckOutTime\n";
                foreach (var report in reports)
                {
                    reportText += $"{report.CheckInID}, {report.VehicleID}, {report.CheckInTime}, {report.CheckOutTime}\n";
                }

                // Save report to a .txt file
                // Save report to a .txt file on the desktop
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string fileName = Path.Combine(desktopPath, "report.txt");
                File.WriteAllText(fileName, reportText);


                MessageBox.Show($"Report generated successfully and saved as {fileName}", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void FilterButton_Click(object sender, RoutedEventArgs e)
        {
            // Call the GenerateReportButton_Click event handler to apply filtering
            GenerateReportButton_Click(sender, e);
        }
    }
}
