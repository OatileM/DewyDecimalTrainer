using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows;
using DewDecimalTrainingApp.Data;



namespace DewDecimalTrainingApp
{
    /// <summary>
    /// Interaction logic for FindCallNumber.xaml
    /// </summary>
    public partial class FindCallNumber : Window
    {
        private Dictionary<string, DeweyCategory> deweyCategories;
        string filePath;

        public FindCallNumber()
        {
            InitializeComponent();
            LoadDeweyData(); // Load Dewey Decimal classification data when the window is initialized.
        }

        // Method to load Dewey Decimal classification data from a file.
        private void LoadDeweyData()
        {
            try
            {
                // Provide the full path to the file containing Dewey Decimal classification data.
                string filePath = @"D:\Visual Studio\School Projects\PROG7312\DewDecimalTrainingApp\DewDecimalTrainingApp\Data\dewey_data.json";

                string jsonData = File.ReadAllText(filePath);

                // Deserialize the JSON data into a DeweyTreeStructure object
                DeweyTreeStructure deweyTree = JsonSerializer.Deserialize<DeweyTreeStructure>(jsonData);

                // Now, deweyTree contains the Dewey Decimal classification data in a tree structure.
                // You can access the tree structure using deweyTree.Root and perform operations as needed.

                // For testing and debugging, you can print the tree structure
                deweyTree.PrintTree(deweyTree.Root);

                MessageBox.Show("JSON Data extracted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Dewey Decimal data: {ex.Message}");
            }
        }



        // ... (other methods and event handlers)

        // Example of how you can use deweyCategories in your methods.
        private void SomeMethod()
        {
            if (deweyCategories != null)
            {
                // Access the classification data, for example:
                // DeweyCategory category = deweyCategories["100"];
            }
            else
            {
                MessageBox.Show("Dewey Decimal data not loaded.");
            }
        }
    }
}
