﻿using System;
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

        private void BoardSpaceClicker(object sender, EventArgs e)
        {
            BoardSpace ClickedSpace = (BoardSpace)sender;
            tempObj.Run(ClickedSpace.getY(), ClickedSpace.getX());
            if (tempObj.activePlayer == 1)
            {
                TurnPicture.Image = global::doubleStuffed.Properties.Resources.white_turn;
            }
            else
            {
                TurnPicture.Image = global::doubleStuffed.Properties.Resources.black_turn;
            }
            Console.WriteLine(tempObj.GameBoard.Spaces[ClickedSpace.getX(), ClickedSpace.getY()]);
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
                            buttonArray[row, column].BackgroundImage = Properties.Resources.game_board_bg_cropped;
                            break;
                    }
                }
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tempObj.GameBoard.InitBoard();
            Init2DBoard();
        }
    }
}
    