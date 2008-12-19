using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    class Program
    {
        static Random rnd = new Random(DateTime.Now.Millisecond);

        static void Main(string[] args)
        {
            Feld a = Feld.getRandom(rnd);
            Feld b = Feld.getRandom(rnd);

            Console.WriteLine("Feld A");
            Feld.print(a);

            Console.WriteLine("Feld B");
            Feld.print(b);

            Console.WriteLine("Ergebnis +");
            Feld.print(a + b);

            Console.WriteLine("Ergebnis *");
            Feld.print(a * b);

            Console.ReadLine();
        }
    }
}
