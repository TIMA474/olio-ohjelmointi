using Harjoitus_5_Laskin;

internal class Program
{
    private static void Main(string[] args)
    {
        // lause jolla laskin tulee tulosstamaan numeroita 

        float a = 5f ;
        float b = 10f;

        float Summa = laskin .Summa(a, b);

        float Erotus = laskin.Erotus(a, b);

        float Tulo = laskin.Tulo(a, b);

        float jako = laskin.jako(a, b);

        Console.WriteLine("Numeroiden {0} ja {1}:", a, b);
        Console.WriteLine("Summa: " +  Summa);
        Console.WriteLine("Erotus: " + Erotus);
        Console.WriteLine("Tulo: " + Tulo);
        Console.WriteLine("Jako: " + jako);




    }
}