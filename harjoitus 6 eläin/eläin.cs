using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus_6_eläin
{
    class eläin
    {
        public string Nimi { get; set; }
        private static int instanssit = 0;

        public eläin()
        {
            instanssit++;
        }
        public static void KuinkaMonta()
        {
            Console.WriteLine("Eläimiä tuli luotu: " + instanssit);
        }
        public virtual void ääntele()
        {
            Console.WriteLine("Eläin Ääntelee:");
        }
    }
}
