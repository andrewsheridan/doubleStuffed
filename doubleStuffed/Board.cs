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
        
        /// <summary>
        /// Returns a string representation of the current state of Spaces
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Flips the token found at the designated column and row.
        /// </summary>
        /// <param name="col"></param>
        /// <param name="row"></param>
        public void FlipToken(int col, int row)
        {
            if (Spaces[col, row] == 1)
                Spaces[col, row] = 2;
            else if(Spaces[col, row] ==2)
                Spaces[col, row] = 1;
        }

        /// <summary>
        /// Clears the board of valid moves, then checks current state of the board. 
        /// </summary>
        /// <returns>If there is a valid move for the current player, return true. Else returns false.</returns>
        public bool CheckBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (Spaces[i, j] == 3)
                        Spaces[i, j] = 0;
                }
            }

            bool existsValidMove = false;
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    if (CheckSquare(i, j) == true)
                        existsValidMove = true;
                }
            }
            return existsValidMove;
        }

        //TO-DO
        /// <summary>
        /// Checks the validity of placing a token in the selected square.
        /// </summary>
        /// <returns>True if valid, false if invalid.</returns>
        public bool CheckSquare(int x, int y)
        {
            return false;
        }

        //TO-DO
        /// <summary>
        /// works the same as FlipCheck(), except doesn't call flipToken() function.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="dirX"></param>
        /// <param name="dirY"></param>
        /// <returns></returns>
        public bool CheckSquareDir(int x, int y, int dirX, int dirY)
        {
            if (Spaces[x, y] == 0) //this space is empty
                return false;
            if (Spaces[x, y] == /*current player*/) //this space owned by current player
                return true;
            if ((x == 0 && dirX == -1) //this space owned by opposition. next space would be out of bounds
                || (x == 7 && dirX == 1)
                || (y == 0 && dirY == -1)
                || (y == 7 && dirY == 1))
                return false;
            if (FlipCheck(x + dirX, y + dirY, dirX, dirY))
                return true;
            return false;
        }

        //TO-DO
        /// <summary>
        /// Places the token at the desired valid location and flips all tokens meeting requirements.
        /// </summary>
        public void CommitMove(int x, int y)
        {

        }

        //TO-DO
        /// <summary>
        /// Recursively check the tokens in a designated direction until a token of the active player is found. Calls Board.FlipToken(x, y) on the tokens which need to be flipped.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="dirX"></param>
        /// <param name="dirY"></param>
        /// <returns></returns>
        public bool FlipCheck(int x, int y, int dirX, int dirY)
        {
            return false;
        }

        /// <summary>
        /// Resets current state of the board to the initial layout.
        /// </summary>
        public void InitBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Spaces[i, j] = 0;
                }
            }
            Spaces[3, 3] = 1;
            Spaces[4, 4] = 1;
            Spaces[3, 4] = 2;
            Spaces[4, 3] = 2;
        }
    }
}
