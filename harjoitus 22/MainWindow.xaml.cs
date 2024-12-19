using System;
using System.Windows;

namespace WindowAreaCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double width = double.Parse(WidthTextBox.Text);
                double height = double.Parse(HeightTextBox.Text);
                double frameWidth = double.Parse(FrameWidthTextBox.Text);

                // Muutetaan millimetrit senttimetreiksi
                width /= 10.0;
                height /= 10.0;
                frameWidth /= 10.0;

                // Lasketaan lasin pinta ala
                double glassWidth = width - 2 * frameWidth;
                double glassHeight = height - 2 * frameWidth;
                double glassArea = glassWidth * glassHeight;

                // Lasketaan karmin piiri
                double framePerimeter = 2 * (width + height);

                // Lasketaan koko ikkunan pinta ala
                double windowArea = width * height;

                // Näytetään tulokset
                ResultsTextBlock.Text = $"Karmin piiri: {framePerimeter:0.00} cm\n" +
                                        $"Lasin pinta-ala: {glassArea:0.00} cm²\n" +
                                        $"Ikkunan pinta-ala: {windowArea:0.00} cm²";
            }
            catch (FormatException)
            {
                MessageBox.Show("Syötä kelvolliset numerot kaikkiin kenttiin.", "Virhe", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}