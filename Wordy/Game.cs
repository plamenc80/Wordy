using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Linq;
using System.Windows.Forms;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Wordy
{
    public partial class Game : Form
    {
        private List<string> words = new List<string>
        {
            "COMPUTER", "PROGRAM", "DEVELOPER", "KEYBOARD", "MONITOR",
            "SOLUTION", "WINDOWS", "VISUAL", "STUDIO", "CODE"
        };

        private string currentWord;
        private char[] revealedLetters;
        private int incorrectGuesses;
        private int score;
        private Random random = new Random();

        public Game()
        {
            InitializeComponent();
            SetupGame();
        }

        private void SetupGame()
        {
            // Select random word
            currentWord = words[random.Next(words.Count)];
            revealedLetters = new char[currentWord.Length];

            // Initialize with underscores
            for (int i = 0; i < currentWord.Length; i++)
            {
                revealedLetters[i] = '_';
            }

            incorrectGuesses = 0;
            UpdateDisplay();
            UpdateScore();
            btnHint.Enabled = true;
        }

        private void UpdateDisplay()
        {
            lblWord.Text = string.Join(" ", revealedLetters);
            lblIncorrect.Text = $"Incorrect guesses: {incorrectGuesses}/6";
            lblHint.Text = $"Hint: The word has {currentWord.Length} letters";

            // Update hangman image based on incorrect guesses
            pbHangman.Image = Properties.Resources.hangman_0; // Base image
            if (incorrectGuesses > 0)
            {
                pbHangman.Image = (Bitmap)Properties.Resources.ResourceManager
                    .GetObject($"hangman_{Math.Min(incorrectGuesses, 6)}");
            }

            // Check win/lose conditions
            if (Array.IndexOf(revealedLetters, '_') == -1)
            {
                MessageBox.Show("Congratulations! You won!");
                score += 10;
                UpdateScore();
                SetupGame();
            }
            else if (incorrectGuesses >= 6)
            {
                MessageBox.Show($"Game over! The word was: {currentWord}");
                SetupGame();
            }
        }

        private void UpdateScore()
        {
            lblScore.Text = $"Score: {score}";
        }

        private void btnLetter_Click(object sender, EventArgs e)
        {
            Button letterButton = (Button)sender;
            char guessedLetter = letterButton.Text[0];
            letterButton.Enabled = false;
            letterButton.BackColor = Color.LightGray;

            bool correctGuess = false;
            for (int i = 0; i < currentWord.Length; i++)
            {
                if (char.ToUpper(guessedLetter) == currentWord[i])
                {
                    revealedLetters[i] = currentWord[i];
                    correctGuess = true;
                }
            }

            if (!correctGuess)
            {
                incorrectGuesses++;
            }

            UpdateDisplay();
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            // Reveal one random hidden letter
            List<int> hiddenIndices = new List<int>();
            for (int i = 0; i < revealedLetters.Length; i++)
            {
                if (revealedLetters[i] == '_')
                {
                    hiddenIndices.Add(i);
                }
            }

            if (hiddenIndices.Count > 0)
            {
                int randomIndex = hiddenIndices[random.Next(hiddenIndices.Count)];
                revealedLetters[randomIndex] = currentWord[randomIndex];
                score = Math.Max(0, score - 2); // Deduct 2 points for using hint
                UpdateScore();
                UpdateDisplay();
            }

            btnHint.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            score = 0;
            UpdateScore();
            SetupGame();
            ResetLetterButtons();
        }

        private void ResetLetterButtons()
        {
            foreach (Control control in pnlLetters.Controls)
            {
                if (control is Button button && button != btnHint && button != btnReset)
                {
                    button.Enabled = true;
                    button.BackColor = SystemColors.Control;
                }
            }
        }
    }
}