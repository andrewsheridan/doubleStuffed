﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doubleStuffed
{
    public class Board
    {
        public int p1TokenCount;
        public int p2TokenCount;
        public int[,] Spaces = new int[8, 8];
        
        /// <summary>
        /// Returns a string representation of the current state of Spaces
        /// </summary>
        /// <returns></returns>
        public string BoardString()
        {
            string output = "";
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    output += Spaces[i, j] + "  ";
                }
                output += Environment.NewLine;
            }

            return output;
        }
        
        public Board()
        {
            InitBoard();
        }

        /// <summary>
        /// Flips the token found at the designated column and row.
        /// </summary>
        /// <param name="col"></param>
        /// <param name="row"></param>
        public void FlipToken(int col, int row)
        {
            if (Spaces[col, row] == 1)
            {
                Spaces[col, row] = 2;
                p1TokenCount--;
                p2TokenCount++;

            }
            else if (Spaces[col, row] == 2)
            {
                Spaces[col, row] = 1;
                p1TokenCount++;
                p2TokenCount--;
            }
        }

        /// <summary>
        /// Clears the board of valid moves, then checks current state of the board. 
        /// </summary>
        /// <returns>If there is a valid move for the current player, return true. Else returns false.</returns>
        public bool CheckBoard(int activePlayer)
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
                    if (Spaces[i, j] == 0) //if the space is owned, will not call anything
                    {
                        if (CheckSquare(i, j, activePlayer))
                        {
                            Spaces[i, j] = 3;
                            existsValidMove = true;
                        }
                    }
                }
            }
            return existsValidMove;
        }

        /// <summary>
        /// Checks the validity of placing a token in the selected square.
        /// </summary>
        /// <returns>True if valid, false if invalid.</returns>
        public bool CheckSquare(int x, int y, int activePlayer)
        {
            //All spaces except leftmost column
            if (x > 0)
            {
                //All spaces except top-left corner
                if (y > 0)
                {
                    if ((Spaces[x - 1, y - 1] != activePlayer) && CheckSquareDir(x - 1, y - 1, -1, -1, activePlayer)) //up-left
                    {
                        return true;
                    }
                }

                //All spaces except leftmost column
                if ((Spaces[x - 1, y] != activePlayer) && CheckSquareDir(x - 1, y, -1, 0, activePlayer)) //left
                {
                    return true;
                }

                //All spaces except bottom-left corner
                if (y < 7)
                {
                    if ((Spaces[x - 1, y + 1] != activePlayer) && CheckSquareDir(x - 1, y + 1, -1, 1, activePlayer)) //down-left
                    {
                        return true;
                    }
                }
            }

            //All spaces except top row
            if (y > 0)
            {
                if ((Spaces[x, y - 1] != activePlayer) && CheckSquareDir(x, y - 1, 0, -1, activePlayer)) //up
                {
                    return true;
                }
            }

            //All spaces except bottom row
            if (y < 7)
            {
                if ((Spaces[x, y + 1] != activePlayer) && CheckSquareDir(x, y + 1, 0, 1, activePlayer)) //down
                {
                    return true;
                }
            }

            //All spaces except rightmost column
            if (x < 7)
            {
                //All spaces except top-right corner
                if (y > 0)
                {
                    if ((Spaces[x + 1, y - 1] != activePlayer) && CheckSquareDir(x + 1, y - 1, 1, -1, activePlayer)) //up-right
                    {
                        return true;
                    }
                }

                //All spaces except rightmost column
                if ((Spaces[x + 1, y] != activePlayer) && CheckSquareDir(x + 1, y, 1, 0, activePlayer)) //right
                {
                    return true;
                }

                //All spaces except bottom-right corner
                if (y < 7)
                {
                    if ((Spaces[x + 1, y + 1] != activePlayer) && CheckSquareDir(x + 1, y + 1, 1, 1, activePlayer)) //down-right
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Checks if a space is valid from a particular direction
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="dirX"></param>
        /// <param name="dirY"></param>
        /// <returns>True if valid, false if invalid.</returns>
        /// 
        public bool CheckSquareDir(int x, int y, int dirX, int dirY, int activePlayer)
        {
            if ((Spaces[x, y] == 0) || (Spaces[x, y] == 3)) //this space is empty -> invalid
            {
                return false;
            }

            if (Spaces[x, y] == activePlayer) //this space owned by current player -> valid
            {
                return true;
            }

            if ((x == 0 && dirX == -1) || (x == 7 && dirX == 1) || (y == 0 && dirY == -1) || (y == 7 && dirY == 1)) //this space owned by opposition. next space would be out of bounds -> invalid
            {
                return false;
            }

            if (CheckSquareDir(x + dirX, y + dirY, dirX, dirY, activePlayer)) //this space owned by opposition. if next space returns true -> valid
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Places the token at the desired valid location and flips all tokens meeting requirements.
        /// </summary>
        public void CommitMove(int x, int y, int activePlayer)
        {
            Spaces[x, y] = activePlayer;
            if(activePlayer == 1)
            {
                p1TokenCount++;
            }
            else if(activePlayer == 2)
            {
                p2TokenCount++;
            }
            bool dummyBool = false; //this is never used, but is needed to store return value of FlipCheck().
            //All spaces except leftmost column
            if (x > 0)
            {
                //All spaces except top-left corner
                if (y > 0)
                {
                    /*
                    // TO-DO: use returned value.
                    */
                    dummyBool = FlipCheck(x - 1, y - 1, -1, -1, activePlayer); //up-left
                }

                //All spaces except leftmost column
                /*
                // TO-DO: use returned value.
                */
                dummyBool = FlipCheck(x - 1, y, -1, 0, activePlayer); //left

                //All spaces except bottom-left corner
                if (y < 7)
                {
                    /*
                    // TO-DO: use returned value.
                    */
                    dummyBool = FlipCheck(x - 1, y + 1, -1, 1, activePlayer);//down-left
                }
            }

            //All spaces except top row
            if (y > 0)
            {
                /*
                // TO-DO: use returned value.
                */
                dummyBool = FlipCheck(x, y - 1, 0, -1, activePlayer); //up
            }

            //All spaces except bottom row
            if (y < 7)
            {
                /*
                // TO-DO: use returned value.
                */
                dummyBool = FlipCheck(x, y + 1, 0, 1, activePlayer); //down
            }

            //All spaces except rightmost column
            if (x < 7)
            {
                //All spaces except top-right corner
                if (y > 0)
                {
                    /*
                    // TO-DO: use returned value.
                    */
                    dummyBool = FlipCheck(x + 1, y - 1, 1, -1, activePlayer); //up-right
                }

                //All spaces except rightmost column
                /*
                // TO-DO: use returned value.
                */
                dummyBool = FlipCheck(x + 1, y, 1, 0, activePlayer); //right

                //All spaces except bottom-right corner
                if (y < 7)
                {
                    /*
                    // TO-DO: use returned value.
                    */
                    dummyBool = FlipCheck(x + 1, y + 1, 1, 1, activePlayer); //down-right
                }
            }
        }

        /// <summary>
        /// Recursively check the tokens in a designated direction until a token of the active player is found. Calls Board.FlipToken(x, y) on the tokens which need to be flipped.
        //// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="dirX"></param>
     // </summary>
           /// <param name="dirY"></param>
        /// <returns>True if tokens in path should be flipped. False if tokens in path should NOT be flipped.</returns>
        public bool FlipCheck(int x, int y, int dirX, int dirY, int activePlayer)
        {
            if ((Spaces[x, y] == 0) || (Spaces[x, y] == 3)) //Space is empty
            {
                return false;
            }

            if (Spaces[x, y] == activePlayer) //Space contains token owned by active player
            {
                return true;
            }

            if ((x == 0 && dirX == -1) || (x == 7 && dirX == 1) || (y == 0 && dirY == -1) || (y == 7 && dirY == 1))  //checks for edges of board
            {
                return false;
            }

            if (FlipCheck(x + dirX, y + dirY, dirX, dirY, activePlayer)) //calls itself 
            {
                FlipToken(x, y);
                return true;
            }
        
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

            p1TokenCount = 2;
            p2TokenCount = 2;
            Spaces[3, 3] = 1;
            Spaces[4, 4] = 1;
            Spaces[3, 4] = 2;
            Spaces[4, 3] = 2;
            Spaces[2, 4] = 3;
            Spaces[4, 2] = 3;
            Spaces[5, 3] = 3;
            Spaces[3, 5] = 3;

        }
    }
}