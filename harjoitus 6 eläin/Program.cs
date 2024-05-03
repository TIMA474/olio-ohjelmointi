using harjoitus_6_eläin;

internal class Program
{
    private static void Main(string[] args)
    {
        eläin.KuinkaMonta();

        koira koira1 = new koira();
        koira1.ääntele();

        kissa kissa1 = new kissa();
        kissa1.ääntele();

        eläin.KuinkaMonta();

        koira koira2 = new koira();
        koira koira3 = new koira();
        koira kissa2 = new koira();

        koira.KuinkaMonta();
        kissa.KuinkaMonta();
        eläin.KuinkaMonta();
    }
}