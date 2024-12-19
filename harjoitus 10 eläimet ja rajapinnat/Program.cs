using harjoitus_10_eläimet_ja_rajapinnat;

internal class Program
{
    private static void Main(string[] args)
    {

        List<icanfly> lentoEläimet = new List<icanfly>();
        List<icanswim> uimaEläimet = new List<icanswim>();
        varis varis1 = new varis(5);
        sorsa sorsa1 = new sorsa(4, 7);

        varis1.Fly();

        sorsa1.Fly();
       
        sorsa1.Swim();

      

 

    }
}