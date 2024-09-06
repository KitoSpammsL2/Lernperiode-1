using System.ComponentModel.Design;

namespace Taschenrechner
{
    internal class Rechner
    {
        private static void Main(string[] args)
        {

            double Zahl1, Zahl2;
            char Operator;
            double ergebnis = 0;


            while (true)
            {

                Console.WriteLine("Was ist die erste Zahl der Rechnung ?");
                string eingabe = Console.ReadLine();


                if (double.TryParse(eingabe, out Zahl1))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine ganze Zahl ein");
                }
            }



            while (true)
            {
                Console.WriteLine("Was ist der Operator ? (+, -, *, /) ");
                string eingabe2 = Console.ReadLine();

                if (char.TryParse(eingabe2, out Operator) && (Operator == '+' || Operator == '-' || Operator == '*' || Operator == '/'))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie einen gültigen Operator ein");
                }
            }



            while (true)
            {

                Console.WriteLine("Was ist die zweite Zahl der Rechnung ?");
                string eingabe3 = Console.ReadLine();


                if (double.TryParse(eingabe3, out Zahl2))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine ganze Zahl ein");
                }
            }

        if (Operator == '+')
        {
            ergebnis = Zahl1 + Zahl2;
        }

        if (Operator == '-')
        {
            ergebnis = (Zahl1 - Zahl2);
        }

        if (Operator == '*')
        {
            ergebnis = (Zahl1 * Zahl2);
        }

        if (Operator == '/')
        {
            ergebnis = (Zahl1 / Zahl2);
        }

        Console.WriteLine($"Das Ergebniss ist {ergebnis}");


           
            
            
        }
    }
}