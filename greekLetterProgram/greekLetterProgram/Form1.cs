using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace greekLetterProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int score = 0;
        int group = 1;
        int maxscore = 4;

        private void Form1_Load(object sender, EventArgs e)
        {
            submitAnswerButton.Enabled = false;
        }

        private void submitAnswerButton_Click(object sender, EventArgs e)
        {
            SubmitAnswer();
        }

        private void SubmitAnswer()
        {
            if (submitAnswerButton.Text == "Avgi svar")
            {
                submitAnswerButton.Text = "Neste";
                UpdateLabels();
            }
            else
            {
                submitAnswerButton.Text = "Avgi svar";
                group += 1;
                maxscore += 4;
                if (group < 7)
                {
                    UpdateLabels();
                }

                if (group == 7)
                {
                    DialogResult answer = MessageBox.Show("Du fikk " + score + "/" + maxscore + "\n \n Vil du starte på nytt?", "Resultattavle", MessageBoxButtons.YesNo);
                    if (answer == DialogResult.Yes)
                    {
                        Reset();
                    }
                    else
                    {
                        Close();
                    }
                }
            }
        }

        private void UpdateLabels()
        {
            groupLabel.Text = "Group " + group;
            scoreLabel.Text = "Score " + score + "/" + maxscore;
        }

        private void Reset()
        {
            score = 0;
            maxscore = 4;
            group = 1;
            UpdateLabels();
        }

        private void enableButton_Click(object sender, EventArgs e)
        {
            submitAnswerButton.Enabled = true;
        }
    }
}
