namespace doubleStuffed
{
    partial class Form1
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
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colUpDown = new System.Windows.Forms.NumericUpDown();
            this.rowUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.flipTokenButton = new System.Windows.Forms.Button();
            this.commitMoveButton = new System.Windows.Forms.Button();
            this.flipCheckButton = new System.Windows.Forms.Button();
            this.checkSquareButton = new System.Windows.Forms.Button();
            this.checkBoardButton = new System.Windows.Forms.Button();
            this.yDirectionUpDown = new System.Windows.Forms.NumericUpDown();
            this.xDirectionUpDown = new System.Windows.Forms.NumericUpDown();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.xDirLabel = new System.Windows.Forms.Label();
            this.yDirLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.activePlayerUpDown = new System.Windows.Forms.NumericUpDown();
            this.checkSquareDirButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.colUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yDirectionUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xDirectionUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activePlayerUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(13, 13);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(145, 136);
            this.outputTextBox.TabIndex = 0;
            this.outputTextBox.Text = "OutputBox";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Col: ";
            // 
            // colUpDown
            // 
            this.colUpDown.Location = new System.Drawing.Point(215, 14);
            this.colUpDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.colUpDown.Name = "colUpDown";
            this.colUpDown.Size = new System.Drawing.Size(79, 20);
            this.colUpDown.TabIndex = 3;
            // 
            // rowUpDown
            // 
            this.rowUpDown.Location = new System.Drawing.Point(215, 40);
            this.rowUpDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.rowUpDown.Name = "rowUpDown";
            this.rowUpDown.Size = new System.Drawing.Size(79, 20);
            this.rowUpDown.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Row:";
            // 
            // flipTokenButton
            // 
            this.flipTokenButton.Location = new System.Drawing.Point(300, 14);
            this.flipTokenButton.Name = "flipTokenButton";
            this.flipTokenButton.Size = new System.Drawing.Size(110, 23);
            this.flipTokenButton.TabIndex = 6;
            this.flipTokenButton.Text = "Flip Token";
            this.flipTokenButton.UseVisualStyleBackColor = true;
            this.flipTokenButton.Click += new System.EventHandler(this.flipTokenButton_Click);
            // 
            // commitMoveButton
            // 
            this.commitMoveButton.Location = new System.Drawing.Point(300, 101);
            this.commitMoveButton.Name = "commitMoveButton";
            this.commitMoveButton.Size = new System.Drawing.Size(110, 23);
            this.commitMoveButton.TabIndex = 7;
            this.commitMoveButton.Text = "Commit Move";
            this.commitMoveButton.UseVisualStyleBackColor = true;
            this.commitMoveButton.Click += new System.EventHandler(this.commitMoveButton_Click);
            // 
            // flipCheckButton
            // 
            this.flipCheckButton.Location = new System.Drawing.Point(300, 43);
            this.flipCheckButton.Name = "flipCheckButton";
            this.flipCheckButton.Size = new System.Drawing.Size(110, 23);
            this.flipCheckButton.TabIndex = 8;
            this.flipCheckButton.Text = "Flip Check";
            this.flipCheckButton.UseVisualStyleBackColor = true;
            this.flipCheckButton.Click += new System.EventHandler(this.flipCheckButton_Click);
            // 
            // checkSquareButton
            // 
            this.checkSquareButton.Location = new System.Drawing.Point(300, 72);
            this.checkSquareButton.Name = "checkSquareButton";
            this.checkSquareButton.Size = new System.Drawing.Size(110, 23);
            this.checkSquareButton.TabIndex = 9;
            this.checkSquareButton.Text = "Check Square";
            this.checkSquareButton.UseVisualStyleBackColor = true;
            this.checkSquareButton.Click += new System.EventHandler(this.checkSquareButton_Click);
            // 
            // checkBoardButton
            // 
            this.checkBoardButton.Location = new System.Drawing.Point(12, 155);
            this.checkBoardButton.Name = "checkBoardButton";
            this.checkBoardButton.Size = new System.Drawing.Size(146, 23);
            this.checkBoardButton.TabIndex = 10;
            this.checkBoardButton.Text = "Check Board";
            this.checkBoardButton.UseVisualStyleBackColor = true;
            this.checkBoardButton.Click += new System.EventHandler(this.checkBoardButton_Click);
            // 
            // yDirectionUpDown
            // 
            this.yDirectionUpDown.Location = new System.Drawing.Point(215, 94);
            this.yDirectionUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yDirectionUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.yDirectionUpDown.Name = "yDirectionUpDown";
            this.yDirectionUpDown.Size = new System.Drawing.Size(79, 20);
            this.yDirectionUpDown.TabIndex = 12;
            // 
            // xDirectionUpDown
            // 
            this.xDirectionUpDown.Location = new System.Drawing.Point(215, 68);
            this.xDirectionUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.xDirectionUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.xDirectionUpDown.Name = "xDirectionUpDown";
            this.xDirectionUpDown.Size = new System.Drawing.Size(79, 20);
            this.xDirectionUpDown.TabIndex = 11;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(165, 157);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(245, 20);
            this.messageTextBox.TabIndex = 13;
            this.messageTextBox.Text = "MessageBox";
            // 
            // xDirLabel
            // 
            this.xDirLabel.AutoSize = true;
            this.xDirLabel.Location = new System.Drawing.Point(181, 70);
            this.xDirLabel.Name = "xDirLabel";
            this.xDirLabel.Size = new System.Drawing.Size(28, 13);
            this.xDirLabel.TabIndex = 14;
            this.xDirLabel.Text = "xDir:";
            // 
            // yDirLabel
            // 
            this.yDirLabel.AutoSize = true;
            this.yDirLabel.Location = new System.Drawing.Point(181, 96);
            this.yDirLabel.Name = "yDirLabel";
            this.yDirLabel.Size = new System.Drawing.Size(28, 13);
            this.yDirLabel.TabIndex = 15;
            this.yDirLabel.Text = "yDir:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Player:";
            // 
            // activePlayerUpDown
            // 
            this.activePlayerUpDown.Location = new System.Drawing.Point(215, 120);
            this.activePlayerUpDown.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.activePlayerUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.activePlayerUpDown.Name = "activePlayerUpDown";
            this.activePlayerUpDown.Size = new System.Drawing.Size(79, 20);
            this.activePlayerUpDown.TabIndex = 16;
            this.activePlayerUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkSquareDirButton
            // 
            this.checkSquareDirButton.Location = new System.Drawing.Point(300, 130);
            this.checkSquareDirButton.Name = "checkSquareDirButton";
            this.checkSquareDirButton.Size = new System.Drawing.Size(110, 23);
            this.checkSquareDirButton.TabIndex = 18;
            this.checkSquareDirButton.Text = "Check Square Dir";
            this.checkSquareDirButton.UseVisualStyleBackColor = true;
            this.checkSquareDirButton.Click += new System.EventHandler(this.checkSquareDirButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 189);
            this.Controls.Add(this.checkSquareDirButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.activePlayerUpDown);
            this.Controls.Add(this.yDirLabel);
            this.Controls.Add(this.xDirLabel);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.yDirectionUpDown);
            this.Controls.Add(this.xDirectionUpDown);
            this.Controls.Add(this.checkBoardButton);
            this.Controls.Add(this.checkSquareButton);
            this.Controls.Add(this.flipCheckButton);
            this.Controls.Add(this.commitMoveButton);
            this.Controls.Add(this.flipTokenButton);
            this.Controls.Add(this.rowUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.colUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.colUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yDirectionUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xDirectionUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activePlayerUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown colUpDown;
        private System.Windows.Forms.NumericUpDown rowUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button flipTokenButton;
        private System.Windows.Forms.Button commitMoveButton;
        private System.Windows.Forms.Button flipCheckButton;
        private System.Windows.Forms.Button checkSquareButton;
        private System.Windows.Forms.Button checkBoardButton;
        private System.Windows.Forms.NumericUpDown yDirectionUpDown;
        private System.Windows.Forms.NumericUpDown xDirectionUpDown;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label xDirLabel;
        private System.Windows.Forms.Label yDirLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown activePlayerUpDown;
        private System.Windows.Forms.Button checkSquareDirButton;
    }
}

