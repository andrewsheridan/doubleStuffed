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
            this.outputBoardButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.colUpDown = new System.Windows.Forms.NumericUpDown();
            this.rowUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.flipTokenButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.colUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(13, 13);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(131, 122);
            this.outputTextBox.TabIndex = 0;
            // 
            // outputBoardButton
            // 
            this.outputBoardButton.Location = new System.Drawing.Point(13, 141);
            this.outputBoardButton.Name = "outputBoardButton";
            this.outputBoardButton.Size = new System.Drawing.Size(131, 22);
            this.outputBoardButton.TabIndex = 1;
            this.outputBoardButton.Text = "Output Board";
            this.outputBoardButton.UseVisualStyleBackColor = true;
            this.outputBoardButton.Click += new System.EventHandler(this.outputBoardButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Col: ";
            // 
            // colUpDown
            // 
            this.colUpDown.Location = new System.Drawing.Point(198, 14);
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
            this.rowUpDown.Location = new System.Drawing.Point(198, 35);
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
            this.label2.Location = new System.Drawing.Point(164, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Row:";
            // 
            // flipTokenButton
            // 
            this.flipTokenButton.Location = new System.Drawing.Point(167, 58);
            this.flipTokenButton.Name = "flipTokenButton";
            this.flipTokenButton.Size = new System.Drawing.Size(110, 23);
            this.flipTokenButton.TabIndex = 6;
            this.flipTokenButton.Text = "Flip Token";
            this.flipTokenButton.UseVisualStyleBackColor = true;
            this.flipTokenButton.Click += new System.EventHandler(this.flipTokenButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(167, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 172);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flipTokenButton);
            this.Controls.Add(this.rowUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.colUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputBoardButton);
            this.Controls.Add(this.outputTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.colUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button outputBoardButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown colUpDown;
        private System.Windows.Forms.NumericUpDown rowUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button flipTokenButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

