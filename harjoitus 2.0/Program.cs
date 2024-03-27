using harjoitus_2._0;

internal class Program
{
    private static void Main(string[] args)
    {
      //luodaan opskelija olio
        opiskelija opiskelija1 = new opiskelija("alex" , "X4X" , 0 ) ;

        opiskelija1. TulostaData();

        opiskelija1. muokkaaopuntopisteitä(5);

        opiskelija1.TulostaData();

    }
}