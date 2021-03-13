using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Test_Passing
{
    public partial class Test_passing : Form
    {
        List<Question> questions = new List<Question>();
        List<bool> CorrectAnswers = new List<bool>();
        short Count = 0;
        public Test_passing()
        {
            InitializeComponent();
        }

        void Test_passing_Load(object sender, EventArgs e)
        {
            foreach (Question q in TestMaker.Questions)
                questions.Add(q);
            ShowingElements();
        }

        void ShowingElements()
        {
            AnswersSingle.Visible = questions[Count].Single_type;
            AnswersMultiple.Visible = !questions[Count].Single_type;
            BackButton.Enabled = Count > 0;
            NextButton.Enabled = Count + 1 < questions.Count;
            QuestionTextBox.Text = questions[Count].Text;
        }

        void NextButton_Click(object sender, EventArgs e)
        {
            List<int> ids = new List<int>();
            for (int i = 0; i < questions.Count; i++)
            {
                if (questions[Count].Answers[i].Correct)
                {
                    ids.Add(i);
                    if (questions[Count].Single_type)
                        break;
                }
            }
            if (questions[Count].Single_type)
            {
                CorrectAnswers.Add(AnswersSingle.SelectedIndex == ids[0]);
                QuestionTextBox.Text = questions[++Count].Text;
            }
            else
            {

            }
        }
    }
}
