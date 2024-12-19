using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus_10_eläimet_ja_rajapinnat
{
    internal class varis
    {
        public float WingSize { get; set; }

        public varis(float wingSize)
        {
            WingSize = wingSize;
        }

        public void Fly()
        {
            Console.WriteLine("varis lentää variksen siipien koko on " + WingSize );
        }


    }
}