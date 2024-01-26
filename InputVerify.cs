using System;
using System.Collections.Generic;

namespace Jan23
{
    class InputVerify : Board
    {
        private const char X_Player = 'X';
        private const char O_Player = 'O';
        private List<List<UInt16>> WinningCombi = new List<List<UInt16>>
        {
            // Rows
            new List<UInt16> {0,1,2},
            new List<UInt16> {3,4,5},
            new List<UInt16> {6,7,8},
            // Columns
            new List<UInt16> {0,3,6},
            new List<UInt16> {1,4,7},
            new List<UInt16> {2,5,8},
            // Diagonal 
            new List<UInt16> {0,4,8},
            new List<UInt16> {2,4,6},
        };
        public InputVerify() { }
        protected bool MoveLegal(int move)
        {
            return BoardTicTacToe[move].Equals(X_Player) || BoardTicTacToe[move].Equals(O_Player);
        }
        protected bool isDraw()
        {
            UInt16 count = 0;
            foreach(var cell in BoardTicTacToe)
            {
                if (cell.Equals(O_Player) || cell.Equals(X_Player))
                    count++;

            }
            if (count == 9)
            {
                Scores[0] += 0.5;
                Scores[1] += 0.5;
                return true;
            }
            return false;
        }
        protected bool VerifyCombination(char playerType, int playerTypeScore) // Player Type at yung Score nya
        {
            foreach(var i in WinningCombi)
            {
                UInt16 count = 0;
                foreach (var k in i)
                {
                    if (BoardTicTacToe[k].Equals(playerType))
                        count++;
                }
                if (count == 3)
                {
                    Scores[playerTypeScore]++;
                    return true;
                }
            }
            return false;
        }
    }
}
