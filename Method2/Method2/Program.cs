
namespace Method2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Tervitus();
            string kasutajanimi = KasutajaNimeKüsimine();

            float eelarve = 0.00f;
            bool kasKasutajaNõustub = false;
            kasKasutajaNõustub = KasutajaNõustus(kasutajanimi, eelarve, kasKasutajaNõustub);


        }

        private static void Tervitus()
        {
            Console.WriteLine("HOMMIK !");
        }

        private static bool KasutajaNõustus(string kasutajanimi, float eelarve, bool kasKasutajaNõustub)
        {
            while (kasKasutajaNõustub == false)
            {
                Console.WriteLine($"{kasutajanimi}, Kas see on sinu õige eelarve? ");
                Console.WriteLine("Vasta kas jah või ei");
                string vastus = Console.ReadLine();
                if (vastus == "jah")
                {
                    return true;
                } else
                {
                    return false;
                }

            }
            return false;
        }

        private static string KasutajaNimeKüsimine()
        {
            string kasutajanimi = "";
            while (kasutajanimi == "")
            {
                Console.WriteLine("Tere, palun sisesta oma kasutaja nimi");
                kasutajanimi = Console.ReadLine();
            }
            
            Console.WriteLine("Mis on sinu nädalana eelarve?");
            return kasutajanimi;
        }
    }
}
