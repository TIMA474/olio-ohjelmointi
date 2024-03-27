using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus_3__KT_
{
    internal class kiuas
    {
        private int onkopäällä;
        private int lämpötila;
        private int kostetus;

        public kiuas()
        {
            // 0 = pois päältä, 1 = päällä
            onkopäällä = 0;

            // Oletuslämpötila
            lämpötila = 20;

            // Oletuskosteus
            kostetus = 50;

        }

        public void kytkepäälle()
        {
            onkopäällä = 1;
            Console.WriteLine(" kiuas on nytten päällä ");
        }

        public void kytkepoispäältä()
        {
            onkopäällä = 0;
            Console.WriteLine("kiuas on nytten päällä ");

        }
        public void asetaLämpötila(int lämpö)
        {
            lämpötila = lämpö;
            Console.WriteLine("Lämpötila on asetettu: " + lämpötila + " astetta.");
        }

        public void asetaKosteus(int kosteudet)
        {
            kostetus = kosteudet;
            Console.WriteLine("Kosteus on asetettu: " + kostetus + "%.");



        }
    }
}