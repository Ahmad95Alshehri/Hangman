namespace assig2
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
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.picHangman = new System.Windows.Forms.PictureBox();
            this.Guess = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.TextBox();
            this.lblNewWord = new System.Windows.Forms.TextBox();
            this.cmbWordFiles = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHangman)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(365, 105);
            this.txtGuess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(264, 22);
            this.txtGuess.TabIndex = 0;
            // 
            // picHangman
            // 
            this.picHangman.Location = new System.Drawing.Point(365, 205);
            this.picHangman.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picHangman.Name = "picHangman";
            this.picHangman.Size = new System.Drawing.Size(282, 230);
            this.picHangman.TabIndex = 1;
            this.picHangman.TabStop = false;
            // 
            // Guess
            // 
            this.Guess.Location = new System.Drawing.Point(788, 105);
            this.Guess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Guess.Name = "Guess";
            this.Guess.Size = new System.Drawing.Size(180, 53);
            this.Guess.TabIndex = 2;
            this.Guess.Text = "Guess Letter";
            this.Guess.UseVisualStyleBackColor = true;
            this.Guess.Click += new System.EventHandler(this.Guess_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(465, 532);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 56);
            this.button2.TabIndex = 4;
            this.button2.Text = "Quit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblScore
            // 
            this.lblScore.Location = new System.Drawing.Point(48, 316);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(169, 22);
            this.lblScore.TabIndex = 6;
            this.lblScore.TextChanged += new System.EventHandler(this.lblScore_TextChanged);
            // 
            // lblNewWord
            // 
            this.lblNewWord.Location = new System.Drawing.Point(48, 404);
            this.lblNewWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblNewWord.Name = "lblNewWord";
            this.lblNewWord.Size = new System.Drawing.Size(169, 22);
            this.lblNewWord.TabIndex = 7;
            this.lblNewWord.TextChanged += new System.EventHandler(this.lblNewWord_TextChanged);
            // 
            // cmbWordFiles
            // 
            this.cmbWordFiles.FormattingEnabled = true;
            this.cmbWordFiles.Location = new System.Drawing.Point(743, 411);
            this.cmbWordFiles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbWordFiles.Name = "cmbWordFiles";
            this.cmbWordFiles.Size = new System.Drawing.Size(257, 24);
            this.cmbWordFiles.TabIndex = 9;
            this.cmbWordFiles.Text = "cmbWordFiles";
            this.cmbWordFiles.SelectedIndexChanged += new System.EventHandler(this.cmbWordFiles_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1063, 774);
            this.Controls.Add(this.cmbWordFiles);
            this.Controls.Add(this.lblNewWord);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Guess);
            this.Controls.Add(this.picHangman);
            this.Controls.Add(this.txtGuess);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHangman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.PictureBox picHangman;
        private System.Windows.Forms.Button Guess;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox lblScore;
        private System.Windows.Forms.TextBox lblNewWord;
        private System.Windows.Forms.ComboBox cmbWordFiles;
    }
}

