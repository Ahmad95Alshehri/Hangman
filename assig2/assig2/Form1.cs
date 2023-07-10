using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;


namespace assig2
{
    public partial class Form1 : Form
    {
        private int currentStage = 0;
        private string correctWord = "";
        private int score = 0;
        private int Lscore = 0;
        private bool gameEnded = false;
        private List<Label> incorrectLabels = new List<Label>();
        private string[] wordFiles = { "C:\\Users\\Ahmad Alshehri\\Desktop\\LIU CLASSES\\spring 2023\\assig2\\words1.txt",
            "C:\\Users\\Ahmad Alshehri\\Desktop\\LIU CLASSES\\spring 2023\\assig2\\words2.txt" };




        private Image[] hangmanImages = new Image[]//array of images load from resources
        {
            assig2.Resource1.hang1,assig2.Resource1.hang2,assig2.Resource1.hang3,assig2.Resource1.hang4,assig2.Resource1.hang5,assig2.Resource1.hang6,assig2.Resource1.hang7,
        };
        public Form1()
        {
            InitializeComponent();
            // Add word files to the ComboBox
            cmbWordFiles.Items.AddRange(wordFiles);

            // Select the first word file by default
            cmbWordFiles.SelectedIndex = 0;
            StartNewGame();
        }

        private void StartNewGame()
        {
            // remove old labels
            for (int i = 1; i <= correctWord.Length; i++)
            {
                Control control = this.Controls.Find("lblLetter" + i, true)[0];
                this.Controls.Remove(control);
            }

            foreach (Label incorrectLabel in incorrectLabels)
            {
                this.Controls.Remove(incorrectLabel);
            }
            incorrectLabels.Clear();


            // Select a new random word from the selected word file
            string[] allWords = File.ReadAllLines(cmbWordFiles.SelectedItem.ToString());
            Random rand = new Random();
            correctWord = allWords[rand.Next(allWords.Length)];

      


            // create the label controls for the word
            for (int i = 0; i < correctWord.Length; i++)
            {
                Label label = new Label();
                label.Name = "lblLetter" + (i + 1);
                label.Text = "_";
                label.AutoSize = false;
                label.Width = 25;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Font = new Font("Arial", 16);
                label.Location = new Point(50 + (i * 25), 150);
                this.Controls.Add(label);
            }

            gameEnded = false;

            // reset pic
            currentStage = 0;
            picHangman.Image = hangmanImages[currentStage];

            // chnage   labels  won or lost
            if (currentStage == 6)
            {
                MessageBox.Show("You lost! The correct word was " + correctWord);
            }
            else if (correctWord == string.Join("", this.Controls.OfType<Label>().Where(l => l.Name.StartsWith("lblLetter")).Select(l => l.Text)))
            {
                MessageBox.Show("You won!");
            }
        }

        private void InitializeWordLabels(int wordLength)
        {

            string[] words1 = File.ReadAllLines("C:\\Users\\Ahmad Alshehri\\Desktop\\LIU CLASSES\\spring 2023\\assig2\\words1.txt");
            string[] words2 = File.ReadAllLines("C:\\Users\\Ahmad Alshehri\\Desktop\\LIU CLASSES\\spring 2023\\assig2\\words2.txt");

            // put togather the words from both files
            string[] allWords = words1.Concat(words2).ToArray();

            // select a random word
            Random rand = new Random();
            correctWord = allWords[rand.Next(allWords.Length)];

            // update the score counter
            lblScore.Text = "Score: " + score.ToString();


            // create the label controls for the word
            for (int i = 0; i < correctWord.Length; i++)
            {
                Label label = new Label();
                label.Name = "lblLetter" + (i + 1);
                label.Text = "_";
                label.AutoSize = false;
                label.Width = 25;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Font = new Font("Arial", 16);
                label.Location = new Point(50 + (i * 25), 150);
                this.Controls.Add(label);
            }
        }


        //returns the label control that matches the given index
        private Label GetMatchingLabel(int index)
        {
            string labelName = "lblLetter" + (index + 1);
            return (Label)this.Controls.Find(labelName, true)[0];
        }

        //updates the labels to display the complete word.
        private void DisplayWord(string word)
        {
            // show the complete word in the labels
            for (int i = 0; i < word.Length; i++)
            {
                Label label = GetMatchingLabel(i);
                label.Text = word[i].ToString();
            }
        }


        private void Guess_Click(object sender, EventArgs e)
        {
            if (gameEnded)
            {
                StartNewGame();
                return;
            }

            string guess = txtGuess.Text.Trim().ToUpper();

            // check if the guess is a single letter
            if (guess.Length == 1)
            {
                bool letterFound = false;

                // check if the guess is in the word and update the labels
                for (int i = 0; i < correctWord.Length; i++)
                {
                    if (correctWord[i].ToString().ToUpper() == guess)
                    {
                        Label label = GetMatchingLabel(i);
                        label.Text = correctWord[i].ToString();
                         label.ForeColor = Color.Green;
                        letterFound = true;
                    }
                   
                }
                if (guess.Length > 1)
                {
                    MessageBox.Show("please enter one letter");
                }


                // if the letter is not in the word, update the hangman image and incorrect guesses label
                if (!letterFound)
                {
                    currentStage++;
                    picHangman.Image = hangmanImages[currentStage];
                   
                   
                    Label incorrectLabel = new Label();
                    incorrectLabel.Text = guess;
                    incorrectLabel.AutoSize = true;
                    incorrectLabel.Font = new Font("Arial", 12);
                    incorrectLabel.ForeColor = Color.Red;
                    incorrectLabel.Location = new Point(50 + (incorrectLabels.Count * 20), 200);
                    this.Controls.Add(incorrectLabel);
                    incorrectLabels.Add(incorrectLabel);

                    if (currentStage == 6)
                    {
                        MessageBox.Show("You lost! The correct word was " + correctWord);
                        gameEnded = true;
                        Lscore += 1;
                        lblNewWord.Text = "Losses: " + Lscore.ToString();
                       
                        return;
                    }
                }

                // check if the player has won
                if (correctWord == string.Join("", this.Controls.OfType<Label>().Where(l => l.Name.StartsWith("lblLetter")).Select(l => l.Text)))
                {
                    MessageBox.Show("You won!");
                    gameEnded = true;
                    score += 1;
                    lblScore.Text = "Score: " + score.ToString();
                   
                    return;
                }
            }
            else if (guess.Length == correctWord.Length)
            {
                // check if the guess is equal to the correct word
                if (guess == correctWord.ToUpper())
                {
                    DisplayWord(correctWord.ToUpper());
                    MessageBox.Show("You won!");
                    gameEnded = true;
                    score += 1;
                    lblScore.Text = "Score: " + score.ToString();
                
                    return;
                }
                else
                {
                    currentStage++;
                    picHangman.Image = hangmanImages[currentStage];

                    if (currentStage == 6)
                    {
                        MessageBox.Show("You lost! The correct word was " + correctWord);
                        gameEnded = true;
                        Lscore += 1;
                        lblNewWord.Text = "Losses: " + Lscore.ToString();
                       
                        return;
                    }
                }
            }

            txtGuess.Text = "";
        }





        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            score = 0;
            Lscore = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblScore_TextChanged(object sender, EventArgs e)
        {
            lblScore.Text = "Win Count: " + score.ToString();

        }

        private void lblNewWord_TextChanged(object sender, EventArgs e)
        {
            lblNewWord.Text = "Loss count: " + Lscore.ToString();
        }
        

        private void cmbWordFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartNewGame();

        }

        
    }
}