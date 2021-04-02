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

            string xalsString = HoleBenutzerEingabe("Bitte gib die erste Zahl ein: ");
            string yalsString = HoleBenutzerEingabe("Bitte gib die zweite Zahl ein: ");
            string Operation = HoleBenutzerEingabe("Bitte wähle zwischen Addition oder Subtraktion, gib '+' oder '-' ein: ");

            // Wandel Text in Gleitkommazahlen um
            // TODO: Auslagern wenn mehr Funktionen verfügbar sind
            double x = Convert.ToDouble(xalsString); 
            double y = Convert.ToDouble(yalsString);

            // Berechnung ausführen
            double resultat = 0;
            switch (Operation)
            {
                case "+":

                    resultat = Addiere(x, y);
                    Console.WriteLine("Die Summe ist: {0}", resultat);
                    break;
                
                case "-":

                    resultat = Subtrahiere(x, y);
                    Console.WriteLine("Die Differenz ist: {0}", resultat);
                    break;

                case "/":
                case "*":
                    Console.WriteLine("Diese Anweisung wird bald unterstützt! Trust, bro! :-)");
                    break;

                default:
                    Console.WriteLine("Sie haben eine ungültige Eingabe gemacht!");
                    break;
            }

            HoleBenutzerEingabe("Bitte Enter zum Beenden betätigen!");
        }

        static string HoleBenutzerEingabe(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string summand = Console.ReadLine();

            return summand; 
        }

        static double Addiere(double x, double y)
        {
            double summe = x + y;

            return summe;
        }

        static double Subtrahiere(double x, double y)
        {
            double differenz = x - y;

            return differenz;
        }
    }
}
