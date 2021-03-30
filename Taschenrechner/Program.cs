using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ziel: Addieren; 2 Zahlen zwischen 0 und 10. 
            double Summand1;
            double Summand2;
            double Summe;

            Console.WriteLine("-----Taschenrechner 1.0 by Steffen Richter-----");

            Console.WriteLine("Addition: Geben Sie die erste zu addierende Zahl ein und bestätigen Sie mit Enter: ");
            Summand1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Addition: Geben Sie bitte die zweite zu addierende Zahl ein und bestätigen Sie mit Enter: ");
            Summand2 = Convert.ToDouble(Console.ReadLine());
            Summe = Addiere(Summand1, Summand2);
            Console.WriteLine("Das Addition von " + Summand1 + " und " + Summand2 + " ist: " + Summe);
            WarteAufBenutzerEingabe();
        }

        static double Addiere(double Summand1, double Summand2)
        {
            double summe = Summand1 + Summand2;

            return summe;
        }

        static void WarteAufBenutzerEingabe()
        {
            Console.Write("Zum Beenden bitte die Enter-Taste drücken!");
            Console.ReadLine();
        }
    }
}
