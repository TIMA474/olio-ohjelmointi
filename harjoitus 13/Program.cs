using System;
using System.Collections.Generic;
using Harjoitus13_kt_;

internal class Program
{
    private static void Main(string[] args)
    {
        
        
        // Luodaan joukkue ja pelaajia
        Joukkue joukkue1 = new Joukkue("Jääkiekkojoukkue", "Espoo");
        Pelaaja pelaaja1 = new Pelaaja("Matti", "Meikäläinen", 12);
        Pelaaja pelaaja2 = new Pelaaja("Teemu", "Selänne", 67);
        Pelaaja pelaaja3 = new Pelaaja("Jari", "Kurri", 7);
        Pelaaja pelaaja4 = new Pelaaja("Saku", "Koivu", 1);

        // Käytetään Joukkue-luokan metodia ja lisätään pelaajia joukkueeseen
        joukkue1.LisaaPelaaja(pelaaja1);
        joukkue1.LisaaPelaaja(pelaaja2);
        joukkue1.LisaaPelaaja(pelaaja3);
        joukkue1.LisaaPelaaja(pelaaja4);

        // Poistetaan pelaaja joukkueesta
        joukkue1.PoistaPelaaja(pelaaja2);

        
        
        // Haetaan joukkueen pelaajat listana Joukkue-luokan metodilla
        List<Pelaaja> pelaajat = joukkue1.HaePelaajat();

        // Käydään läpi jokainen pelaaja listassa
        foreach (Pelaaja p in pelaajat)
        {
            // Tulostetaan pelaajan tiedot
            Console.WriteLine(p.etunimi + " " + p.sukunimi + " " + p.numero);
        }

       
        
        // Yritetään hakea pelaajan tietoja ja tulostaa ne
        try
        {
            Pelaaja haettuPelaaja = joukkue1.HaePelaaja(1);
            Console.WriteLine("Etunimi: " + haettuPelaaja.etunimi + " Sukunimi: " + haettuPelaaja.sukunimi + " Numero: " + haettuPelaaja.numero);
        }
        // Jos tulee virhe, tulostetaan virheviesti
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}