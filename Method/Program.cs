internal class Program
{

    private static void Main(string[] args)
    {
        Random juhuarv = new Random();
        Console.WriteLine("Kas sa tahad münti visata, või täringut veeretada?");
        string kasutajaValik = Console.ReadLine();
        if (kasutajaValik == "münti")
        {
            Console.WriteLine(Münt(juhuarv));
        } else if (kasutajaValik == "täringut")
        {
            Console.WriteLine(Täring(juhuarv));
        }
        else
        {
            Console.WriteLine("Ei tea sellist vastust");
        }

    }

    static int Täring(Random thing)
    {
        return thing.Next(1, 6);
    }

    static string Münt(Random thing)
    { 
        int mündivise = thing.Next(1, 2);
        if (mündivise == 1)
        {
            return "kull";
        } else if (mündivise == 2)
        {
            return "kiri";
        }
        return "serv";
    }




    //private static void Main(string[] args)
    //{
    //    NewMessage();
    //    List<string> ostunimekiri = new List<string>();
    //    Console.WriteLine("Sisesta oma tänane poeskäigunimekiri");
    //    string kasutajaSisestus = "";
    //    GetUserInput(kasutajaSisestus, ostunimekiri);
    //    foreach (var söök in ostunimekiri)
    //    {
    //        Console.WriteLine($" -*- {söök}");
    //    }
    //    GetUserInput(kasutajaSisestus, ostunimekiri);
    //}

    //static List<string> GetUserInput(string kasutajaSisestus, List<string> ostunimekiri)
    //{
    //    while (kasutajaSisestus == "")
    //    {
    //        Console.WriteLine("Kirjuta ükshaaval, sisesta järgmine ost:\nKui rohkem ei ole midagi liisada, siis ütle \"rohkem pole\"");
    //        kasutajaSisestus = Console.ReadLine();
    //        if (kasutajaSisestus == "rohkem pole")
    //        {
    //            break;
    //        }
    //        ostunimekiri.Add(kasutajaSisestus);
    //        kasutajaSisestus = "";
    //    }
    //    return ostunimekiri;
    //}

    //static void NewMessage() {
    //    Console.WriteLine("this is a message");
    //}


}