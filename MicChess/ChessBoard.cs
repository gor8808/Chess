using System;

namespace MicChess
{
    public class ChessBoard
    {
        public static int[,] Coordinate = new int[8,8];

        public void InputCoordinate(char letterCoordinate,int y)
        {

            int x = CharToNumber(letterCoordinate);
            y -= 1;
            Coordinate[y, x] = 1;
            PrintBoard();
        }
        public void InputCoordinate()
        {
            Console.WriteLine(" Enter x Coordinate.");
            int x = CharToNumber(Convert.ToChar(Console.ReadLine()));
            Console.WriteLine(" Enter y Coordinate.");
            int y = Convert.ToInt32(Console.ReadLine());
            y -= 1;
            Coordinate[y, x] = 1;
            PrintBoard();
        }
        public void PrintBoard()
        {
            Console.WriteLine();
            PrintBoardLetters();
            Console.WriteLine();
            
            for (int i = 0; i < 8; i++)
            {
                Console.Write("    ");
                for (int c = 0; c < 8; c++)
                {
                    Console.Write("+---");
                }
                Console.Write("+\n");
                Console.Write(" " + (i + 1));

                for (int j = 0; j < 8; j++)
                {
                    if (j == 0)
                        Console.Write("  ");

                    Console.Write("| " + CoordinatesToPlayerLetters(Coordinate[i,j]) + " ");
                }
                Console.WriteLine("| " + (i + 1));
            }
            Console.Write("    ");
            for (int c = 0; c < 8; c++)
            {
                Console.Write("+---");
            }
            Console.Write("+\n");

            PrintBoardLetters();
            Console.WriteLine();
        }

        private char CoordinatesToPlayerLetters(int index)
        {
            switch (index) 
            {
                case 0:
                    return ' ';
                case 1:
                    return 'K';
                case 2:
                    return 'Q';
                case 3:
                    return 'R';
                case -1:
                    return 'k';
                default:
                    return ' ';
            }
        }

        private void PrintBoardLetters()
        {
            Console.Write("    ");
            for (int num = 0; num < 8; num++)
            {
                Console.Write("  " + NumberToChar(num) + " ");
            }
        }

        public char NumberToChar(int index)
        {
            switch (index)
            {
                case 0:
                    return 'A';
                case 1:
                    return 'B';
                case 2:
                    return 'C';
                case 3:
                    return 'D';
                case 4:
                    return 'E';
                case 5:
                    return 'F';
                case 6:
                    return 'G';
                case 7:
                    return 'H';
                default:
                    return '0';
            }
        }
        public int CharToNumber(char letter)
        {
            switch (Char.ToUpper(letter))
            {
                case 'A':
                    return 0;
                case 'B':
                    return 1;
                case 'C':
                    return 2;
                case 'D':
                    return 3;
                case 'E':
                    return 4;
                case 'F':
                    return 5;
                case 'G':
                    return 6;
                case 'H':
                    return 7;
                default:
                    return 0;
            }
        }
    }
}
