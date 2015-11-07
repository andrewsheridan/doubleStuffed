﻿using System;
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
            gameBoard.FlipCheck((int)colUpDown.Value, (int)rowUpDown.Value, (int)xDirectionUpDown.Value, (int)yDirectionUpDown.Value);
        }

        private void checkSquareButton_Click(object sender, EventArgs e)
        {
            gameBoard.CheckSquare((int)colUpDown.Value, (int)rowUpDown.Value);
            outputTextBox.Text = gameBoard.BoardString();
        }

        private void commitMoveButton_Click(object sender, EventArgs e)
        {
            gameBoard.CommitMove((int)colUpDown.Value, (int)rowUpDown.Value);
            outputTextBox.Text = gameBoard.BoardString();
        }

        private void checkBoardButton_Click(object sender, EventArgs e)
        {
            bool existsValidMove = gameBoard.CheckBoard();
            if (existsValidMove == true)
                messageTextBox.Text = "True";
            else
                messageTextBox.Text = "False";
        }
    }
}
