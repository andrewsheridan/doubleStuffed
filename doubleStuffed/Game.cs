using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doubleStuffed
{
    public class Game
    {
        public int activePlayer, p1TokenCt, p2TokenCt;
        public Board GameBoard = new Board();
        public bool gameOver = false;
        //UI? Just Form1.cs?

        public Game()
        {
            InitGame();
        }
        
        public int GameEnd()
        {
            if (p1TokenCt > p2TokenCt)
            {
                //Player 1 won
                return 1; 

            }
            else if (p1TokenCt < p2TokenCt)
            {
                //Player 2 won
                return 2; 
            }

            else
            {
                //Tie condition
                return 0;
            }
        }

        public void InitGame()
        {
            gameOver = false;
            GameBoard.InitBoard();
            p1TokenCt = 2;
            p2TokenCt = 2;
            activePlayer = 2;
            GameBoard.CheckBoard(activePlayer);
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
                        gameOver = true;
                        GameEnd();
                    }
                }
            }
        }
        public void SwapPlayer()
        {
            if (activePlayer == 1)
            {
                activePlayer = 2;
            }
            else
            {
                activePlayer = 1;
            }
        }
    }
}
