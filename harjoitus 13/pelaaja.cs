using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus13_kt_
{
    internal class Pelaaja
    {
        //nimi muuttujat
        public string etunimi;
        public string sukunimi;
        public int numero;


        
        
        
        public Pelaaja(string _etunimi, string _sukunimi, int _numero)
        {
            etunimi = _etunimi;
            sukunimi = _sukunimi;
            numero = _numero;

        }



    }
}