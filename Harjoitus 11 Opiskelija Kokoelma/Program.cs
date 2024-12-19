using Harjoitus_11_Opiskelija_Kokoelma;

internal class Program
{
    private static void Main(string[] args)
    {
        {
            Dictionary<int, Opiskelija> opiskelijat = new Dictionary<int, Opiskelija>();
            string syöte;

            while (true)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("Mitä haluat tehdä?");
                Console.WriteLine("1. lisää - Lisää opiskelijan kokoelmaan");
                Console.WriteLine("2. poista - Poistaa opiskelijan kokoelmasta");
                Console.WriteLine("3. tulosta - Tulostaa opiskelija kokoelman");
                Console.WriteLine("4. poistu - Poistuu sovelluksesta");

                syöte = Console.ReadLine();

                switch (syöte)
                {
                    case "lisää":
                        
                        LisääOpiskelija(opiskelijat);
                        break;
                    case "poista":
                        
                        PoistaOpiskelija(opiskelijat);
                        break;
                    case "tulosta":
                       
                        TulostaOpiskelijat(opiskelijat);
                        break;
                    case "poistu":
                       
                        return;
                    default:
                        
                        break;
                }
            }
        }

        static void LisääOpiskelija(Dictionary<int, Opiskelija> opiskelijat)
        {
            Opiskelija uusiOpiskelija = new Opiskelija();

            while (true)
            {
                Console.WriteLine("Anna uudelle opiskelijalle tiedot:");
                Console.WriteLine("Etunimi: ");
                uusiOpiskelija.Etunimi = Console.ReadLine();
                Console.WriteLine("Sukunimi: ");
                uusiOpiskelija.Sukunimi = Console.ReadLine();
                Console.WriteLine("Ryhmätunnus: ");
                uusiOpiskelija.Ryhmätunnus = Console.ReadLine();
                Console.WriteLine("OpiskelijaID: ");
                uusiOpiskelija.OpiskelijaNumero = Convert.ToInt32(Console.ReadLine());

                
                if (opiskelijat.ContainsKey(uusiOpiskelija.OpiskelijaNumero))
                {
                    Console.WriteLine("Opiskelija sanakirjassa on opiskelija samalla ID:llä");
                    continue;
                }
                else
                {
                    opiskelijat.Add(uusiOpiskelija.OpiskelijaNumero, uusiOpiskelija);
                    break;
                }
            }
        }

        static void PoistaOpiskelija(Dictionary<int, Opiskelija> opiskelijat)
        {
            Console.WriteLine("Anna opiskelijan opiskelijaID jonka haluat poistaa:");
            int syöte = Convert.ToInt32(Console.ReadLine());

            if (opiskelijat.ContainsKey(syöte))
            {
                Console.WriteLine("Opiskelija " + opiskelijat[syöte].Etunimi + " poistettu");
            }
            else
            {
                Console.WriteLine("Opiskelijaa ID:llä " + syöte + " ei löydetty kokoelmasta");
            }

            opiskelijat.Remove(syöte);
        }

        static void TulostaOpiskelijat(Dictionary<int, Opiskelija> opiskelijat)
        {
            foreach (Opiskelija item in opiskelijat.Values)
            {
                item.TulostaTiedot();
            }
        }
    }
}