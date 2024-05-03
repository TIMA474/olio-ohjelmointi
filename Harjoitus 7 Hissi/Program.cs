using Harjoitus_7_Hissi;

internal class Program
{
    private static void Main(string[] args)
    {

        Hissi hissi = new Hissi(0, 10);
        string syöte;

        while (true)
        {
            Console.WriteLine("Kerros " + hissi.NykyinenKerros + " Mihin kerroksen haluaisit lähteä?");

            syöte = Console.ReadLine();


        }

    }
}