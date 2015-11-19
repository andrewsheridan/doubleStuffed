using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doubleStuffed
{
    class Game
    {
        public int ActivePlayer, P1TokenCt, P2TokenCt;
        public Board GameBoard = new Board();
        //UI? Just Form1.cs?
        private bool wereNoMoves;

        public void GameEnd() { }
        public void InitGame() { }
        public void Run() { }
        public void SwapPlayer()
        {
            if (ActivePlayer == 1)
    {
                ActivePlayer = 2;
                //UI.IconTokenColor ="Black";
            }
            else
            {
                ActivePlayer = 1;
                //UI.IconTokenColor = "White";
            }

        }
    }
}
