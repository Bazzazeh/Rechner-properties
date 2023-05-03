using System;

namespace Rechner_properties
{
    internal class Operand
    {
        public static double Nummer(string type, string index)
        {

            Console.Write($"Bitte geben Sie die {index} {type} ein: ");
            return Convert.ToDouble(Console.ReadLine());
        }

        public static double Schraenge(string index)
        {
            Console.Write($"Länge der {index} Schrängen Seite eingeben: ");
            return double.Parse(Console.ReadLine());
        }

        public static double Trapez()
        {
            Console.WriteLine("Drücken Sie 1 für umfang oder 2 für fläche rechnen: ");
            return Convert.ToDouble(Console.ReadLine());
        }
        public static double Radius()
        {
            Console.Write("Bitte geben Sie eine Radius ein: ");
            return double.Parse(Console.ReadLine());
        }
    }
}
