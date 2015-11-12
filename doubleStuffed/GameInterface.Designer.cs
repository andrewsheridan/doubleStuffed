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
            ((System.ComponentModel.ISupportInitialize)(this.newGameButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadGameButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quitButton)).BeginInit();
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
            // GameInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::doubleStuffed.Properties.Resources.background_image_menu;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.loadGameButton);
            this.Controls.Add(this.newGameButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Double Stuff";
            ((System.ComponentModel.ISupportInitialize)(this.newGameButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadGameButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quitButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox newGameButton;
        private System.Windows.Forms.PictureBox loadGameButton;
        private System.Windows.Forms.PictureBox helpButton;
        private System.Windows.Forms.PictureBox quitButton;
    }
}