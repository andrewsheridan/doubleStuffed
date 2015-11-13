using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doubleStuffed
{
    public partial class GameInterface : Form
    {
        private Image helpMenu = Properties.Resources.gameplay_help_menu; //Required to be explicitly created here for help menu buttons to function properly.

        public GameInterface()
        {
            InitializeComponent();
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

        private void quitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            hideMainMenu();
            displayHelpMenu();            
        }
        
        private void rightHelpButton_MouseEnter(object sender, EventArgs e)
        {
            rightHelpButton.Image = Properties.Resources.right_button_white;
        }

        private void rightHelpButton_MouseLeave(object sender, EventArgs e)
        {
            rightHelpButton.Image = Properties.Resources.right_button_black;
        }

        //Changes the background image and buttons shown depending on what stage of the help menu the user is on
        private void rightHelpButton_Click(object sender, EventArgs e)
        {
            if(BackgroundImage.Equals(helpMenu))
            {
                BackgroundImage = Properties.Resources.rules_help_menu;
                leftHelpButton.Show();
                helpHyperlink.Show();
            }
            else
            {
                leftHelpButton.Hide();
                rightHelpButton.Hide();
                helpHyperlink.Hide();
                showMainMenu();
            }
        }

        private void leftHelpButton_Click(object sender, EventArgs e)
        {
            leftHelpButton.Hide();
            helpHyperlink.Hide();
            BackgroundImage = helpMenu;
        }

        private void leftHelpButton_MouseEnter(object sender, EventArgs e)
        {
            leftHelpButton.Image = Properties.Resources.left_button_white;
        }

        private void leftHelpButton_MouseLeave(object sender, EventArgs e)
        {
            leftHelpButton.Image = Properties.Resources.left_button_black;
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            hideMainMenu();
            showGameBoard();
        }

        private void helpHyperlink_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Reversi#Rules");
            }
            catch { }
        }
        /***********************************
        *End of basic Menu button functions*
        ***********************************/

        /***********************
        *Menu Bar functionality*
        ***********************/
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameMenuBar.Hide();
            showMainMenu();
        }
        /******************************
        *End of Menu Bar functionality*
        ******************************/

        //hide all the buttons from the main menu, change of form background image still required elsewhere.
        private void hideMainMenu()
        {
            quitButton.Hide();
            helpButton.Hide();
            newGameButton.Hide();
            loadGameButton.Hide();
        }

        //Show main menu
        private void showMainMenu()
        {
            BackgroundImage = Properties.Resources.background_image_menu;
            quitButton.Show();
            helpButton.Show();
            newGameButton.Show();
            loadGameButton.Show();
        }

        //show help menu
        private void displayHelpMenu()
        {
            BackgroundImage = helpMenu;
            rightHelpButton.Show();
        }

        //show gameboard (only needed when first changing "screen")
        private void showGameBoard()
        {
            BackgroundImage = Properties.Resources.game_board_bg;
            gameMenuBar.Show();
        }
    }
}
