internal class Program
{
    private static void Main(string[] args)
    {
        NewMessage();
        List<string> ostunimekiri = new List<string>();
        Console.WriteLine("Sisesta oma tänane poeskäigunimekiri");
        string kasutajaSisestus = "";
        GetUserInput(kasutajaSisestus, ostunimekiri);
        foreach (var söök in ostunimekiri)
        {
            Console.WriteLine($" -*- {söök}");
        }
        GetUserInput(kasutajaSisestus, ostunimekiri);
    }

    static List<string> GetUserInput(string kasutajaSisestus, List<string> ostunimekiri)
    {
        while (kasutajaSisestus == "")
        {
            Console.WriteLine("Kirjuta ükshaaval, sisesta järgmine ost:\nKui rohkem ei ole midagi liisada, siis ütle \"rohkem pole\"");
            kasutajaSisestus = Console.ReadLine();
            if (kasutajaSisestus == "rohkem pole")
            {
                break;
            }
            ostunimekiri.Add(kasutajaSisestus);
            kasutajaSisestus = "";
        }
        return ostunimekiri;
    }

    static void NewMessage() {
        Console.WriteLine("this is a message");
    }


}