using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ChessBoard
{
    
    /*
     * När jag frågade AI vad jag skulle kunna ändra, så kändes alla ändringar väldigt överkomplicerade för detta projekt
     * Så jag frågade en kompis som jobbar som programmerare, och han skrev ReadSize() här under som inte är utkommenterad
     * Den kortar ner det till en while loop och gör GetNumber private.
     */
    public class Board
    {
        private int rowNumber;
        private int columnNumber;
        /*public void ReadSize()
        {
            while (true) {
                Console.WriteLine("Hur många rader vill du skriva ut? Välj en siffra mellan 3 och 50");
                string input = Console.ReadLine(); 
                if (!int.TryParse(input, out int number) || number < 3 || number > 50)
                {
                    Console.WriteLine("Ogiltig siffra, försök igen.");
                }
                else
                {
                    rowNumber = number;
                    break;
                }
            }
            while (true)
            {
                Console.WriteLine("Hur många kolumner vill du skriva ut? Välj en siffra mellan 3 och 50");
                string text = Console.ReadLine();
                if (!int.TryParse(text, out int number2) || number2 < 3 || number2 > 50)
                {
                    Console.WriteLine("Ogiltig siffra, försök igen.");
                }
                else
                {
                    columnNumber = number2;
                    break;
                }
            }
        }*/
        
        public void ReadSize()
        {
            rowNumber = GetNumber("Hur många rader vill du skriva ut? Välj en siffra mellan 3 och 50");
            columnNumber =GetNumber("Hur många kolumner vill du skriva ut? Välj en siffra mellan 3 och 50");
        }

        private int GetNumber(string text) 
        {
            while (true)
            {
                Console.WriteLine(text);
                string input = Console.ReadLine();
                if (int.TryParse(input, out int number2) && number2 >= 3 && number2 <= 50)
                {
                    return number2;
                }
                Console.WriteLine("Ogiltig siffra, försök igen.");
            }
        }
        public void RenderBoard()
        {
            for (int i = 0; i < rowNumber; i++)
            {
                for (int j = 0; j < columnNumber; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write("◼︎");
                    }
                    else
                    {
                        Console.Write("◻︎");
                    }
                }
                Console.WriteLine();
            }
        }

    }
}
