using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class ConsoleView
    {
        private RechnerModel model;

        public ConsoleView(RechnerModel model)
        {
            this.model = model;
        }

        public string HoleZahlVomBenutzer()
        {
            Console.Write("Bitte gib ein Zahl für die Berechnung ein: ");
            return  Console.ReadLine();
        }

        public string HoleOperatorVomBenutzer()
        {
            Console.Write("Bitte geben Sie die auszuführende Operation ein: ");
            return Console.ReadLine(); 
        }

        public string WarteAufEndeVomBenutzer()
        {
            Console.Write("Zum Beenden Return drücken!");
            return Console.ReadLine();  
        }

        public void GibResultatAus(string Operation)
        {
            switch (Operation)
            {
                case "+":
                    Console.WriteLine("Die Summe ist: {0}", model.Resultat);
                    break;

                case "-":
                    Console.WriteLine("Die Differenz ist: {0}", model.Resultat);
                    break;

                case "/":
                    Console.WriteLine("Der Quotient ist: {0}", model.Resultat);
                    break;
                case "*":
                    Console.WriteLine("Das Produkt ist: {0}", model.Resultat);
                    break;

                default:
                    Console.WriteLine("Sie haben eine ungültige Eingabe gemacht!");
                    break;
            }
        }
        public string HoleBenutzerEingabe(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string summand = Console.ReadLine();

            return summand;
        }
    }
}
