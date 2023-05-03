using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechner_properties
{
    internal class Menue
    {
        public static void MainMenue()
        {
            while (true)
            {
                Console.WriteLine("Bitte wählen Sie eine Berechnung:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraktion");
                Console.WriteLine("3. Multiplikation");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Modulo");
                Console.WriteLine("6. X2");
                Console.WriteLine("7. X3");
                Console.WriteLine("8. Quadratwurzel");
                Console.WriteLine("9. Fakultät");
                Console.WriteLine("10. Trapez");
                Console.WriteLine("11. Kugel");
                Console.WriteLine("0. Programm beenden");

                Berechnung berechnung = new Berechnung();

                int auswahl = int.Parse(Console.ReadLine());
                if (auswahl == 0)
                {
                    break;
                }

                switch (auswahl)
                {
                    case 1:
                        berechnung.Addition(Operand.Nummer("Zahl", "erste"), Operand.Nummer("Zahl", " zweite")); break;
                    case 2:
                        berechnung.Subtraktion(Operand.Nummer("Zahl", "erste"), Operand.Nummer("Zahl", " zweite")); break;
                    case 3:
                        berechnung.Multiplikation(Operand.Nummer("Zahl", "erste"), Operand.Nummer("Zahl", " zweite")); break;
                    case 4:
                        berechnung.Division(Operand.Nummer("Zahl", "erste"), Operand.Nummer("Zahl", " zweite")); break;
                    case 5:
                        berechnung.Modulo(Operand.Nummer("Zahl", "erste"), Operand.Nummer("Zahl", " zweite")); break;
                    case 6:
                        berechnung.X2(Operand.Nummer("Zahl", "erste")); break;
                    case 7:
                        berechnung.X3(Operand.Nummer("Zahl", "erste")); break;
                    case 8:
                        berechnung.Quadratwurzel(Operand.Nummer("Zahl", " erste")); break;
                    case 9:
                        berechnung.Fakultaet(Operand.Nummer("Zahl", "erste")); break;
                    case 10:
                        int auswahlTrapez = 0;
                        Console.WriteLine("Drücken Sie 1 für umfang oder 2 für fläche rechnen: ");
                        auswahlTrapez = int.Parse(Console.ReadLine());
                        if (auswahlTrapez == 1)
                        {
                            berechnung.UmfangTrapez(Operand.Nummer("Parellel", "erste"), Operand.Nummer("Parallel", " zweite"), Operand.Schraenge("erste"), Operand.Schraenge("zweite")); break;
                        }
                        else if (auswahlTrapez == 2)
                        {
                            berechnung.FlaecheTrapez(Operand.Nummer("Parallel", "erste"), Operand.Nummer("Parallel", " zweite")); break;
                        }
                        else { Console.WriteLine("Falsche eingabe!!"); break; }
                    case 11:
                        berechnung.Kugel(Operand.Nummer("Radius", "")); break;
                    default:
                        Console.WriteLine("Ungültige Eingabe!"); break;
                }
            }
        }
    }
}

