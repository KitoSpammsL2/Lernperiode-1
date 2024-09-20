using System.Xml.Serialization;

namespace Tic_tac_toe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tabelle = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            bool isPlayer1Turn = true;
            int numTurns = 0;
          
            
            while (!checkVictory() && numTurns != 9)
            {
                PrintTabelle();
                if (isPlayer1Turn)
                    Console.WriteLine("Player 1 turn");
                else
                    Console.WriteLine("Player 2 turn");

                string auswahl = Console.ReadLine();

                if (tabelle.Contains(auswahl) && auswahl != "X" && auswahl != "O");
                {
                    int tabelleIndex = Convert.ToInt32(auswahl) - 1;

                    if (isPlayer1Turn)
                        tabelle[tabelleIndex] = "X";
                    else
                        tabelle[tabelleIndex] = "O";
                    
                    numTurns++;

                }

                if (checkVictory())
                    Console.WriteLine("Du hasst gewonnen");
                
              

                isPlayer1Turn = !isPlayer1Turn; 
            }
            bool checkVictory()
            {
                bool row1 = tabelle[0] == tabelle[1] && tabelle[1] == tabelle[2];
                bool row2 = tabelle[3] == tabelle[4] && tabelle[4] == tabelle[5];
                bool row3 = tabelle[6] == tabelle[7] && tabelle[7] == tabelle[8];
                bool col1 = tabelle[0] == tabelle[3] && tabelle[3] == tabelle[6];
                bool col2 = tabelle[1] == tabelle[4] && tabelle[4] == tabelle[7];
                bool col3 = tabelle[2] == tabelle[5] && tabelle[5] == tabelle[8];
                bool diagDown = tabelle[0] == tabelle[4] && tabelle[4] == tabelle[8];
                bool diagUp = tabelle[6] == tabelle[4] && tabelle[4] == tabelle[2];

                return row1 || row2 || row3 ||col1 || col2 || diagDown || diagUp;

            }





            void PrintTabelle()
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(tabelle[i * 3 + j] + "|");
                    }
                    Console.WriteLine();
                    Console.WriteLine("------");
                }
            }
        }
    }
}
