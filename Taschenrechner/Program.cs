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
            Console.WriteLine("-----Taschenrechner 1.0 by Steffen Richter-----");
            ConsoleView view = new ConsoleView();
            string xalsString = view.HoleBenutzerEingabe("Bitte gib die erste Zahl ein: ");
            string yalsString = view.HoleBenutzerEingabe("Bitte gib die zweite Zahl ein: ");
            string Operation = view.HoleBenutzerEingabe("Bitte wähle eine der 4 Grundrechenarten '+,-,*,/': ");

            // Wandel Text in Gleitkommazahlen um
            // TODO: Auslagern wenn mehr Funktionen verfügbar sind
            double x = Convert.ToDouble(xalsString); 
            double y = Convert.ToDouble(yalsString);

            // Berechnung ausführen
            RechnerModel model = new RechnerModel(); 
            model.Berechne(x, y, Operation);


            //Ausgabe

            

            view.GibResultatAus(model.Resultat, Operation);


            view.HoleBenutzerEingabe("Bitte Enter zum Beenden betätigen!");
        }
    }
}
