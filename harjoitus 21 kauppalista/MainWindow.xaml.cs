using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ShoppingListApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Tapahtumankäsittelijä, kun CheckBox valitaan
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox != null && checkBox.IsChecked == true)
            {
                // Luodaan TextBlock valitulle tuotteelle ja lisätään se cartPaneliin
                TextBlock item = new TextBlock
                {
                    Text = checkBox.Content.ToString(),
                    Tag = checkBox.Name // Tag tunnistaa CheckBoxin
                };
                cartPanel.Children.Add(item);
            }
        }

        // Tapahtumankäsittelijä, kun CheckBox poistetaan valinnasta
        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox != null && checkBox.IsChecked == false)
            {
                // Poistetaan vastaava TextBlock cartPanelista
                foreach (TextBlock item in cartPanel.Children)
                {
                    if (item.Tag.ToString() == checkBox.Name)
                    {
                        cartPanel.Children.Remove(item);
                        break; // Lopetetaan poistamisen jälkeen, jotta ei muokata kokoelmaa iteraation aikana
                    }
                }
            }
        }

        // Tapahtumankäsittelijä "Osta"-napille
        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {
            if (cartPanel.Children.Count > 1)
            {
                // Näytetään maksuilmoitus
                MessageBoxResult result = MessageBox.Show("Haluatko varmasti ostaa tuotteet?", "Vahvista osto", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    // Maksu onnistui
                    MessageBox.Show("Osto onnistui! Kiitos ostoksestasi.", "Maksu onnistui", MessageBoxButton.OK, MessageBoxImage.Information);
                    // Tyhjennetään cartPanel ja nollataan CheckBoxit
                    cartPanel.Children.Clear();
                    cartPanel.Children.Add(new TextBlock { Text = "Ostoskorisi:", FontWeight = FontWeights.Bold, Margin = new Thickness(0, 0, 0, 10) });
                    ResetCheckBoxes(this);
                }
            }
            else
            {
                // Ostoskori on tyhjä
                MessageBox.Show("Ostoskorisi on tyhjä. Valitse tuotteita ennen ostoa.", "Ostoskori tyhjä", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        // Apuohjelma, joka nollaa kaikki CheckBoxit
        private void ResetCheckBoxes(DependencyObject parent)
        {
            int count = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < count; i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);
                if (child is CheckBox checkBox)
                {
                    checkBox.IsChecked = false;
                }
                // Kutsutaan metodia rekursiivisesti, jotta löydetään kaikki CheckBoxit visuaalisessa puussa
                ResetCheckBoxes(child);
            }
        }
    }
}