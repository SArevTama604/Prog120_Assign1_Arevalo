using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog120_Assign1_Arevalo
{
    public partial class MainWindow : Window
    {
        public object TextBox1 { get; private set; }
        public object TextBox2 { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        // Method to handle addition
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double num1 = double.Parse(TextBox1.Text);
                double num2 = double.Parse(TextBox2.Text);
                double result = num1 + num2;
                MessageBox.Show($"{num1} + {num2} = {result}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers in both fields.");
            }
        }

        // Method to handle subtraction
        private void SubtractButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double num1 = double.Parse(TextBox1.Text);
                double num2 = double.Parse(TextBox2.Text);
                double result = num1 - num2;
                MessageBox.Show($"{num1} - {num2} = {result}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers in both fields.");
            }
        }

        // Method to handle multiplication
        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double num1 = double.Parse(TextBox1.Text);
                double num2 = double.Parse(TextBox2.Text);
                double result = num1 * num2;
                MessageBox.Show($"{num1} * {num2} = {result}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers in both fields.");
            }
        }

        // Method to handle division
        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double num1 = double.Parse(TextBox1.Text);
                double num2 = double.Parse(TextBox2.Text);
                if (num2 == 0)
                {
                    throw new DivideByZeroException();
                }
                double result = num1 / num2;
                MessageBox.Show($"{num1} / {num2} = {result}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers in both fields.");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show($"Division of {TextBox1.Text} by zero.");
            }
        }
    }
}