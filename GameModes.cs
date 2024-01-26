using System;
using System.Collections.Generic;
using System.Threading;
namespace Jan23
{
    class GameModes : InputVerify
    {
        public GameModes() { }
        protected void PlayerVsPlayer()
        {
            UInt16 i = 0;
            Console.Clear();
            PrintBoard();

            while (true)
            {
                Console.WriteLine(i);
                char playerO_X = (i % 2 == 0) ? 'X' : 'O';
                string InputNum = Console.ReadLine();
                if (int.TryParse(InputNum, out int InputChosen))
                {
                    if (InputChosen < 1 || InputChosen > 9)
                    {
                        Console.WriteLine("Choose Only from 1 - 9!");
                        Thread.Sleep(1000);
                        Console.Clear();
                        PrintBoard();
                        continue;
                    }
                    if (!MoveLegal(InputChosen - 1))
                        BoardTicTacToe[InputChosen - 1] = playerO_X;
                    else
                    {
                        Console.WriteLine("The Cell is Occupied!");
                        Thread.Sleep(500);
                        Console.Clear();
                        PrintBoard();
                        continue;
                    }

                    Console.Clear();
                    PrintBoard();
                    Thread.Sleep(500);
                    if (i >= 4)
                    {
                        if (VerifyCombination(playerO_X, i % 2)) // Verify if the Combination is Correct and only begin to check if the total maoves made is more than 4
                        {
                            Console.WriteLine($"Player {playerO_X} won!");
                            Thread.Sleep(1000);
                            break;
                        }
                        if (i >= 8)
                        {
                            if (isDraw())  // only begin if it is more than 8
                            {
                                Console.WriteLine("It's a Draw!!!");
                                Thread.Sleep(500);
                                break;
                            }
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Please Enter a Valid Input from 1 - 9!");
                    Thread.Sleep(1000);
                    Console.Clear();
                    PrintBoard();
                    continue;
                }
                i++;
            }

        }
        protected void ComputerVsComputer()
        {
            List<UInt16> ExcludedNums = new List<UInt16>();
            Random random = new Random();
            UInt16 i = 0;
            Console.Clear();
            PrintBoard();
            Thread.Sleep(500);
            while (true)
            {
                char playerO_X = (i % 2 == 0) ? 'X' : 'O';
                UInt16 randomVal;
                do
                {
                    randomVal = (UInt16)random.Next(0, 9); // Generates a random number between 0(inclusive) and 9(exclusive)
                } while (ExcludedNums.Contains(randomVal));
                ExcludedNums.Add(randomVal);
                BoardTicTacToe[randomVal] = playerO_X;
                Console.Clear();
                PrintBoard();
                Thread.Sleep(500);
                if (i >= 4)
                {
                    if (VerifyCombination(playerO_X, i % 2)) // Verify if the Combination is Correct and only begin to check if the total maoves made is more than 4
                    {
                        Console.WriteLine($"Player {playerO_X} won!");
                        Thread.Sleep(1000);
                        break;
                    }
                    if (i >= 8)
                    {
                        if (isDraw())  // only begin if it is more than 8
                        {
                            Console.WriteLine("It's a Draw!!!");
                            Thread.Sleep(500);
                            break;
                        }
                    }
                }
                i++;
            }
        }
    }
}
