using System.ComponentModel.Design;
using Microsoft.Win32.SafeHandles;

namespace tingimuslausetöö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ü1:");
            Ü1();
            Console.WriteLine("Ü2");
            Ü2();
            Console.WriteLine("Ü3");
            Ü3();
            Console.WriteLine("Ü4");
            Ü4();
        }

        private static void Ü4()
        {
            Console.WriteLine("Mis on sinu viimane jalgpallimängu tulemus?");
            int tulemus = int.Parse(Console.ReadLine());
            switch (tulemus)
            {
                default:
                    Console.WriteLine("Ei tunne sellist skoori, see liiga suur minu jaoks.");
                    break;
                case 0:
                    Console.WriteLine("PUDRUJALG OLED VÄ?!?!");
                    break;
                case 1:
                    Console.WriteLine("täitsa ok");
                    break;
                case 2:
                    Console.WriteLine("no see juba on parem");
                    break;
                case 3:
                    Console.WriteLine("Wow, messi");
                    break;
            }
        }

        private static void Ü3()
        {
            Console.WriteLine("Kui palju tunde kas sa viimase nädala mängitud?: (sisesta number 0-40)");
            int tunde = int.Parse(Console.ReadLine());
            if (tunde == 0)
            {
                Console.WriteLine("kahju et sul aega mängida pole :c");
            }
            else if (tunde > 0 && tunde <= 10)
            {
                Console.WriteLine("mõõdukas mängija, tubli");
            }
            else if (tunde > 10 && tunde <= 20)
            {
                Console.WriteLine("natuks paljuks läheb, kodutööd kannatavad");
            }
            else if (tunde >= 20 && tunde <= 40)
            {
                Console.WriteLine("liiga palju mängid, kas sa kooli üldse nii jõuad?");
            }
            else if (tunde > 40)
            {
                Console.WriteLine("siin peaks juba sekkuma psühholoog.");
            }
            else
            {
                Console.WriteLine("Ei tunne seda vastust");
            }
        }

        private static void Ü2()
        {
            Console.WriteLine("Kas sulle meeldivad tulbid?");
            string kasutajaValik = Console.ReadLine();
            if (kasutajaValik == "jah")
            {
                Console.WriteLine("mulle kaaaaaa");
            }
            else
            {
                Console.WriteLine("Ei saa sinust aru..");
            }
        }

        private static void Ü1()
        {
            string kasutajanimi = "";

            while (kasutajanimi.Length == 0)
            {
                Console.WriteLine("Tere, palun sisesta oma nime");
                kasutajanimi = Console.ReadLine();
            }

            if (kasutajanimi != "nipitiri")
            {
                Console.WriteLine("Sa ei ole nipitiri, ootan ainult nipitirit.");
            }
        }
    }
}
