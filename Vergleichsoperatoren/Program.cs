using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vergleichsoperatoren
{
    class Program
    {
        static void Main(string[] args)
        {
            int meinAlter = 38;
            int alterMeinerTocher = 5;
            bool resultat;

            // Auf Gleichheit prüfen
            resultat = IstGleich(meinAlter, alterMeinerTocher);
            Console.WriteLine(resultat);

            Console.ReadLine();
        }

        static bool IstGleich(int a, int b)
        {
            // == wird als Gleichheitsoperator bezeichnet
            return a == b;
        }

        static bool IstUnGleich(int a, int b)
        {
            // != wird als Ungleich-Operator bezeichnet
            return a != b;
        }
    }
}
