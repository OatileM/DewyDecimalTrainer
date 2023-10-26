using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace DewDecimalTrainingApp
{
    public partial class IdentifyAreas : Window
    {
        private Dictionary<string, string> originalCallNumberDescriptions = new Dictionary<string, string>();
        private Dictionary<string, string> shuffledCallNumberDescriptions = new Dictionary<string, string>();
        private int score = 0;
        private int maxScore = 0;

        public IdentifyAreas()
        {
            InitializeComponent();
            PopulateDictionaries();
            PopulateListBoxes();
        }

        public void PopulateDictionaries()
        {
            // Populate the original dictionary with call numbers and descriptions.
            originalCallNumberDescriptions.Add("000", "Computer Science, Information, & General Works");
            originalCallNumberDescriptions.Add("100", "Philosophy & Psychology");
            originalCallNumberDescriptions.Add("200", "Religion");
            originalCallNumberDescriptions.Add("300", "Social Sciences");
            originalCallNumberDescriptions.Add("400", "Language");
            originalCallNumberDescriptions.Add("500", "Science");
            originalCallNumberDescriptions.Add("600", "Technology");
            originalCallNumberDescriptions.Add("700", "Arts & Recreation");
            originalCallNumberDescriptions.Add("800", "Literature");
            originalCallNumberDescriptions.Add("900", "History & Geography");

            // Shuffle the call numbers and descriptions.
            List<string> shuffledKeys = originalCallNumberDescriptions.Keys.ToList();
            List<string> shuffledDescriptions = originalCallNumberDescriptions.Values.ToList();
            ShuffleList(shuffledKeys);
            ShuffleList(shuffledDescriptions);

            // Populate the shuffled dictionary.
            for (int i = 0; i < shuffledKeys.Count; i++)
            {
                shuffledCallNumberDescriptions.Add(shuffledKeys[i], shuffledDescriptions[i]);
            }
        }

        // Helper method to shuffle a list.
        private void ShuffleList<T>(List<T> list)
        {
            Random random = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        private void PopulateListBoxes()
        {
            // Clear previous items in the ListBoxes.
            lstbCallNumber.Items.Clear();
            lstbCallDescriptions.Items.Clear();

            // Get four random call numbers and their descriptions for the first column.
            List<string> selectedCallNumbers = shuffledCallNumberDescriptions.Keys.Take(4).ToList();
            List<string> selectedDescriptions = selectedCallNumbers.Select(key => shuffledCallNumberDescriptions[key]).ToList();

            // Get seven random descriptions (including the correct answers) for the second column.
            List<string> allDescriptions = originalCallNumberDescriptions.Values.ToList();
            ShuffleList(allDescriptions);

            // Exclude correct answers and select three distinct wrong answers.
            var correctAnswers = selectedCallNumbers.Select(callNumber => originalCallNumberDescriptions[callNumber]);
            var wrongAnswers = allDescriptions.Except(correctAnswers).Distinct().Take(3).ToList();

            // Merge correct and wrong answers to create the list of selected answers.
            var selectedAnswers = correctAnswers.Concat(wrongAnswers).ToList();
            ShuffleList(selectedAnswers); // Shuffle the answers.

            // Populate the ListBoxes.
            foreach (var callNumber in selectedCallNumbers)
            {
                lstbCallNumber.Items.Add(callNumber);
            }

            foreach (var description in selectedAnswers)
            {
                lstbCallDescriptions.Items.Add(description);
            }
        }
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            if (lstbCallNumber.SelectedItems.Count != 1 || lstbCallDescriptions.SelectedItems.Count != 1)
            {
                MessageBox.Show("Please select one item in each column to match.");
                return;
            }

            string selectedCallNumber = lstbCallNumber.SelectedItem.ToString();
            string selectedDescription = lstbCallDescriptions.SelectedItem.ToString();

            // Retrieve the correct description for the selected call number.
            string correctDescription = originalCallNumberDescriptions[selectedCallNumber];

            if (selectedDescription == correctDescription)
            {
                score++;
            }

            maxScore++;
            tbScore.Text = $"Score: {score}/{maxScore}";

            PopulateListBoxes(); // Load the next question.
        }
    }
}
