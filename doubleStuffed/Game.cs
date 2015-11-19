using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doubleStuffed
{
    class Game
    {
        public int activePlayer, p1TokenCt, p2TokenCt;
        public Board GameBoard = new Board();
        //UI? Just Form1.cs?

        public void GameEnd() { }
        public void InitGame()
        {
            GameBoard.InitBoard();
            p1TokenCt = 2;
            p2TokenCt = 2;
            activePlayer = 1;
        }

        /// <summary>
        /// Called when the player clicks. Therefore the setup for next player is done during this function.
        /// </summary>
        public void Run(int x, int y)
        {
            //turn sequence only happens when a valid space is clicked/dropped on for activePlayer, call him/her A; the opposition is B
            if (GameBoard.Spaces[x, y] == 3)
            {
                GameBoard.CommitMove(x, y, activePlayer);

                SwapPlayer(); //activePlayer is now B

                //(if there is a valid move for activePlayer B, CheckBoard() updates the Board with valid moves for B)
                //if no valid move for activePlayer B, swap player...
                if (!GameBoard.CheckBoard(activePlayer))
                {
                    SwapPlayer(); //activePlayer is now A

                    //(if there is a valid move for activePlayer A, CheckBoard() has updated the Board with valid moves for A)
                    //no move for activePlayer A, end game.
                    if (!GameBoard.CheckBoard(activePlayer))
                    {
                        GameEnd();
                    }
                }
            }
        }

        /// <summary>
        /// Swaps the player from 1 to 2 or 2 to 1
        /// </summary>
        public void SwapPlayer()
        {
            if (activePlayer == 1)
            {
                activePlayer = 2;
                //UI.IconTokenColor ="Black";
            }
            else
            {
                activePlayer = 1;
                //UI.IconTokenColor = "White";
            }
        }
    }
}