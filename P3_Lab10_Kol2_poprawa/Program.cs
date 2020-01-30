using System;
using System.Collections.Generic;
using System.Linq;



namespace P3_Lab10_Kol2_poprawa
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie.1");
            Random a = new Random();
            Random z = new Random();
            int x = a.Next(40, 70);

            string[] names = { "Cieszyn", "Bielsko", "Wisła", "Skoczów", "Cos" };

            

            IEnumerable<int> lista = Enumerable.Range(0,50).ToList();

            IEnumerable<Mieszkanie> mieszkania = lista.Select(x => new Mieszkanie(
                   x, 
                   names[z.Next(0,4)], 
                   x
                   ));

            foreach (var item in mieszkania)
            {
                Console.WriteLine(item.Metraz+"m2_"+item.Nazwa+"_"+item.OdlegloscOdCentrum+"km");
            }

            //IEnumerable<Mieszkanie> query =mieszkania.Where()

            Console.WriteLine("Zadanie.2");
            var p = new Test(15, "Cos", "tak", true, "Lipowczan");
            var (idi, pow) = p;

            Console.WriteLine($"{idi}/{pow}");

            var u = new Test(16,"Tak","cos", false, "Lipowczan");
            var (_, naz, op, _, tes) = u;

            Console.WriteLine($"{idi}/{naz}/{op}/{pow}/{tes}");

            Console.WriteLine("Zadanie.3");
        }
    }
}
