using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pytania_Kolos_Poniedzialek
{
    public partial class Form1 : Form
    {
        DataClassesQuizDataContext db;
        List<Question> questionsList;

        Question q;
        public Form1()
        {
            InitializeComponent();
            db = new DataClassesQuizDataContext();

            questionsList = new List<Question>();
            foreach (Question question in db.Questions)
            {
                questionsList.Add(question);
            }

            Nastepy_button_Click(null, null);
        }

        int questionCounter = 0;
        int score = 0;

        private void Nastepy_button_Click(object sender, EventArgs e)
        {
            // old question stuff

            if (questionCounter > 0 && questionCounter < questionsList.Count)
            {
                foreach (RadioButton choice in flowLayoutPanelAnswers.Controls)
                {
                    if (choice.Checked)
                    {
                        foreach (Answer answer in q.Answers)
                        {
                            if (answer.Text == choice.Text && answer.IsValid)
                            {
                                score++;
                            }
                        }
                    }
                }
            }

            if (questionCounter < questionsList.Count)
            {
                q = questionsList[questionCounter];

                questionCounter++;

                flowLayoutPanelAnswers.Controls.Clear();

                groupBox1.Text = "Question " + questionCounter;
                labelQuestionText.Text = q.Text;

                foreach (Answer a in q.Answers)
                {
                    RadioButton answerButton = new RadioButton();
                    answerButton.Text = a.Text;
                    flowLayoutPanelAnswers.Controls.Add(answerButton);
                }


            }
            else
            {


                foreach (RadioButton choice in flowLayoutPanelAnswers.Controls)
                {
                    if (choice.Checked)
                    {
                        foreach (Answer answer in q.Answers)
                        {
                            if (answer.Text == choice.Text && answer.IsValid)
                            {
                                score++;
                            }
                        }
                    }
                }


                this.Controls.Clear();

                FormScoresTab fst = new FormScoresTab(score, db);
                if (fst.ShowDialog() == DialogResult.OK)
                {
                    this.Close();
                }





            }

        }


    }
}
