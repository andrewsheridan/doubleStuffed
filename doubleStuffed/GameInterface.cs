using System;
using System.Windows.Forms;

namespace doubleStuffed
{
    public partial class GameInterface : Form
    {
        Game tempObj;
        public GameInterface(Game inEngine)
        {
            tempObj = inEngine;
            InitializeComponent();
            Init2DBoard();




        }

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

        private void menuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gamePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BoardSpaceClicker(object sender, EventArgs e)
        {
            BoardSpace ClickedSpace = (BoardSpace)sender;
            tempObj.Run(ClickedSpace.getY(), ClickedSpace.getX());
            Console.WriteLine(tempObj.GameBoard.Spaces[ClickedSpace.getX(), ClickedSpace.getY()]);
            //temp.setState(1);

            //Console.Write("Registered click at " + temp.getX() + ", " + temp.getY() + "| State: ");
            /*switch (temp.getState())
            {
                case 0:
                    Console.WriteLine("Empty");
                    break;
                case 1:
                    Console.WriteLine("White token");
                    break;
                case 2:
                    Console.WriteLine("Black token");
                    break;
                case 3:
                    Console.WriteLine("Valid space");
                    break;
            }*/
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
                            buttonArray[row, column].BackgroundImage = global::doubleStuffed.Properties.Resources.left_button_black;
                            break;
                    }
                }
            }
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
    }
}
    