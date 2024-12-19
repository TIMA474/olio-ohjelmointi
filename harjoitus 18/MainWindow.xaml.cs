using System;
using System.Windows;

namespace WpfCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Kun Sum-nappia painetaan
        private void SumButton_Click(object sender, RoutedEventArgs e)
        {
            // Haetaan tekstikentistä numerot
            double number1 = double.Parse(number1TextBox.Text);
            double number2 = double.Parse(number2TextBox.Text);
            // Lasketaan summa ja näytetään tulos
            double result = Laskin.Sum(number1, number2);
            resultTextBlock.Text = $"Summa: {result}";
        }

        // Kun Difference-nappia painetaan
        private void DifferenceButton_Click(object sender, RoutedEventArgs e)
        {
            // Haetaan tekstikentistä numerot
            double number1 = double.Parse(number1TextBox.Text);
            double number2 = double.Parse(number2TextBox.Text);
            // Lasketaan erotus ja näytetään tulos
            double result = Laskin.Difference(number1, number2);
            resultTextBlock.Text = $"erotus: {result}";
        }

        // Kun Product-nappia painetaan
        private void ProductButton_Click(object sender, RoutedEventArgs e)
        {
            // Haetaan tekstikentistä numerot
            double number1 = double.Parse(number1TextBox.Text);
            double number2 = double.Parse(number2TextBox.Text);
            // Lasketaan tulo ja näytetään tulos
            double result = Laskin.Product(number1, number2);
            resultTextBlock.Text = $"tulo: {result}";
        }

        // Kun Division-nappia painetaan
        private void DivisionButton_Click(object sender, RoutedEventArgs e)
        {
            // Haetaan tekstikentistä numerot
            double number1 = double.Parse(number1TextBox.Text);
            double number2 = double.Parse(number2TextBox.Text);
            try
            {
                // Lasketaan jakolasku ja näytetään tulos
                double result = Laskin.Division(number1, number2);
                resultTextBlock.Text = $"jako: {result}";
            }
            catch (DivideByZeroException)
            {
                // Jos jakajana on nolla, näytetään virheviesti
                resultTextBlock.Text = "Virhe: numero nollalla";
            }
        }
    }
}