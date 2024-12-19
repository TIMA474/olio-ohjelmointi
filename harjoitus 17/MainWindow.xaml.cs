using System.Windows;

namespace TaloWPF
{
    public partial class MainWindow : Window
    {
        // Muuttujat
        float lämpötila;
        bool keittiöValot;
        bool olohuoneenValot;
        bool oviLukossa;

        public MainWindow()
        {
            InitializeComponent();

            // Alustetaan talon tilan muuttujat
            lämpötila = 20.0f;
            keittiöValot = false;
            olohuoneenValot = false;
            oviLukossa = false;
        }

        // Metodi valojen päälle/pois kytkemiselle
        private void ValotButton_Click(object sender, RoutedEventArgs e)
        {
            keittiöValot = !keittiöValot;
        }

        // Metodi sisälämpötilan säätämiselle
        private void LämpötilaSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lämpötila = (float)LämpötilaSlider.Value;
        }

        // Metodi ovien lukitsemiselle/avaamiselle
        private void OviButton_Click(object sender, RoutedEventArgs e)
        {
            oviLukossa = !oviLukossa;
        }
    }
}

