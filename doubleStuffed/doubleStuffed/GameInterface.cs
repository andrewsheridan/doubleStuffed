using System;    ////GARRETT"S VERSION
using System.Linq;
using System.Windows.Forms;

namespace doubleStuffed
{
    public partial class GameInterface : Form
    {
        Game tempObj;
        Game gameObj = new Game();
        public GameInterface(Game inEngine)
        {
            tempObj = inEngine;
            InitializeComponent();
            Init2DBoard();
            p1TokenCountToolStripMenuItem.Text = "Player 1: " + tempObj.GameBoard.p1TokenCount;
            p2TokenCountToolStripMenuItem.Text = "Player 2: " + tempObj.GameBoard.p2TokenCount;
        }

        /*****************************************************************
        *Basic Menu button functions, comments added throughout as needed*
        *****************************************************************/
        private void newGameButton_MouseEnter(object sender, EventArgs e)
        {
            newGameButton.Image = Properties.Resources.new_game_white;
        }

        private void newGameButton_MouseLeave(object sender, EventArgs e)
        {
            newGameButton.Image = Properties.Resources.new_game_black;
        }

        private void loadGameButton_MouseEnter(object sender, EventArgs e)
        {
            loadGameButton.Image = Properties.Resources.load_game_white;
        }

        private void loadGameButton_MouseLeave(object sender, EventArgs e)
        {
            loadGameButton.Image = Properties.Resources.load_game_black;
        }

        private void saveGameButton_Click(object sender, EventArgs e)
        {
            var directory = System.IO.Directory.GetCurrentDirectory();

            string output = "";
           
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    output += tempObj.GameBoard.Spaces[i, j] + " ";
                }
                output+=Environment.NewLine;
            }
            output += tempObj.activePlayer + Environment.NewLine;
            output += tempObj.GameBoard.p1TokenCount + Environment.NewLine;
            output += tempObj.GameBoard.p2TokenCount;

