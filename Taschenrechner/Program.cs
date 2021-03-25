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
            int Summand1;
            int Summand2;
            int Summe;
            Console.WriteLine("-----Taschenrechner 1.0 by Steffen Richter-----");
            do
            {
                Console.WriteLine("Addition: Geben Sie die erste zu addierende Zahl ein und bestätigen Sie mit Enter: ");
                Summand1 = Convert.ToInt32(Console.ReadLine());
            }
            while (Summand1, Summand2 = //ganze Zahl)
            if (Summand1 = //ganze Zahl )
            {
                Console.WriteLine("Addition: Geben Sie bitte die zweite zu addierende Zahl ein und bestätigen Sie mit Enter: ");
                Summand2 = Convert.ToInt32(Console.ReadLine());
            }
            if (Summand2 = //ganze Zahl)
            else
            {
                        Console.WriteLine("Bitte geben Sie nur ganze Zahlen ein!");
            }
            Summe = Summand1 + Summand2;
            Console.WriteLine("Das Addition von " + Summand1 + " und " + Summand2 + " ist: " + Summe);
            Console.ReadLine();
        }
    }
}
