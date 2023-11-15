using System;
using System.Collections.Generic;
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

namespace DewDecimalTrainingApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ReplaceBook(object sender, MouseButtonEventArgs e)
        {
            ReplaceBook rb = new ReplaceBook();
            rb.Show();

        }

        private void IdentifyAreas(object sender, MouseButtonEventArgs e)
        {
            IdentifyAreas ia = new IdentifyAreas();
            ia.Show();

        }
        private void FindCallNumbers(object sender, MouseButtonEventArgs e)
        {
            FindCallNumber findCall = new FindCallNumber();
            findCall.Show();

        }

    }
}
