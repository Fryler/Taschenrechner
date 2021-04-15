using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class RechnerModel
    {
        public double Berechne(double x, double y, string Operation)
        {
            double resultat = 0;

            switch (Operation)
            {
                case "+":

                    resultat = Addiere(x, y);

                    break;

                case "-":

                    resultat = Subtrahiere(x, y);

                    break;

                case "/":
                    resultat = Dividiere(x, y);

                    break;
                case "*":
                    resultat = Multipliziere(x, y);

                    break;

            }
            return resultat;
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
