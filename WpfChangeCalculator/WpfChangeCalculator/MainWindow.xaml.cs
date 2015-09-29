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

namespace WpfChangeCalculator
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
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        private void btn_Click(object sender, RoutedEventArgs e)
        {
            decimal itemCost = decimal.Parse(textBox1.Text);

            decimal moneyGiven = decimal.Parse(textBox2.Text);
                                     
            decimal change = moneyGiven - itemCost;

            decimal twenties = Math.Floor(change / 20.00M);

            decimal tens = Math.Floor((change % 20.00M) / 10.00M);

            decimal fives = Math.Floor(((change % 20.00M) % 10.00M) / 5.00M);

            decimal ones = Math.Floor((((change % 20.00M) % 10.00M) % 5.00M) / 1.00M);

            decimal quarters = Math.Floor(((((change % 20.00M) % 10.00M) % 5.00M) % 1.00M) / 0.25M);

            decimal dimes = Math.Floor((((((change % 20.00M) % 10.00M) % 5.00M) % 1.00M) % 0.25M) / 0.10M);

            decimal nickels = Math.Floor(((((((change % 20.00M) % 10.00M) % 5.00M) % 1.00M) % 0.25M) % 0.10M) / 0.05M);

            decimal pennies = Math.Floor((((((((change % 20.00M) % 10.00M) % 5.00M) % 1.00M) % 0.25M) % 0.10M) % 0.05M) / 0.01M);

            changeLabel.Content = "The Change is " + change.ToString("C");

            twentiesLabel.Content = "Twenty dollar bills: " + twenties;

            tensLabel.Content = "Ten dollar bills: " + tens;

            fivesLabel.Content = "Five dollar bills: " + fives;

            onesLabel.Content = "One dollar bills: " + ones;

            quartersLabel.Content = "Quarters: " + quarters;

            dimesLabel.Content = "Dimes: " + dimes;

            nickelsLabel.Content = "Nickels: " + nickels;

            penniesLabel.Content = "Pennies: " + pennies;

        }


    }
}
