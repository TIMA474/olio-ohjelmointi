using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_7_Hissi
{
    internal class Hissi
    {

        // alin kerros
        private int minKerros;

        // ylin kerros
        private int maxKerros; 

        // hissin nykyinen kerros
        private int nykyinenKerros;

        public Hissi(int minKerros, int maxKerros) 
        {
            this.minKerros = minKerros;
            this.maxKerros = maxKerros;

            NykyinenKerros = minKerros;
        }

        public int NykyinenKerros 
        {
            get => nykyinenKerros; 
            set 
            {
                
                if (value > maxKerros || value < minKerros)
                {
                    Console.WriteLine("Virheellinen Kerros!");
                }
                else
                {
                    
                    nykyinenKerros = value;
                }


            }
        }
    }
}
