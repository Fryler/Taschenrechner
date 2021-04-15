using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class RechnerModel
    {
        public double Resultat { get; private set; }

        public RechnerModel()
        {
            Resultat = 0; 
        }

        public void Berechne(double x, double y, string Operation)
        {
           
            switch (Operation)
            {
                case "+":

                    Resultat = Addiere(x, y);

                    break;

                case "-":

                    Resultat = Subtrahiere(x, y);

                    break;

                case "/":
                    Resultat = Dividiere(x, y);

                    break;
                case "*":
                    Resultat = Multipliziere(x, y);

                    break;

            }
        }

        private double Addiere(double x, double y)
        {
            double summe = x + y;

            return summe;
        }

        private double Subtrahiere(double x, double y)
        {
            double differenz = x - y;

            return differenz;
        }

        private double Dividiere(double Dividend, double Divisor)
        {
            double Quotient = Dividend / Divisor;

            return Quotient;
        }

        private double Multipliziere(double Multiplikator, double Multiplikant)
        {
            double Produktwert = Multiplikator * Multiplikant;

            return Produktwert;
        }
    }
}
