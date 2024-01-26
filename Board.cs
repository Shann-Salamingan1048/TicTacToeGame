using System;
using System.Collections.Generic;

namespace Jan23
{
    class Board
    {

        private UInt16 setWidthPrint = 10;
        protected List<double> Scores = new List<double>
        {
            0.0,0.0
        }; // X, O
        protected List<char> BoardTicTacToe = new List<char>
        {
             '1', '2', '3',
             '4', '5', '6',
             '7', '8', '9'
        };
        public Board() { }
        protected void PrintBoard()
        {
            
            Console.WriteLine("Player X: " + Scores[0]);
            Console.WriteLine("Player O: " + Scores[1]);
            for (UInt16 i = 0; i < BoardTicTacToe.Count; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine();
                    Console.Write(" --------------------------------------------------------------\n" + "|".PadRight(setWidthPrint));
                }
                // Using PadRight to set column widths
                if (BoardTicTacToe[i].Equals('O'))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(BoardTicTacToe[i]);
                    Console.ResetColor();
                }
                else if (BoardTicTacToe[i].Equals('X'))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(BoardTicTacToe[i]);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(BoardTicTacToe[i]);
                    Console.ResetColor();
                }
                Console.Write($"".PadRight(setWidthPrint) 
                      + "|".PadRight(setWidthPrint));
            }
            Console.WriteLine();
            Console.Write(" --------------------------------------------------------------");   
            Console.WriteLine();
        }
        protected void GoDefault()
        {
            List<char> defaultBoardTicTacToe = new List<char>
        {
             '1', '2', '3',
             '4', '5', '6',
             '7', '8', '9'
        };
            BoardTicTacToe = defaultBoardTicTacToe;
    }
    }
}
