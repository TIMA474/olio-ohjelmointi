using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_4_Albumi__Kotitehtävä_
{
    internal class kappale
    {


        public string Nimi { get; set; }
        public double Kesto { get; set; }

        public kappale(string nimi, double kesto)
        {
            Nimi = nimi;
            Kesto = kesto;
        }
        public void TulostaKappale()
        {
            Console.WriteLine("Nimi: " + Nimi + " - " + Kesto);

        }

    }   
}
