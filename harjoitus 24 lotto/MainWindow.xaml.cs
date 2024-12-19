using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace LottoApp
{
    public partial class MainWindow : Window
    {
        private Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        // Kun käyttäjä painaa "Tulosta" nappia
        private void TulostaButton_Click(object sender, RoutedEventArgs e)
        {
            // Tyhjentää aiemmat tulokset
            ArvotutRivitTextBlock.Text = "";

            // Haetaan käyttäjän antama rivien määrä
            int rivienMaara = int.Parse(RivienMaaraTextBox.Text);
            // Haetaan valittu peli ComboBoxista
            string peli = ((ComboBoxItem)PelivalintaComboBox.SelectedItem).Content.ToString();

            // Arvotaan ja tulostetaan annettu määrä rivejä valitusta pelistä
            for (int i = 0; i < rivienMaara; i++)
            {
                string rivi = ArvoRivi(peli);
                ArvotutRivitTextBlock.Text += rivi + "\n";
            }
        }

        // Kun käyttäjä painaa "Tyhjennä" nappia
        private void TyhjennaButton_Click(object sender, RoutedEventArgs e)
        {
            // Tyhjentää tulostetut rivit
            ArvotutRivitTextBlock.Text = "";
        }

        // Kun käyttäjä painaa "Viikon arvonta" nappia
        private void ViikonArvontaButton_Click(object sender, RoutedEventArgs e)
        {
            // Toteutetaan viikon arvonta
        }

        // Kun käyttäjä painaa "Tarkista" nappia
        private void TarkistaButton_Click(object sender, RoutedEventArgs e)
        {
            // Tarkistetaan voitot ja tulostetaan
        }

        // Arpoo yhden rivin valitun pelin mukaan
        private string ArvoRivi(string peli)
        {
            if (peli == "Lotto")
            {
                // Lotto numerot
                List<int> numerot = Enumerable.Range(1, 40).ToList();
                numerot = Shuffle(numerot);
                return string.Join(", ", numerot.Take(7).OrderBy(n => n));
            }
            else if (peli == "Viking Lotto")
            {
                // Viking Lotto numerot
                List<int> numerot = Enumerable.Range(1, 48).ToList();
                numerot = Shuffle(numerot);
                return string.Join(", ", numerot.Take(6).OrderBy(n => n)) + " + " + random.Next(1, 9);
            }
            else if (peli == "Eurojackpot")
            {
                // Eurojackpot numerot
                List<int> numerot = Enumerable.Range(1, 50).ToList();
                List<int> tahtinumerot = Enumerable.Range(1, 10).ToList();
                numerot = Shuffle(numerot);
                tahtinumerot = Shuffle(tahtinumerot);
                return string.Join(", ", numerot.Take(5).OrderBy(n => n)) + " + " + string.Join(", ", tahtinumerot.Take(2).OrderBy(n => n));
            }
            else
            {
                // Jos peliä ei ole valittu
                return "";
            }
        }

        // Sekoittaa listan satunnaisesti
        private List<T> Shuffle<T>(List<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            return list;
        }
    }
}
