﻿using System.Drawing;

namespace doubleStuffed
{
    partial class GameInterface
    {
        private BoardSpace[,] buttonArray = new BoardSpace[8, 8];

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameInterface));
            this.newGameButton = new System.Windows.Forms.PictureBox();
            this.loadGameButton = new System.Windows.Forms.PictureBox();
            this.helpButton = new System.Windows.Forms.PictureBox();
            this.quitButton = new System.Windows.Forms.PictureBox();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.p2TokenCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.p1TokenCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.winningPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TurnPicture = new System.Windows.Forms.PictureBox();
            this.BoardGridPicture = new System.Windows.Forms.PictureBox();
            this.gameplayHelpPanel = new System.Windows.Forms.Panel();
            this.ruleHelpPanel = new System.Windows.Forms.Panel();
            this.leftButtonRules = new System.Windows.Forms.PictureBox();
            this.rightButtonRules = new System.Windows.Forms.PictureBox();
            this.openRulesButton = new System.Windows.Forms.PictureBox();
            this.blackWinPanel = new System.Windows.Forms.Panel();
            this.rightHelpButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.newGameButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadGameButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quitButton)).BeginInit();
            this.menuPanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TurnPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoardGridPicture)).BeginInit();
            this.gameplayHelpPanel.SuspendLayout();
            this.ruleHelpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftButtonRules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightButtonRules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openRulesButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightHelpButton)).BeginInit();
            this.SuspendLayout();
            // 
            // newGameButton
            // 
            this.newGameButton.BackColor = System.Drawing.Color.Transparent;
            this.newGameButton.Image = global::doubleStuffed.Properties.Resources.new_game_black;
            this.newGameButton.Location = new System.Drawing.Point(285, 200);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(230, 40);
            this.newGameButton.TabIndex = 0;
            this.newGameButton.TabStop = false;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            this.newGameButton.MouseEnter += new System.EventHandler(this.newGameButton_MouseEnter);
            this.newGameButton.MouseLeave += new System.EventHandler(this.newGameButton_MouseLeave);
            // 
            // loadGameButton
            // 
            this.loadGameButton.BackColor = System.Drawing.Color.Transparent;
            this.loadGameButton.Image = global::doubleStuffed.Properties.Resources.load_game_black;
            this.loadGameButton.Location = new System.Drawing.Point(275, 280);
            this.loadGameButton.Name = "loadGameButton";
            this.loadGameButton.Size = new System.Drawing.Size(250, 40);
            this.loadGameButton.TabIndex = 1;
            this.loadGameButton.TabStop = false;
            this.loadGameButton.Click += new System.EventHandler(this.loadGameButton_Click);
            this.loadGameButton.MouseEnter += new System.EventHandler(this.loadGameButton_MouseEnter);
            this.loadGameButton.MouseLeave += new System.EventHandler(this.loadGameButton_MouseLeave);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.Transparent;
            this.helpButton.Image = global::doubleStuffed.Properties.Resources.help_black;
            this.helpButton.Location = new System.Drawing.Point(285, 360);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(230, 40);
            this.helpButton.TabIndex = 2;
            this.helpButton.TabStop = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            this.helpButton.MouseEnter += new System.EventHandler(this.helpButton_MouseEnter);
            this.helpButton.MouseLeave += new System.EventHandler(this.helpButton_MouseLeave);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.Transparent;
            this.quitButton.Image = global::doubleStuffed.Properties.Resources.quit_black;
            this.quitButton.Location = new System.Drawing.Point(285, 440);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(230, 40);
            this.quitButton.TabIndex = 3;
            this.quitButton.TabStop = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            this.quitButton.MouseEnter += new System.EventHandler(this.quitButton_MouseEnter);
            this.quitButton.MouseLeave += new System.EventHandler(this.quitButton_MouseLeave);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.Transparent;
            this.menuPanel.BackgroundImage = global::doubleStuffed.Properties.Resources.background_image_menu;
            this.menuPanel.Controls.Add(this.quitButton);
            this.menuPanel.Controls.Add(this.newGameButton);
            this.menuPanel.Controls.Add(this.helpButton);
            this.menuPanel.Controls.Add(this.loadGameButton);
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(785, 560);
            this.menuPanel.TabIndex = 4;
            this.menuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.menuPanel_Paint);
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.Transparent;
            this.gamePanel.BackgroundImage = global::doubleStuffed.Properties.Resources.game_board_bg;
            this.gamePanel.Controls.Add(this.menuStrip1);
            this.gamePanel.Controls.Add(this.TurnPicture);
            this.gamePanel.Controls.Add(this.BoardGridPicture);
            this.gamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamePanel.Location = new System.Drawing.Point(0, 0);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(784, 561);
            this.gamePanel.TabIndex = 5;
            this.gamePanel.Visible = false;
            this.gamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gamePanel_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.p2TokenCountToolStripMenuItem,
            this.p1TokenCountToolStripMenuItem,
            this.winningPlayerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "gameMenuBar";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.mainMenuToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.endGameToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveGameButton_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // endGameToolStripMenuItem
            // 
            this.endGameToolStripMenuItem.Name = "endGameToolStripMenuItem";
            this.endGameToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.endGameToolStripMenuItem.Text = "End Game";
            this.endGameToolStripMenuItem.Visible = false;
            this.endGameToolStripMenuItem.Click += new System.EventHandler(this.endGameToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // p2TokenCountToolStripMenuItem
            // 
            this.p2TokenCountToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.p2TokenCountToolStripMenuItem.Name = "p2TokenCountToolStripMenuItem";
            this.p2TokenCountToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.p2TokenCountToolStripMenuItem.Text = "Player 2 ";
            // 
            // p1TokenCountToolStripMenuItem
            // 
            this.p1TokenCountToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.p1TokenCountToolStripMenuItem.Name = "p1TokenCountToolStripMenuItem";
            this.p1TokenCountToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.p1TokenCountToolStripMenuItem.Text = "Player 1 ";
            // 
            // winningPlayerToolStripMenuItem
            // 
            this.winningPlayerToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.winningPlayerToolStripMenuItem.Name = "winningPlayerToolStripMenuItem";
            this.winningPlayerToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // TurnPicture
            // 
            this.TurnPicture.Image = global::doubleStuffed.Properties.Resources.black_turn;
            this.TurnPicture.Location = new System.Drawing.Point(606, 49);
            this.TurnPicture.Name = "TurnPicture";
            this.TurnPicture.Size = new System.Drawing.Size(100, 500);
            this.TurnPicture.TabIndex = 3;
            this.TurnPicture.TabStop = false;
            // 
            // BoardGridPicture
            // 
            this.BoardGridPicture.BackColor = System.Drawing.Color.Transparent;
            this.BoardGridPicture.BackgroundImage = global::doubleStuffed.Properties.Resources.game_board_bg_cropped_trans;
            this.BoardGridPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BoardGridPicture.Location = new System.Drawing.Point(25, 133);
            this.BoardGridPicture.Name = "BoardGridPicture";
            this.BoardGridPicture.Size = new System.Drawing.Size(411, 411);
            this.BoardGridPicture.TabIndex = 2;
            this.BoardGridPicture.TabStop = false;
            this.BoardGridPicture.Visible = false;
            // 
            // gameplayHelpPanel
            // 
            this.gameplayHelpPanel.BackgroundImage = global::doubleStuffed.Properties.Resources.gameplay_help_menu;
            this.gameplayHelpPanel.Controls.Add(this.ruleHelpPanel);
            this.gameplayHelpPanel.Controls.Add(this.rightHelpButton);
            this.gameplayHelpPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameplayHelpPanel.Location = new System.Drawing.Point(0, 0);
            this.gameplayHelpPanel.Name = "gameplayHelpPanel";
            this.gameplayHelpPanel.Size = new System.Drawing.Size(784, 561);
            this.gameplayHelpPanel.TabIndex = 6;
            this.gameplayHelpPanel.Visible = false;
            // 
            // ruleHelpPanel
            // 
            this.ruleHelpPanel.BackColor = System.Drawing.Color.Transparent;
            this.ruleHelpPanel.BackgroundImage = global::doubleStuffed.Properties.Resources.rules_help_menu;
            this.ruleHelpPanel.Controls.Add(this.leftButtonRules);
            this.ruleHelpPanel.Controls.Add(this.rightButtonRules);
            this.ruleHelpPanel.Controls.Add(this.openRulesButton);
            this.ruleHelpPanel.Controls.Add(this.blackWinPanel);
            this.ruleHelpPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ruleHelpPanel.Location = new System.Drawing.Point(0, 0);
            this.ruleHelpPanel.Name = "ruleHelpPanel";
            this.ruleHelpPanel.Size = new System.Drawing.Size(784, 561);
            this.ruleHelpPanel.TabIndex = 1;
            this.ruleHelpPanel.Visible = false;
            this.ruleHelpPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ruleHelpPanel_Paint);
            // 
            // leftButtonRules
            // 
            this.leftButtonRules.Image = global::doubleStuffed.Properties.Resources.left_button_black;
            this.leftButtonRules.Location = new System.Drawing.Point(0, 461);
            this.leftButtonRules.Name = "leftButtonRules";
            this.leftButtonRules.Size = new System.Drawing.Size(100, 100);
            this.leftButtonRules.TabIndex = 2;
            this.leftButtonRules.TabStop = false;
            this.leftButtonRules.Click += new System.EventHandler(this.leftButtonRules_Click);
            this.leftButtonRules.MouseEnter += new System.EventHandler(this.leftButtonRules_MouseEnter);
            this.leftButtonRules.MouseLeave += new System.EventHandler(this.leftButtonRules_MouseLeave);
            // 
            // rightButtonRules
            // 
            this.rightButtonRules.Image = global::doubleStuffed.Properties.Resources.right_button_black;
            this.rightButtonRules.Location = new System.Drawing.Point(685, 461);
            this.rightButtonRules.Name = "rightButtonRules";
            this.rightButtonRules.Size = new System.Drawing.Size(100, 100);
            this.rightButtonRules.TabIndex = 1;
            this.rightButtonRules.TabStop = false;
            this.rightButtonRules.Click += new System.EventHandler(this.rightButtonRules_Click);
            this.rightButtonRules.MouseEnter += new System.EventHandler(this.rightButtonRules_MouseEnter);
            this.rightButtonRules.MouseLeave += new System.EventHandler(this.rightButtonRules_MouseLeave);
            // 
            // openRulesButton
            // 
            this.openRulesButton.Location = new System.Drawing.Point(398, 270);
            this.openRulesButton.Name = "openRulesButton";
            this.openRulesButton.Size = new System.Drawing.Size(75, 38);
            this.openRulesButton.TabIndex = 0;
            this.openRulesButton.TabStop = false;
            this.openRulesButton.Click += new System.EventHandler(this.openRulesButton_Click);
            // 
            // blackWinPanel
            // 
            this.blackWinPanel.BackgroundImage = global::doubleStuffed.Properties.Resources.black_player_win_screen;
            this.blackWinPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.blackWinPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blackWinPanel.Location = new System.Drawing.Point(0, 0);
            this.blackWinPanel.Margin = new System.Windows.Forms.Padding(2);
            this.blackWinPanel.Name = "blackWinPanel";
            this.blackWinPanel.Size = new System.Drawing.Size(784, 561);
            this.blackWinPanel.TabIndex = 3;
            this.blackWinPanel.Visible = false;
            // 
            // rightHelpButton
            // 
            this.rightHelpButton.BackColor = System.Drawing.Color.Transparent;
            this.rightHelpButton.BackgroundImage = global::doubleStuffed.Properties.Resources.right_button_black;
            this.rightHelpButton.Location = new System.Drawing.Point(685, 461);
            this.rightHelpButton.Name = "rightHelpButton";
            this.rightHelpButton.Size = new System.Drawing.Size(100, 100);
            this.rightHelpButton.TabIndex = 0;
            this.rightHelpButton.TabStop = false;
            this.rightHelpButton.Click += new System.EventHandler(this.rightHelpButton_Click);
            this.rightHelpButton.MouseEnter += new System.EventHandler(this.rightHelpButton_MouseEnter);
            this.rightHelpButton.MouseLeave += new System.EventHandler(this.rightHelpButton_MouseLeave);
            // 
            // GameInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gameplayHelpPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.gamePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "GameInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Double Stuff";
            this.Load += new System.EventHandler(this.GameInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newGameButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadGameButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quitButton)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TurnPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoardGridPicture)).EndInit();
            this.gameplayHelpPanel.ResumeLayout(false);
            this.ruleHelpPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leftButtonRules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightButtonRules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openRulesButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightHelpButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private void Init2DBoard()
        {
            this.TurnPicture.Image = global::doubleStuffed.Properties.Resources.black_turn;
            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    buttonArray[row, column] = new BoardSpace(column, row);
                    buttonArray[row, column].Size = new Size(58, 58);
                    buttonArray[row, column].Location = new Point(84 + column * 62, 55 + row * 62);
                    this.Controls.Add(buttonArray[row, column]);
                    buttonArray[row, column].Click += BoardSpaceClicker;
                    this.gamePanel.Controls.Add(buttonArray[row, column]);

                    buttonArray[row, column].BringToFront();
                    buttonArray[row, column].FlatAppearance.BorderSize = 0;
                    buttonArray[row, column].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    buttonArray[row, column].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    int state = tempObj.GameBoard.Spaces[row, column];
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

        private System.Windows.Forms.PictureBox newGameButton;
        private System.Windows.Forms.PictureBox loadGameButton;
        private System.Windows.Forms.PictureBox helpButton;
        private System.Windows.Forms.PictureBox quitButton;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.PictureBox BoardGridPicture;
        private System.Windows.Forms.Panel gameplayHelpPanel;
        private System.Windows.Forms.PictureBox rightHelpButton;
        private System.Windows.Forms.Panel ruleHelpPanel;
        private System.Windows.Forms.PictureBox openRulesButton;
        private System.Windows.Forms.PictureBox leftButtonRules;
        private System.Windows.Forms.PictureBox rightButtonRules;
        private System.Windows.Forms.PictureBox TurnPicture;
        private System.Windows.Forms.Panel blackWinPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem p1TokenCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem p2TokenCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem winningPlayerToolStripMenuItem;
    }
}