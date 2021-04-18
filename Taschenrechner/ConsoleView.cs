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

        public  ConsoleView(RechnerModel model)
        {
            this.model = model; 
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
