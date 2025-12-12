namespace Veeoidla_tase
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool OnÕigeKasutaja = KontrolliNime();
            if (!OnÕigeKasutaja)
            {
                return;
            }

            double veetase = 0.0d;
            Console.WriteLine("Tere. Mis on veetaseme hetkeseis meetrites?");
            do
            {
                Console.WriteLine("Palun sisesta veetaseme hetkeseis meetrites: ");
                veetase = double.Parse(Console.ReadLine());
            } while (veetase < 1.00d && veetase > 4.25d);

            string VesiKõrgus = VesiKõrgusArvutaja(veetase);

            Console.WriteLine($"Praegune veetase on: {VesiKõrgus}");
        }

        private static string VesiKõrgusArvutaja(double veetase)
        {
            switch (veetase)
            {
                default:
                    return "Anduris on viga";
                case >= 1.0d and < 2.0d:
                    return "madal";
                case >= 2.0d and < 3.5d:
                    return "normaalne";
                case >= 3.5d and <= 4.25d:
                    return "kõrge";
            }
        }

        private static bool KontrolliNime()
        {
            string õigeNimi = "JamesBond";
                
            string kasutajanimi = "";
            while (kasutajanimi.Length == 0)
            {
                Console.WriteLine("Palun sisesta oma nime");
                kasutajanimi = Console.ReadLine();
            }

            if (kasutajanimi != õigeNimi)
            {
                Console.WriteLine("Vale nimi, nägemist.");
                return false;
            } else return true;
        }

    }
}
