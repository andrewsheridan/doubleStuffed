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
    public partial class Form1 : Form
    {
        Board gameBoard = new Board();
        public Form1()
        {
            InitializeComponent();
            outputTextBox.Text = gameBoard.BoardString();
        }

        private void outputBoardButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = gameBoard.BoardString();
        }

        private void flipTokenButton_Click(object sender, EventArgs e)
        {
            gameBoard.FlipToken((int)colUpDown.Value, (int)rowUpDown.Value);
            outputTextBox.Text = gameBoard.BoardString();
        }

        private void flipCheckButton_Click(object sender, EventArgs e)
        {
            bool output = gameBoard.FlipCheck((int)colUpDown.Value, (int)rowUpDown.Value
                , (int)xDirectionUpDown.Value, (int)yDirectionUpDown.Value, (int)activePlayerUpDown.Value);
            if (output == true)
                messageTextBox.Text = "True";
            else
                messageTextBox.Text = "False";
        }

        private void checkSquareButton_Click(object sender, EventArgs e)
        {
            bool output = gameBoard.CheckSquare((int)colUpDown.Value, (int)rowUpDown.Value, (int)activePlayerUpDown.Value);
            outputTextBox.Text = gameBoard.BoardString();
            if (output == true)
                messageTextBox.Text = "True";
            else
                messageTextBox.Text = "False";
        }

        private void commitMoveButton_Click(object sender, EventArgs e)
        {
            gameBoard.CommitMove((int)colUpDown.Value, (int)rowUpDown.Value, (int)activePlayerUpDown.Value);
            outputTextBox.Text = gameBoard.BoardString();
        }

        private void checkBoardButton_Click(object sender, EventArgs e)
        {
            bool existsValidMove = gameBoard.CheckBoard((int)activePlayerUpDown.Value);
            if (existsValidMove == true)
                messageTextBox.Text = "True";
            else
                messageTextBox.Text = "False";
            outputTextBox.Text = gameBoard.BoardString();
        }

        private void checkSquareDirButton_Click(object sender, EventArgs e)
        {
            bool output = gameBoard.CheckSquareDir((int)colUpDown.Value, (int)rowUpDown.Value
                , (int)xDirectionUpDown.Value, (int)yDirectionUpDown.Value, (int)activePlayerUpDown.Value);
            if (output == true)
                messageTextBox.Text = "True";
            else
                messageTextBox.Text = "False";
            outputTextBox.Text = gameBoard.BoardString();
        }
    }
}
