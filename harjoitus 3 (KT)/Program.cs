using harjoitus_3__KT_;

internal class Program
{
    private static void Main(string[] args)
    {
        // Luodaan Kiuas-olio
        kiuas kiuas = new kiuas();


        kiuas.kytkepäälle();
        kiuas.asetaLämpötila(80);
        kiuas.asetaKosteus(70);
        kiuas.kytkepoispäältä();


    }
}