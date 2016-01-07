using System;

namespace Vergleichsoperatoren
{
    class Program
    {
        static void Main(string[] args)
        {
            int meinAlter = 38;
            int alterMeinerTocher = 5;
            bool resultat;

            // == IstGleich
            resultat = IstGleich(meinAlter, alterMeinerTocher);
            Console.WriteLine("{0} ist GLEICH {1}: {2}", meinAlter, alterMeinerTocher, resultat);

            // != IstUngleich
            resultat = IstUnGleich(meinAlter, alterMeinerTocher);
            Console.WriteLine("{0} ist UNGLEICH {1}: {2}", meinAlter, alterMeinerTocher, resultat);

            Console.WriteLine();
            Console.WriteLine("Bitte Return eingeben zum beenden!");
            Console.ReadLine();
        }

        static bool IstGleich(int a, int b)
        {
            return a == b;
        }

        static bool IstUnGleich(int a, int b)
        {
            return a != b;
        }

        static bool IstGroesser(int a, int b)
        {
            return a > b;
        }

        static bool IstGroesserOderGleich(int a, int b)
        {
            return a >= b;
        }

        static bool IstKleiner(int a, int b)
        {
            return a < b;
        }

        static bool IstKleinerOderGleich(int a, int b)
        {
            return a <= b;
        }
    }
}
