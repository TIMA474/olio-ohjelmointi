using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus_10_eläimet_ja_rajapinnat
{
    internal class sorsa
    {
        public float WingSize { get; set; }
        public float SwimSpeed { get; set; }

        public sorsa(float wingSize, float swimSpeed)
        {
            WingSize = wingSize;
            SwimSpeed = swimSpeed;
        }

        public void Fly()
        {
            Console.WriteLine("sorsa lentää sorsan siipien koko on " + WingSize);
        }

        public void Swim()
        {
            Console.WriteLine("sorsa ui sorsan uinti nopeus on " + SwimSpeed);
        }


    }
}