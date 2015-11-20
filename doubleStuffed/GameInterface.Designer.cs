using System.Drawing;

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
            this.BS0x0 = new BoardSpace();
            this.BoardGridPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.newGameButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadGameButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quitButton)).BeginInit();
            this.menuPanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoardGridPicture)).BeginInit();
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
            this.gamePanel.Controls.Add(this.BS0x0);
            this.gamePanel.Controls.Add(this.BoardGridPicture);
            this.gamePanel.Location = new System.Drawing.Point(0, 0);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(785, 560);
            this.gamePanel.TabIndex = 5;
            this.gamePanel.Visible = false;
            this.gamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gamePanel_Paint);
            // 
            // BS0x0
            // 
            this.BS0x0.BackColor = System.Drawing.Color.Transparent;
            this.BS0x0.BackgroundImage = global::doubleStuffed.Properties.Resources.black_token;
            this.BS0x0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BS0x0.FlatAppearance.BorderSize = 0;
            this.BS0x0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BS0x0.Image = global::doubleStuffed.Properties.Resources.white_token;
            this.BS0x0.Location = new System.Drawing.Point(37, 144);
            this.BS0x0.Name = "BS0x0";
            this.BS0x0.Size = new System.Drawing.Size(45, 45);
            this.BS0x0.TabIndex = 1;
            this.BS0x0.Text = "boardSpace2";
            this.BS0x0.UseVisualStyleBackColor = false;
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
            // 
            // GameInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::doubleStuffed.Properties.Resources.background_image_menu;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Double Stuff";
            ((System.ComponentModel.ISupportInitialize)(this.newGameButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadGameButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quitButton)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.gamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BoardGridPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private void Init2DBoard()
        {
            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    buttonArray[row, column] = new BoardSpace(column, row);
                    buttonArray[row, column].Size = new Size(40, 40);
                    buttonArray[row, column].Location = new Point(36 + column * 50, 143 + row * 50);
                    this.Controls.Add(buttonArray[row, column]);
                    buttonArray[row, column].Click += BoardSpaceClicker;
                    this.gamePanel.Controls.Add(buttonArray[row, column]);

                    buttonArray[row, column].BringToFront();
                    //buttonArray[row, column].BackColor = System.Drawing.Color.Transparent;
                    buttonArray[row, column].FlatAppearance.BorderSize = 0;
                    buttonArray[row, column].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    if ((row == 3 && column == 3 )|| (row == 4 && column == 4))
                    {
                        buttonArray[row, column].BackgroundImage = global::doubleStuffed.Properties.Resources.white_token;
                        buttonArray[row, column].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                        buttonArray[row, column].setState(1);
                    }
                    else if ((row == 3 && column == 4) || (row == 4 && column == 3))
                    {
                        buttonArray[row, column].BackgroundImage = global::doubleStuffed.Properties.Resources.black_token;
                        buttonArray[row, column].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                        buttonArray[row, column].setState(2);
                    }
                    else
                    {
                        //buttonArray[row, column].BackgroundImage = null;
                        buttonArray[row, column].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                        buttonArray[row, column].setState(0);
                    }
                    //BoardGridPicture.BringToFront();
                }
            }
        }

        private System.Windows.Forms.PictureBox newGameButton;
        private System.Windows.Forms.PictureBox loadGameButton;
        private System.Windows.Forms.PictureBox helpButton;
        private System.Windows.Forms.PictureBox quitButton;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel gamePanel;
        private BoardSpace BS0x0;
        private System.Windows.Forms.PictureBox BoardGridPicture;
    }
}