            System.IO.File.WriteAllText(directory + @"\save.txt", output);
        }

        private void loadGameButton_Click(object sender, EventArgs e)
        {
            var directory = System.IO.Directory.GetCurrentDirectory();
            System.IO.StreamReader file = new System.IO.StreamReader(directory + @"\save.txt");
            string line;
            int counter = 0;

            while ((line = file.ReadLine()) != null)
            {
                
                string[] ssize = line.Split(null);
                for (int i = 0; i < ssize.Length-1; i++)
                {
                    tempObj.GameBoard.Spaces[counter, i] = Convert.ToInt32(ssize[i]);
                    Console.Write(" " + Convert.ToInt32(ssize[i]));
                }
                Console.WriteLine("");
                counter++;
            }
            file.Close();

            var loadActivePlayer = System.IO.File.ReadLines(directory + @"\save.txt").Skip(8).Take(1).First();
            int activePlayer = Convert.ToInt32(loadActivePlayer);

            if (activePlayer == 1)
            {
                tempObj.activePlayer = 1;
            }
            else
            {
                tempObj.activePlayer = 2;
            }

            var loadScore1 = System.IO.File.ReadLines(directory + @"\save.txt").Skip(9).Take(1).First();
            int Score1 = Convert.ToInt32(loadScore1); 
            tempObj.GameBoard.p1TokenCount = Score1;
            
            var loadScore2 = System.IO.File.ReadLines(directory + @"\save.txt").Skip(10).Take(1).First();
            int Score2 = Convert.ToInt32(loadScore2);
            tempObj.GameBoard.p2TokenCount = Score2;

            menuPanel.Visible = false;
            gamePanel.Visible = true;
        }

        private void helpButton_MouseEnter(object sender, EventArgs e)
        {
            helpButton.Image = Properties.Resources.help_white;
        }

        private void helpButton_MouseLeave(object sender, EventArgs e)
        {
            helpButton.Image = Properties.Resources.help_black;
        }

        private void quitButton_MouseEnter(object sender, EventArgs e)
        {
            quitButton.Image = Properties.Resources.quit_white;
        }

        private void quitButton_MouseLeave(object sender, EventArgs e)
        {
            quitButton.Image = Properties.Resources.quit_black;
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            menuPanel.Visible = false;
            gamePanel.Visible = true;
            tempObj.GameBoard.InitBoard();
            Init2DBoard();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            menuPanel.Visible = false;
            gameplayHelpPanel.Visible = true;
        }

        private void rightHelpButton_MouseEnter(object sender, EventArgs e)
        {
            rightHelpButton.Image = Properties.Resources.right_button_white;
        }

        private void rightHelpButton_MouseLeave(object sender, EventArgs e)
        {
            rightHelpButton.Image = Properties.Resources.right_button_black;
        }

        private void openRulesButton_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Reversi#Rules");
            }
            catch { }
        }

        private void leftButtonRules_Click(object sender, EventArgs e)
        {
            ruleHelpPanel.Visible = false;
            gameplayHelpPanel.Visible = true;
            rightHelpButton.Visible = true;
        }

        private void rightButtonRules_Click(object sender, EventArgs e)
        {
            ruleHelpPanel.Visible = false;
            gameplayHelpPanel.Visible = false;
            menuPanel.Visible = true;
            rightHelpButton.Visible = true;
        }

        private void rightHelpButton_Click(object sender, EventArgs e)
        {
            rightHelpButton.Visible = false;
            ruleHelpPanel.Visible = true;
        }

        private void leftButtonRules_MouseEnter(object sender, EventArgs e)
        {
            leftButtonRules.Image = Properties.Resources.left_button_white;
        }

        private void leftButtonRules_MouseLeave(object sender, EventArgs e)
        {
            leftButtonRules.Image = Properties.Resources.left_button_black;
        }

        private void rightButtonRules_MouseEnter(object sender, EventArgs e)
        {
            rightButtonRules.Image = Properties.Resources.right_button_white;
        }

        private void rightButtonRules_MouseLeave(object sender, EventArgs e)
        {
            rightButtonRules.Image = Properties.Resources.right_button_black;
        }

        /***********************************
        *End of basic Menu button functions*
        ***********************************/


        /***********************
        *Menu Bar functionality*
        ***********************/

        //quit from gameplay menu bar
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //go to main menu from gameplay menu bar
        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuPanel.Visible = true;
            gamePanel.Visible = false;
        }

        

        /******************************
        *End of Menu Bar functionality*
        ******************************/

        private void menuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gamePanel_Paint(object sender, PaintEventArgs e)
        {

        }

       public void gameOverScreen(int winner)
        {
            if (gameObj.GameEnd() == 2)
            {
                //black token won
                blackWinPanel.Visible = true;
                blackWinPanel.BringToFront();
                blackWinPanel.BackgroundImage = Properties.Resources.black_player_win_screen;
            }
            else if (gameObj.GameEnd() == 1)

            {
                //white token won
                blackWinPanel.Visible = true;
                blackWinPanel.BringToFront();
                blackWinPanel.BackgroundImage = Properties.Resources.white_player_win_screen;
            }
            else
            {
                //tie condition
                blackWinPanel.Visible = true;
                blackWinPanel.BringToFront();
                blackWinPanel.BackgroundImage = Properties.Resources.black_player_win_screen;
            }
        } 

        private void BoardSpaceClicker(object sender, EventArgs e)
        {
            if (tempObj.gameOver == true)
                gameOverScreen(tempObj.GameEnd());
            
            BoardSpace ClickedSpace = (BoardSpace)sender;
            tempObj.Run(ClickedSpace.getY(), ClickedSpace.getX());
            Console.WriteLine(tempObj.GameBoard.Spaces[ClickedSpace.getX(), ClickedSpace.getY()]);
            if (tempObj.activePlayer == 1)
            {
                TurnPicture.Image = global::doubleStuffed.Properties.Resources.white_turn;
            }
            else
            {
                TurnPicture.Image = global::doubleStuffed.Properties.Resources.black_turn;
            }
            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    //buttonArray[row, column].setState(---Board[row, column]);
                    int state = tempObj.GameBoard.Spaces[row, column]; //Actual
                    //int state = buttonArray[row, column].getState();
                    switch (state)
                    {
                        case 0:
                            buttonArray[row, column].BackgroundImage = null;
                            break;
                        case 1:
                            buttonArray[row, column].BackgroundImage = global::doubleStuffed.Properties.Resources.white_token;
                            break;
                        case 2:
                            buttonArray[row, column].BackgroundImage = global::doubleStuffed.Properties.Resources.black_token;
                            break;
                        case 3:
                            buttonArray[row, column].BackgroundImage = global::doubleStuffed.Properties.Resources.game_board_bg_cropped;
                            break;
                    }
                }
            }
            p1TokenCountToolStripMenuItem.Text = "Player 1: " + tempObj.GameBoard.p1TokenCount;
            p2TokenCountToolStripMenuItem.Text = "Player 2: " + tempObj.GameBoard.p2TokenCount;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveGameButton_Click(sender, e);
        }

        private void ruleHelpPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tempObj.GameBoard.InitBoard();
            Init2DBoard();
        }

        private void endGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameOverScreen(tempObj.GameEnd());
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
    
