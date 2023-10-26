using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace DewDecimalTrainingApp
{
    public partial class IdentifyAreas : Window
    {
        private Dictionary<string, string> callNumberDescriptions = new Dictionary<string, string>();
        private List<string> shuffledKeys = new List<string>();

        public IdentifyAreas()
        {
            InitializeComponent();
            PopulateDictionary();
            ShuffleDictionaryKeys();
            GenerateMatchingQuestions();
        }

        public void PopulateDictionary()
        {
            // Populate the dictionary with call numbers and descriptions.
            callNumberDescriptions.Add("A. 000", "1. Computer Science, Information, & General Works");
            callNumberDescriptions.Add("B. 100", "2. Philosophy & Psychology");
            callNumberDescriptions.Add("C. 200", "3. Religion");
            callNumberDescriptions.Add("D. 300", "4. Social Sciences");
            callNumberDescriptions.Add("E. 400", "5. Language");
            callNumberDescriptions.Add("F. 500", "6. Science");
            callNumberDescriptions.Add("G. 600", "7. Technology");
            callNumberDescriptions.Add("H. 700", "8. Arts & Recreation");
            callNumberDescriptions.Add("I. 800", "9. Literature");
            callNumberDescriptions.Add("J. 900", "10. History & Geography");
        }

        private void ShuffleDictionaryKeys()
        {
            shuffledKeys = callNumberDescriptions.Keys.ToList();
            shuffledKeys = shuffledKeys.OrderBy(a => Guid.NewGuid()).ToList();
        }

        private void GenerateMatchingQuestions()
        {
            foreach (var key in shuffledKeys)
            {
                AddMatchingQuestion(key, callNumberDescriptions[key]);
            }
        }

        private void AddMatchingQuestion(string callNumber, string description)
        {
            var questionItem = new StackPanel
            {
                Orientation = Orientation.Horizontal,
                Margin = new Thickness(10),
            };

            var callNumberTextBlock = new TextBlock
            {
                Text = callNumber,
                FontSize = 20,
                FontWeight = FontWeights.Bold,
                Margin = new Thickness(0, 0, 10, 0),
            };

            var descriptionTextBlock = new TextBlock
            {
                Text = description,
                FontSize = 20,
            };

            questionItem.Children.Add(callNumberTextBlock);
            questionItem.Children.Add(descriptionTextBlock);

            // Adds the question to a container 
            matchingQuestionsStackPanel.Children.Add(questionItem);
        }

        private void CheckAnswer_Click(object sender, RoutedEventArgs e)
        {
            bool allAnswersCorrect = true; // Assume all answers are correct initially

            foreach (var key in shuffledKeys)
            {
                // Construct the expected answer (e.g., "1. Computer Science, Information, & General Works")
                string expectedAnswer = $"{callNumberDescriptions[key]}";

                // Get the user's input from the TextBox corresponding to the shuffled key
                TextBox textBox = FindTextBoxByKey(key);
                string userAnswer = textBox.Text;

                // Check if the user's answer matches the expected answer
                if (userAnswer != expectedAnswer)
                {
                    allAnswersCorrect = false;
                    break; // At least one answer is incorrect; no need to check further
                }
            }

            if (allAnswersCorrect)
            {
                MessageBox.Show("All answers are correct!");
            }
            else
            {
                MessageBox.Show("At least one answer is incorrect. Please try again.");
            }
        }

        private TextBox FindTextBoxByKey(string key)
        {
            // This function finds the TextBox corresponding to the provided key.
            // For example, if key is "A. 000", it finds the TextBox with x:Name="txtbAnswerA".

            string textBoxName = "txtbAnswer" + key.Substring(0, 1); // Assuming the keys are single characters (A, B, C, etc.)
            return (TextBox)FindName(textBoxName);
        }


    }
}
