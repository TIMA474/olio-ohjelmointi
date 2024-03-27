namespace harjoitus_2._0
{
    internal class opiskelija
    {
        private string Nimi { get; set; }
        private string opiskelijaID { get; set; }

        private int Opintopisteet { get; set; }

        public opiskelija(string _nimi, string _id, int _op)
        {
            Nimi = _nimi;
            opiskelijaID = _id;
            Opintopisteet = _op;

        }
        //konstruktori opiskeilja luokaksi
        public void TulostaData()
        {
            Console.WriteLine("");
            Console.WriteLine("opiskselija");
            Console.WriteLine("--Nimi: " + Nimi);
            Console.WriteLine("--opiskelijaID: " + opiskelijaID);
            Console.WriteLine("--opintopisteet: " + Opintopisteet);
            Console.WriteLine("");      

        }
       
        //metodi joka ottaa parametriksi integer arvon 
        public void muokkaaopuntopisteitä(int i)
        {
            Opintopisteet += i; 

            if ( Opintopisteet < 0 )
            {
                Opintopisteet = 0;
            }






        }
    
    
    }
}
