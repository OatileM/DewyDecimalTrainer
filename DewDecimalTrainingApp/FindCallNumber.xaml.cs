using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using DewDecimalTrainingApp.Data;

namespace DewDecimalTrainingApp
{
    public partial class FindCallNumber : Window
    {
        private string filePath;
        private DeweyTreeStructure deweyTree;
        private List<DeweyTreeNode> options;

        public FindCallNumber()
        {
            InitializeComponent();
            LoadDeweyData();
            LoadQuestion();
        }

        private void LoadDeweyData()
        {
            try
            {
                filePath = @"D:\Visual Studio\School Projects\PROG7312\DewDecimalTrainingApp\DewDecimalTrainingApp\Data\dewey_data.json";
                string jsonData = System.IO.File.ReadAllText(filePath);
                deweyTree = JsonSerializer.Deserialize<DeweyTreeStructure>(jsonData);

                MessageBox.Show("JSON Data extracted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Dewey Decimal data: {ex.Message}");
            }
        }

        private void LoadQuestion()
        {
            // Get all third-level nodes
            List<DeweyTreeNode> thirdLevelNodes = deweyTree.GetThirdLevelNodes(deweyTree.Root);

            // Checks if there are third-level nodes available
            if (thirdLevelNodes.Count > 0)
            {
                // Randomly select a third-level node
                Random random = new Random();
                DeweyTreeNode randomNode = thirdLevelNodes[random.Next(thirdLevelNodes.Count)];

                // Displays the description in the TextBlock
                txtbRandomCallDescriptions.Text = randomNode.Name;

                // Generates options
                options = GenerateOptions(randomNode);

                // Display options on buttons
                btnOption1.Content = options[0].Name;
                btnOption2.Content = options[1].Name;
                btnOption3.Content = options[2].Name;
                btnOption4.Content = options[3].Name;
            }
            else
            {
                // Handles the case where there are no third-level nodes
                MessageBox.Show("No third-level nodes found in the Dewey Decimal tree.");
            }
        }


        private List<DeweyTreeNode> GenerateOptions(DeweyTreeNode correctOption)
        {
            List<DeweyTreeNode> allOptions = deweyTree.GetTopLevelNodes().ToList();
            allOptions.Remove(correctOption);

            // Randomly select three incorrect options
            Random random = new Random();
            List<DeweyTreeNode> incorrectOptions = allOptions.OrderBy(x => random.Next()).Take(3).ToList();

            // Add the correct option
            incorrectOptions.Add(correctOption);

            // Shuffle the options
            incorrectOptions = incorrectOptions.OrderBy(x => random.Next()).ToList();

            return incorrectOptions;
        }

        private void CheckAnswer(DeweyTreeNode selectedOption)
        {
            if (selectedOption == options[0])
            {
                MessageBox.Show("Correct answer! Loading next question.");
                LoadQuestion();
            }
            else
            {
                MessageBox.Show("Wrong answer! Loading next question.");
                LoadQuestion();
            }
        }

        private void btnOption_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            string selectedOptionName = clickedButton?.Content.ToString();

            // Find the corresponding DeweyTreeNode for the selected option
            DeweyTreeNode selectedOption = options.Find(option => option.Name == selectedOptionName);

            if (selectedOption != null)
            {
                CheckAnswer(selectedOption);
            }
        }
    }
}
