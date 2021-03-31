using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Program
    {
        // Methode definieren in 7 Schritten
        // (optional) Modifizierer definieren (static, public, private)
        // Datentyp des des Rückgabewertes definieren
        // Methodenname definieren in CamelCase-Notation
        // Rundklammern an den Methodennamen anfügen ()
        // Überlegen welche Parameter übergeben werden (optional diese definieren und Datentyp ergänzen)
        // Geschweifte Klammern {!!} einfügen
        // Methode implementieren (Anweisung in den Methodenrumpf schreiben)

       static void Main(string[] args)
        {
            //Ziel: Addieren; 2 Zahlen zwischen 0 und 10. 

            Console.WriteLine("-----Taschenrechner 1.0 by Steffen Richter-----");


            Console.WriteLine("Geben Sie bitte die erste Zahl ein und bestätigen Sie mit Enter: ");
            double x = Convert.ToDouble(Console.ReadLine()); 
            
            Console.WriteLine("Geben Sie bitte die zweite Zahl ein und bestätigen Sie mit Enter: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double summe = Addiere(y, x);

            Console.WriteLine("Die Summe beider ist: {0}", summe);

            WarteAufBenutzerEingabe();
        }

        static double Addiere(double x, double y)
        {
            double summe = x + y;

            return summe;
        }

        static void WarteAufBenutzerEingabe()
        {
            Console.Write("Zum Beenden bitte die Enter-Taste drücken!");
            Console.ReadLine();
        }
    }
}
