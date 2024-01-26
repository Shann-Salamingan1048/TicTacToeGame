using System;

namespace Jan23
{
    class TicTacToe : GameModes
    {
        public TicTacToe() { }
        public void Run()
        {
            ChooseMode();
        }
        private void ChooseMode()
        {
            bool loop = true;
            while (loop)
            {
                Console.Write("Please Choose a Mode\n1. Player vs Player\n2. Computer vs Computer\n");
                string chosenStr = Console.ReadLine();
                if (UInt16.TryParse(chosenStr, out UInt16 chosen)) // if the convertion of into numeric is true then run
                {
                    switch (chosen)
                    {
                        case 1:
                            while (true)
                            {
                                PlayerVsPlayer();
                                Console.WriteLine("Do you want to continue?\n1. Yes\n2. No");
                                string Yes_No = Console.ReadLine();
                                if (int.TryParse(Yes_No, out int yes_no))
                                {
                                    if (yes_no == 2)
                                        break;
                                    else if(yes_no == 1)
                                    {
                                        GoDefault();
                                    }
                                }
                            }
                            loop = false;
                            break;
                        case 2:
                            while (true)
                            {
                                ComputerVsComputer();
                                Console.WriteLine("Do you want to continue?\n1. Yes\n2. No");
                                string Yes_No = Console.ReadLine();
                                if (int.TryParse(Yes_No, out int yes_no))
                                {
                                    if (yes_no == 2)
                                        break;
                                    else if (yes_no == 1)
                                    {
                                        GoDefault();
                                    }
                                }
                            }
                            loop = false;
                            break;
                        default:
                            Console.WriteLine("\nInvalid choice. Please choose 1 or 2.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Please enter a valid number (1 or 2).");
                }
            }
        }

    }
}
