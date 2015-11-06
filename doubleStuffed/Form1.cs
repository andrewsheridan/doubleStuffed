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
    }
}
