using System;
using System.Collections.Generic;

namespace Harjoitus13_kt_
{
    internal class Joukkue
    {
        // Muuttujat joukkueen nimeä ja kotikaupunkia varten
        public string joukkue;
        public string kotikaupunki;

        // Yksityinen sanakirja pelaajille, jossa avaimena pelaajan numero
        private Dictionary<int, Pelaaja> pelaajat = new Dictionary<int, Pelaaja>();

        // Konstruktori, joka alustaa joukkueen nimen ja kotikaupungin
        public Joukkue(string _joukkue, string _kotikaupunki)
        {
            joukkue = _joukkue;
            kotikaupunki = _kotikaupunki;
        }

        // Metodi pelaajan hakemiseen pelaajan numeron perusteella
        public Pelaaja HaePelaaja(int numero)
        {
            // Käydään läpi pelaajat sanakirjasta
            foreach (KeyValuePair<int, Pelaaja> kvp in pelaajat)
            {
                // Jos pelaajan numero täsmää, palautetaan pelaaja
                if (kvp.Key == numero)
                {
                    return kvp.Value;
                }
            }
            // Heitetään poikkeus, jos pelaajaa ei löydy
            throw new Exception($"Pelaajaa numerolla {numero} ei löytynyt");
        }

        // Metodi pelaajan lisäämiseen sanakirjaan
        public void LisaaPelaaja(Pelaaja pelaaja)
        {
            try
            {
                // Lisätään pelaaja sanakirjaan, avaimena pelaajan numero
                pelaajat.Add(pelaaja.numero, pelaaja);
            }
            catch (ArgumentException)
            {
                // Heitetään poikkeus, jos pelaajan numero on jo käytössä
                throw new Exception($"Pelaajan numero {pelaaja.numero} on jo käytössä");
            }
        }

        // Metodi pelaajan poistamiseen sanakirjasta
        public void PoistaPelaaja(Pelaaja pelaaja)
        {
            // Poistetaan pelaaja sanakirjasta pelaajan numeron perusteella
            pelaajat.Remove(pelaaja.numero);
        }

        // Metodi kaikkien pelaajien hakemiseen listana
        public List<Pelaaja> HaePelaajat()
        {
            // Luodaan lista pelaajista
            List<Pelaaja> _pelaajat = new List<Pelaaja>();

            // Käydään läpi sanakirjan pelaajat ja lisätään ne listaan
            foreach (KeyValuePair<int, Pelaaja> kvp in pelaajat)
            {
                _pelaajat.Add(kvp.Value);
            }

            // Palautetaan pelaajalista
            return _pelaajat;
        }
    }
}