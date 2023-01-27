using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plugga_in_begrepp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    

public class FlashcardProgram : Form
    {
        private Label questionLabel;
        private TextBox[] questionBoxes;
        private TextBox[] answerBoxes;
        private Button submitButton;
        private int currentQuestion = 0;

        public FlashcardProgram()
        {
            // Initialize form components
            questionLabel = new Label();
            questionBoxes = new TextBox[16];
            answerBoxes = new TextBox[16];
            submitButton = new Button();

            // Set question label text
            questionLabel.Text = "Enter your question:";

            // Initialize question and answer textboxes
            for (int i = 0; i < 16; i++)
            {
                questionBoxes[i] = new TextBox();
                answerBoxes[i] = new TextBox();
            }

            // Add event handler for submit button
            submitButton.Click += new EventHandler(SubmitButtonClick);
            submitButton.Text = "Submit";

            // Add controls to the form
            Controls.Add(questionLabel);
            for (int i = 0; i < 16; i++)
            {
                Controls.Add(questionBoxes[i]);
                Controls.Add(answerBoxes[i]);
            }
            Controls.Add(submitButton);
        }

        private void SubmitButtonClick(object sender, EventArgs e)
        {
            // Get question and answer from textboxes
            string question = questionBoxes[currentQuestion].Text;
            string correctAnswer = answerBoxes[currentQuestion].Text;

            // Compare answer to correct answer
            if (question != "" && correctAnswer != "")
            {
                // Get answer from user
                string answer = Microsoft.VisualBasic.Interaction.InputBox(question);
                if (answer.ToLower() == correctAnswer.ToLower())
                {
                    MessageBox.Show("Correct!");
                    currentQuestion++;
                    if (currentQuestion == 16)
                    {
                        MessageBox.Show("You have completed all the questions!");
                        currentQuestion = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect. The correct answer is " + correctAnswer);
                }
            }
            else
            {
                MessageBox.Show("Please enter a question and correct answer.");
            }
        }

        public static void Main()
        {
            Application.Run(new FlashcardProgram());
        }
    }

}
}
