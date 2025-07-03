namespace Wordy
{
    partial class Game
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pbHangman = new System.Windows.Forms.PictureBox();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.pnlLetters = new System.Windows.Forms.Panel();
            this.btnHint = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHangman)).BeginInit();
            this.SuspendLayout();

            // pbHangman
            this.pbHangman.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbHangman.Location = new System.Drawing.Point(20, 20);
            this.pbHangman.Size = new System.Drawing.Size(150, 150);
            this.pbHangman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHangman.TabIndex = 0;
            this.pbHangman.TabStop = false;

            // lblWord
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWord.Location = new System.Drawing.Point(200, 50);
            this.lblWord.TabIndex = 1;

            // lblHint
            this.lblHint.AutoSize = true;
            this.lblHint.Location = new System.Drawing.Point(200, 100);
            this.lblHint.TabIndex = 2;

            // lblIncorrect
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.Location = new System.Drawing.Point(200, 130);
            this.lblIncorrect.TabIndex = 3;

            // lblScore
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(350, 20);
            this.lblScore.TabIndex = 4;

            // pnlLetters
            this.pnlLetters.Location = new System.Drawing.Point(20, 200);
            this.pnlLetters.Size = new System.Drawing.Size(450, 120);
            this.pnlLetters.TabIndex = 5;

            // btnHint
            this.btnHint.Location = new System.Drawing.Point(180, 350);
            this.btnHint.Size = new System.Drawing.Size(80, 40);
            this.btnHint.TabIndex = 6;
            this.btnHint.Text = "Hint (-2)";
            this.btnHint.UseVisualStyleBackColor = true;

            // btnReset
            this.btnReset.Location = new System.Drawing.Point(280, 350);
            this.btnReset.Size = new System.Drawing.Size(80, 40);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;

            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.pnlLetters);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblIncorrect);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.pbHangman);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "Word Guessing Game";
            ((System.ComponentModel.ISupportInitialize)(this.pbHangman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox pbHangman;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Label lblIncorrect;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Panel pnlLetters;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.Button btnReset;
    }
}