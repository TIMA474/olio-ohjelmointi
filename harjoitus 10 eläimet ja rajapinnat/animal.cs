using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus_10_eläimet_ja_rajapinnat
{
    internal class Animal
    {
        

        public virtual void MakeASound()
        {
            Console.WriteLine("eläin tekee äänen");
        }
    }



}

