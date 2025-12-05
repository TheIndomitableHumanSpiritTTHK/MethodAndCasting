namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arv = 69420;
            string arvTektsina = arv.ToString();
            Console.WriteLine(arvTektsina);
            Console.WriteLine(arv);

            double arvdouble = 6969696969.420420420420d;
            int arvdoublearvint = 0;

            arvdoublearvint = (int)arvdouble;

            double uusdouble = arv;

            string pikkus = "";
            Console.WriteLine("Tere Palun sisesta oma pikkus");
            pikkus = Console.ReadLine();
            float pikkusFm = float.Parse(pikkus);

            int pikkusCm = (int)pikkusFm;
            Console.WriteLine($"Sinu pikkus CMides on {pikkusCm}");
        }
    }
}
