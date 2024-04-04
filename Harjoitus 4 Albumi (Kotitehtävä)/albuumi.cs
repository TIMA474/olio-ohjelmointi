namespace Harjoitus_4_Albumi__Kotitehtävä_
{
    internal class albuumi
    {

        public string Nimi { get; set; }
        public string Artisti { get; set; }
        public List<kappale> Kappaleet { get; set; }
        public string Genre { get; set; }
        public double Hinta { get; set; }

        public albuumi(string nimi, string artisti, string genre, double hinta, List<kappale> _kappaleet)
        {
            Nimi = nimi;
            Artisti = artisti;
            Kappaleet = _kappaleet;
            Genre = genre;
            Hinta = hinta;
        }

        public void LisääKappale(kappale kappale)
        {
            Kappaleet.Add(kappale);
        }

        public void TulostaAlbumi()
        {
            Console.WriteLine("Albumi: " + Nimi);
            Console.WriteLine("Artisti: " + Artisti);
            Console.WriteLine("Genre: " + Genre);
            Console.WriteLine("Hinta: " + Hinta);
            Console.WriteLine("Kappaleet:");
            foreach (var kappale in Kappaleet)
            {
                kappale.TulostaKappale();


            }

        }












    }

 
}
