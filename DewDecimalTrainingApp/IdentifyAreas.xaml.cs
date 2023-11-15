using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace DewDecimalTrainingApp
{
    public partial class IdentifyAreas : Window
    {
        // Dictionary to store the original call numbers and descriptions.
        private Dictionary<string, string> originalCallNumberDescriptions = new Dictionary<string, string>();

        // Dictionary to store shuffled call numbers and descriptions.
        private Dictionary<string, string> shuffledCallNumberDescriptions = new Dictionary<string, string>();

        // Variables to keep track of the user's score and maximum possible score.
        private int score = 0;
        private int maxScore = 0;

        public IdentifyAreas()
        {
            InitializeComponent();
            // Initialize dictionaries and populate the list boxes.
            PopulateDictionaries();
            PopulateListBoxes();
        }

        // Method to populate the original dictionary with call numbers and descriptions.
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

            // Shuffle the call numbers and descriptions to create a new dictionary.
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

        // Method to populate the list boxes with new questions.
        private bool isDescriptionToCallNumber = true; // A flag to track the type of question

        private void PopulateListBoxes()
        {
            // Clear previous items in the ListBoxes.
            lstbCallNumber.Items.Clear();
            lstbCallDescriptions.Items.Clear();

            if (isDescriptionToCallNumber)
            {
                // Get four random descriptions and their corresponding call numbers for the first column.
                List<string> selectedDescriptions = shuffledCallNumberDescriptions.Keys.Take(4).ToList();
                List<string> selectedCallNumbers = selectedDescriptions.Select(description => shuffledCallNumberDescriptions[description]).ToList();

                // Get seven random call numbers for the second column (include the correct answers).
                List<string> allCallNumbers = originalCallNumberDescriptions.Keys.ToList();
                ShuffleList(allCallNumbers);

                // Exclude correct answers and select three distinct wrong answers.
                var correctAnswers = selectedDescriptions.Select(description => shuffledCallNumberDescriptions[description]);
                var wrongAnswers = allCallNumbers.Except(correctAnswers).Distinct().Take(3).ToList();

                // Merge correct and wrong answers to create the list of selected answers.
                var selectedAnswers = correctAnswers.Concat(wrongAnswers).ToList();
                ShuffleList(selectedAnswers); // Shuffle the answers.

                // Add a few additional wrong answers to reach a total of seven answers.
                while (selectedAnswers.Count < 7)
                {
                    var extraWrongAnswer = allCallNumbers.Except(correctAnswers).Except(wrongAnswers).FirstOrDefault();
                    if (extraWrongAnswer != null)
                    {
                        selectedAnswers.Add(extraWrongAnswer);
                    }
                }

                ShuffleList(selectedAnswers); // Reshuffle all answers.

                // Populate the ListBoxes.
                foreach (var description in selectedDescriptions)
                {
                    lstbCallDescriptions.Items.Add(description);
                }

                foreach (var callNumber in selectedAnswers)
                {
                    lstbCallNumber.Items.Add(callNumber);
                }
            }
            else
            {
                // Get four random call numbers and their descriptions for the first column.
                List<string> selectedCallNumbers = shuffledCallNumberDescriptions.Keys.Take(4).ToList();
                List<string> selectedDescriptions = selectedCallNumbers.Select(key => shuffledCallNumberDescriptions[key]).ToList();

                // Get seven random descriptions for the second column (include the correct answers).
                List<string> allDescriptions = originalCallNumberDescriptions.Values.ToList();
                ShuffleList(allDescriptions);

                // Exclude correct answers and select three distinct wrong answers.
                var correctAnswers = selectedCallNumbers.Select(callNumber => originalCallNumberDescriptions[callNumber]);
                var wrongAnswers = allDescriptions.Except(correctAnswers).Distinct().Take(3).ToList();

                // Merge correct and wrong answers to create the list of selected answers.
                var selectedAnswers = correctAnswers.Concat(wrongAnswers).ToList();
                ShuffleList(selectedAnswers); // Shuffle the answers.

                // Add a few additional wrong answers to reach a total of seven answers.
                while (selectedAnswers.Count < 7)
                {
                    var extraWrongAnswer = allDescriptions.Except(correctAnswers).Except(wrongAnswers).FirstOrDefault();
                    if (extraWrongAnswer != null)
                    {
                        selectedAnswers.Add(extraWrongAnswer);
                    }
                }

                ShuffleList(selectedAnswers); // Reshuffle all answers.

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

            // Toggle the flag for the next question.
            isDescriptionToCallNumber = !isDescriptionToCallNumber;
        }


        // Event handler for the Submit button.
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            if (lstbCallNumber.SelectedItems.Count != 1 || lstbCallDescriptions.SelectedItems.Count != 1)
            {
                MessageBox.Show("Please select one item in each column to match.");
                return;
            }

            string selectedCallNumber = lstbCallNumber.SelectedItem.ToString();
            string selectedDescription = lstbCallDescriptions.SelectedItem.ToString();

            // Check if the selected items exist in the dictionary.
            if (originalCallNumberDescriptions.ContainsKey(selectedCallNumber))
            {
                string correctDescription = originalCallNumberDescriptions[selectedCallNumber];

                if (selectedDescription == correctDescription)
                {
                    score++;
                }
                maxScore++;
                PopulateListBoxes(); // Load the next question.
            }
            else
            {
                // Handle the case where the selected call number is not found in the dictionary.
                maxScore++;
                MessageBox.Show("Answer is wrong.");
                PopulateListBoxes(); // Load the next question.
            }
            tbScore.Text = $"Score: {score}/{maxScore}";
        }


        // Event handler for the Generate New Numbers button.
        private void GenerateNewNumbersButton_Click(object sender, RoutedEventArgs e)
        {
            // Clear previous items in both ListBoxes.
            lstbCallNumber.Items.Clear();
            lstbCallDescriptions.Items.Clear();

            PopulateListBoxes(); // Load new shuffled call numbers and descriptions.
            lstbCallNumber.SelectedIndex = -1; // Deselect any previous selections.
            lstbCallDescriptions.SelectedIndex = -1;
        }

        // Event handler for the Finish button.
        private void FinishButton_Click(object sender, RoutedEventArgs e)
        {
            // Store the user's score.
            int userScore = score;

            // Set the DialogResult and close the window.
            this.Close();
        }
    }
}
