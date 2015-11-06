using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doubleStuffed
{
    class Board
    {
        public int[,] Spaces = new int[8, 8];
        public string BoardString()
        {
            string output = "";
            for(int i = 0; i < 8; i++)
            {
                for(int j=0; j<8; j++)
                {
                    output += Spaces[i,j] + "  ";
                }
                output += Environment.NewLine;
            }
            return output;
        }
        
        public Board()
        {
            for(int i=0; i<8; i++)
            {
                for(int j=0; j<8; j++)
                {
                    Spaces[i,j] = 0;
                }
            }
            Spaces[3, 3] = 1;
            Spaces[4, 4] = 1;
            Spaces[3, 4] = 2;
            Spaces[4, 3] = 2;
        }

        public void FlipToken(int col, int row)
        {
            if (Spaces[col, row] == 1)
                Spaces[col, row] = 2;
            else if(Spaces[col, row] ==2)
                Spaces[col, row] = 1;
        }

        public bool CheckBoard() {return false; }

        public bool CheckSquare() { return false; }

        public void CommitMove() { }

        public bool FlipCheck(int x, int y, int dirX, int dirY) { return false; }

        public void InitBoard() { }
    }
}
