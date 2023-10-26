using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace DewDecimalTrainingApp
{
    public partial class ReplaceBook : Window
    {
        // Private fields to store user's order, call numbers, and correct order.
        private List<string> userOrder;
        private ObservableCollection<string> callNumbers;
        private List<string> correctOrder;
        private DispatcherTimer gameTimer; // Timer for game time
        private int timeRemaining = 120; // Initial time in seconds

        public ReplaceBook()
        {
            InitializeComponent();
            callNumbers = new ObservableCollection<string>();
            lstCallNumbers.ItemsSource = callNumbers;

            // Initialize and configure the game timer
            gameTimer = new DispatcherTimer();
            gameTimer.Interval = TimeSpan.FromSeconds(1);
            gameTimer.Tick += GameTimer_Tick;
        }

        // Event handler to start replacing books task.
        private void StartReplacingBooksTask(object sender, RoutedEventArgs e)
        {
            correctOrder = GenerateRandomCallNumbers(10);
            // Display the correct order initially.
            callNumbers.Clear();
            foreach (var callNumber in correctOrder)
            {
                callNumbers.Add(callNumber);
            }
        }

        // Generates random call numbers with no duplicates.
        private List<string> GenerateRandomCallNumbers(int count)
        {
            Random random = new Random();
            HashSet<string> randomNumbers = new HashSet<string>(); // Use HashSet to store unique numbers.

            while (randomNumbers.Count < count)
            {
                string randomNumber = random.Next(100, 1000).ToString();
                randomNumbers.Add(randomNumber); // Add to HashSet to ensure uniqueness.
            }

            return randomNumbers.ToList(); // Convert HashSet back to List.
        }

        // Event handler for the "Generate Numbers" button.
        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            correctOrder = GenerateRandomCallNumbers(10);
            txtbRandomNumbers.Text = string.Join(" ", correctOrder);
            callNumbers.Clear(); // Clear only if you want to refresh the list.
            foreach (var callNumber in correctOrder)
            {
                callNumbers.Add(callNumber);
            }

            // Start the timer when generating numbers.
            gameTimer.Start();
        }

        // Event handler for the "Check Order" button.
        private void CheckOrder_Click(object sender, RoutedEventArgs e)
        {
            // Check the order of call numbers
            List<string> userOrder = callNumbers.ToList();

            if (IsOrderedAscending(userOrder))
            {
                // Calculate and award points based on time remaining
                int points = CalculatePoints();
                MessageBox.Show($"Congratulations! You ordered the numbers correctly and earned {points} points.");
                // Implement gamification features here.
            }
            else
            {
                MessageBox.Show("Oops! The order is incorrect.");
            }
        }

        // Calculates points based on time remaining.
        private int CalculatePoints()
        {
            // Calculate points based on time remaining
            int maxPoints = 300; // Adjust the maximum points as needed
            int pointsPerSecond = 2; // Adjust the points per second as needed
            int pointsEarned = maxPoints - (120 - timeRemaining) * pointsPerSecond; // Assumes a 120-second time limit
            return pointsEarned < 0 ? 0 : pointsEarned; // Ensure points are non-negative
        }

        // Checks if a list of strings is ordered in ascending numeric order.
        private bool IsOrderedAscending(List<string> numbers)
        {
            // Convert the strings to integers for comparison.
            List<int> intNumbers = numbers.Select(int.Parse).ToList();

            // Check if the numbers are in ascending order.
            for (int i = 1; i < intNumbers.Count; i++)
            {
                if (intNumbers[i] < intNumbers[i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        // Event handler for ListBox item drag and drop.
        private void ListBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ListBoxItem listBoxItem = FindAncestor<ListBoxItem>((DependencyObject)e.OriginalSource);

            if (listBoxItem != null)
            {
                DragDrop.DoDragDrop(listBoxItem, listBoxItem.DataContext, DragDropEffects.Move);
                listBoxItem.IsSelected = true;
            }
        }

        // Finds an ancestor of a specific type in the visual tree.
        private T FindAncestor<T>(DependencyObject current) where T : DependencyObject
        {
            do
            {
                if (current is T)
                {
                    return (T)current;
                }
                current = VisualTreeHelper.GetParent(current);
            }
            while (current != null);
            return null;
        }

        // Event handler for ListBox drop operation.
        private void lstCallNumbers_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                string data = (string)e.Data.GetData(typeof(string));
                int index = lstCallNumbers.SelectedIndex;

                if (index >= 0 && index < callNumbers.Count)
                {
                    callNumbers.Remove(data);
                    callNumbers.Insert(index, data);
                }
            }
        }

        // Event handler for the game timer tick.
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (timeRemaining > 0)
            {
                timeRemaining--;
                txtbTimer.Text = "Time Remaining: " + timeRemaining + " seconds";
            }
            else
            {
                // Time is up, stop the timer and handle the end of the game
                gameTimer.Stop();
                txtbTimer.Text = "Time's Up!";
                // Implement end of game logic here
            }
        }

        
    }
}
