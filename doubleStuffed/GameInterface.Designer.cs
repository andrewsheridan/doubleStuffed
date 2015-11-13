namespace doubleStuffed
{
    partial class GameInterface
    {
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
            this.rightHelpButton = new System.Windows.Forms.PictureBox();
            this.leftHelpButton = new System.Windows.Forms.PictureBox();
            this.gameMenuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpHyperlink = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.newGameButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadGameButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightHelpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftHelpButton)).BeginInit();
            this.gameMenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helpHyperlink)).BeginInit();
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
            // rightHelpButton
            // 
            this.rightHelpButton.BackColor = System.Drawing.Color.Transparent;
            this.rightHelpButton.Image = global::doubleStuffed.Properties.Resources.right_button_black;
            this.rightHelpButton.Location = new System.Drawing.Point(680, 460);
            this.rightHelpButton.Name = "rightHelpButton";
            this.rightHelpButton.Size = new System.Drawing.Size(100, 100);
            this.rightHelpButton.TabIndex = 4;
            this.rightHelpButton.TabStop = false;
            this.rightHelpButton.Visible = false;
            this.rightHelpButton.Click += new System.EventHandler(this.rightHelpButton_Click);
            this.rightHelpButton.MouseEnter += new System.EventHandler(this.rightHelpButton_MouseEnter);
            this.rightHelpButton.MouseLeave += new System.EventHandler(this.rightHelpButton_MouseLeave);
            // 
            // leftHelpButton
            // 
            this.leftHelpButton.BackColor = System.Drawing.Color.Transparent;
            this.leftHelpButton.Image = global::doubleStuffed.Properties.Resources.left_button_black;
            this.leftHelpButton.Location = new System.Drawing.Point(0, 460);
            this.leftHelpButton.Name = "leftHelpButton";
            this.leftHelpButton.Size = new System.Drawing.Size(100, 100);
            this.leftHelpButton.TabIndex = 5;
            this.leftHelpButton.TabStop = false;
            this.leftHelpButton.Visible = false;
            this.leftHelpButton.Click += new System.EventHandler(this.leftHelpButton_Click);
            this.leftHelpButton.MouseEnter += new System.EventHandler(this.leftHelpButton_MouseEnter);
            this.leftHelpButton.MouseLeave += new System.EventHandler(this.leftHelpButton_MouseLeave);
            // 
            // gameMenuBar
            // 
            this.gameMenuBar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gameMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.gameMenuBar.Location = new System.Drawing.Point(0, 0);
            this.gameMenuBar.Name = "gameMenuBar";
            this.gameMenuBar.Size = new System.Drawing.Size(784, 24);
            this.gameMenuBar.TabIndex = 6;
            this.gameMenuBar.Text = "Menu";
            this.gameMenuBar.Visible = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
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
            this.saveToolStripMenuItem.Text = "New Game";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // helpHyperlink
            // 
            this.helpHyperlink.BackColor = System.Drawing.Color.Transparent;
            this.helpHyperlink.Location = new System.Drawing.Point(394, 270);
            this.helpHyperlink.Name = "helpHyperlink";
            this.helpHyperlink.Size = new System.Drawing.Size(79, 38);
            this.helpHyperlink.TabIndex = 7;
            this.helpHyperlink.TabStop = false;
            this.helpHyperlink.Visible = false;
            this.helpHyperlink.Click += new System.EventHandler(this.helpHyperlink_Click);
            // 
            // GameInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::doubleStuffed.Properties.Resources.background_image_menu;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.helpHyperlink);
            this.Controls.Add(this.leftHelpButton);
            this.Controls.Add(this.rightHelpButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.loadGameButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.gameMenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.gameMenuBar;
            this.MaximizeBox = false;
            this.Name = "GameInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Double Stuff";
            ((System.ComponentModel.ISupportInitialize)(this.newGameButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadGameButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightHelpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftHelpButton)).EndInit();
            this.gameMenuBar.ResumeLayout(false);
            this.gameMenuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helpHyperlink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox newGameButton;
        private System.Windows.Forms.PictureBox loadGameButton;
        private System.Windows.Forms.PictureBox helpButton;
        private System.Windows.Forms.PictureBox quitButton;
        private System.Windows.Forms.PictureBox rightHelpButton;
        private System.Windows.Forms.PictureBox leftHelpButton;
        private System.Windows.Forms.MenuStrip gameMenuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.PictureBox helpHyperlink;
    }
}