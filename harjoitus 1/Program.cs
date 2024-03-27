using harjoitus_1;

internal class Program
{
    private static void Main(string[] args)
    {
        //kutsutaan ajoneuvo olio ajoneuvo-luokasta
        ajoneuvo auto = new ajoneuvo();
        ajoneuvo orava = new ajoneuvo();

        //annetaan autolle arvoja
        auto.Nimi = "Toyota";
        auto.Nopeus = 160;
        auto.Renkaat = 4;

        orava.Nimi = "Audi";
        orava.Nopeus = 80;
        orava.Renkaat = 3;

        auto.TulostaData();
        Console.WriteLine();
        orava.TulostaData();
        Console.WriteLine();

        //Noudetaan ajoneuvonto tiedot tostringillä
        string autonTiedot = auto.ToString();
        Console.WriteLine(autonTiedot);

        Console.WriteLine();
        autonTiedot = orava.ToString();
        Console.WriteLine(autonTiedot);



    }
}