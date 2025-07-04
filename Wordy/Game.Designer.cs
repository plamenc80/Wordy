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
            pbHangman = new PictureBox();
            lblWord = new Label();
            lblHint = new Label();
            lblIncorrect = new Label();
            lblScore = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbHangman).BeginInit();
            SuspendLayout();
            // 
            // pbHangman
            // 
            pbHangman.BorderStyle = BorderStyle.FixedSingle;
            pbHangman.Image = Properties.Resources.стоян;
            pbHangman.Location = new Point(12, 30);
            pbHangman.Name = "pbHangman";
            pbHangman.Size = new Size(150, 150);
            pbHangman.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHangman.TabIndex = 0;
            pbHangman.TabStop = false;
            // 
            // lblWord
            // 
            lblWord.AutoSize = true;
            lblWord.Font = new Font("Consolas", 18F, FontStyle.Bold);
            lblWord.Location = new Point(200, 50);
            lblWord.Name = "lblWord";
            lblWord.Size = new Size(0, 36);
            lblWord.TabIndex = 1;
            // 
            // lblHint
            // 
            lblHint.AutoSize = true;
            lblHint.Location = new Point(200, 100);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(0, 23);
            lblHint.TabIndex = 2;
            // 
            // lblIncorrect
            // 
            lblIncorrect.AutoSize = true;
            lblIncorrect.Location = new Point(200, 130);
            lblIncorrect.Name = "lblIncorrect";
            lblIncorrect.Size = new Size(0, 23);
            lblIncorrect.TabIndex = 3;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(290, 10);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(0, 23);
            lblScore.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(186, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(30, 30);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Wide Latin", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(319, 340);
            button1.Name = "button1";
            button1.Size = new Size(148, 36);
            button1.TabIndex = 16;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(222, 30);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(30, 30);
            textBox2.TabIndex = 17;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(258, 30);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(30, 30);
            textBox3.TabIndex = 18;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(368, 30);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(30, 30);
            textBox4.TabIndex = 19;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(330, 30);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(30, 30);
            textBox5.TabIndex = 20;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(294, 30);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(30, 30);
            textBox6.TabIndex = 21;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Wide Latin", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 237);
            label1.Name = "label1";
            label1.Size = new Size(485, 100);
            label1.TabIndex = 22;
            label1.Text = "Guess the word?";
            // 
            // Game
            // 
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(500, 400);
            Controls.Add(label1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(lblScore);
            Controls.Add(lblIncorrect);
            Controls.Add(lblHint);
            Controls.Add(lblWord);
            Controls.Add(pbHangman);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Game";
            Text = "Word Guessing Game";
            Load += Game_Load;
            ((System.ComponentModel.ISupportInitialize)pbHangman).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.PictureBox pbHangman;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Label lblIncorrect;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.Button btnReset;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label1;
    }
}