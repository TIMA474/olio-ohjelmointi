using Harjoitus_4_Albumi__Kotitehtävä_;

internal class Program
{
    private static void Main(string[] args)
    {
        kappale kappale1 = new kappale("Kappale1", 3.5);
        kappale kappale2 = new kappale("Kappale2", 4.0);
        kappale kappale3 = new kappale("Kappale3", 2.2);
        List<kappale> Kappaleet = new List<kappale>();
        Kappaleet.Add(kappale1);
        Kappaleet.Add(kappale2);
        Kappaleet.Add(kappale3);

        albuumi albumi = new albuumi("Albumi 1", "Artisti 1", "Pop", 12.99, Kappaleet);
        // Tulostetaan koko albumi


        albumi.TulostaAlbumi();
    }
}