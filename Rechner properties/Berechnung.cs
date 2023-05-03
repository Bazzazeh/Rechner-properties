using System;

namespace Rechner_properties
{
    internal class Berechnung
    {
        // Variable
        private double ergebnis;

        // Prop

        public double Ergebnis
        {
            get { return this.ergebnis; }
            set { this.ergebnis = value; }
        }


        public void Addition(double nummer1, double nummer2)
        {
            Ergebnis = nummer1 + nummer2;
            Console.WriteLine($"Die Formel für eine Addition lautet: {nummer1} + {nummer2} = {Math.Round(Ergebnis, 2)}");
        }
        public void Subtraktion(double nummer1, double nummer2)
        {
            Ergebnis = nummer1 - nummer2;
            Console.WriteLine($"Die Formel für eine Subtraktion lautet: {nummer1} - {nummer2} = {Math.Round(Ergebnis, 2)}");
        }
        public void Multiplikation(double nummer1, double nummer2)
        {
            Ergebnis = nummer1 * nummer2;
            Console.WriteLine($"Die Formel für eine Multiplikation lautet: {nummer1} * {nummer2} = {Math.Round(Ergebnis, 2)}");
        }
        public void Division(double nummer1, double nummer2)
        {
            Ergebnis = nummer1 / nummer2;
            Console.WriteLine($"Die Formel für eine division lautet: {nummer1} / {nummer2} = {Math.Round(Ergebnis, 2)}");
        }
        public void Modulo(double nummer1, double nummer2)
        {
            if (nummer2 != 0)
            {
                Ergebnis = nummer1 % nummer2;
                Console.WriteLine($"Die Formel für eine Modulo lautet: {nummer1} % {nummer2} = {Math.Round(Ergebnis, 2)}");
            }
            else
            {
                Console.WriteLine("Division durch Null ist nicht erlaubt!");
            }
        }
        public void X2(double nummer1)
        {
            Ergebnis = Math.Pow(nummer1, 2);
            Console.WriteLine($"Die Formel für X2 lautet: {nummer1}² = {Ergebnis}");
        }
        public void X3(double nummer1)
        {
            Ergebnis = Math.Pow(nummer1, 3);
            Console.WriteLine($"Die Formel für X3 lautet: {nummer1}³ = {Ergebnis}");
        }
        public void Quadratwurzel(double nummer1)
        {
            Ergebnis = Math.Sqrt(nummer1);
            Console.WriteLine($"Die Formel für die Quadratwurzel lautet: √{nummer1} = {Ergebnis}");
        }
        public double Fakultaet(double nummer1)
        {
            if (nummer1 == 0)
                return 1;
            else
                Ergebnis = nummer1 * (nummer1 - 1);
            Console.WriteLine($"Die Formel für die Fakultät lautet: {nummer1}! = {Ergebnis}");
            return Ergebnis;
        }
        public double UmfangTrapez(double nummer1, double nummer2, double nummer3, double nummer4)
        {
            Ergebnis = nummer1 + nummer2 + nummer3 + nummer4;
            Console.WriteLine("Umfang des Trapezes: " + Ergebnis);
            return Ergebnis;
        }
        public double FlaecheTrapez(double nummer1, double nummer2)
        {
            double hoehe = (nummer2 - nummer1) / 2.0;
            Ergebnis = (nummer1 + nummer2) / 2.0 * hoehe;
            Console.WriteLine("Fläche des Trapezes: " + Ergebnis);
            return Ergebnis;
        }
        public double Kugel(double radius)
        {
            Ergebnis = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine("Umfang des Kugels: " + Ergebnis);
            return Ergebnis;
        }

    }
}
