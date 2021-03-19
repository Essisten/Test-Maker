using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Test_Passing
{
    public partial class Test_passing : Form
    {
        List<Question> questions = new List<Question>();
        List<bool> CorrectAnswers = new List<bool>();
        Action hiding;
        short Count = 0;
        public Test_passing()
        {
            InitializeComponent();
            Progress.Hide();
            PercentLabel.Hide();
            hiding += BackButton.Hide;
            hiding += NextButton.Hide;
            hiding += AnswersSingle.Hide;
            hiding += AnswersMultiple.Hide;
        }

        void Test_passing_Load(object sender, EventArgs e)
        {
            foreach (Question q in TestMaker.Questions)
                questions.Add(q);
            ShowingElements();
            Refreshing();
        }

        void ShowingElements()
        {
            AnswersSingle.Visible = questions[Count].Single_type;
            AnswersMultiple.Visible = !questions[Count].Single_type;
            BackButton.Enabled = Count > 0;
            NextButton.Enabled = AnswersSingle.SelectedItem != null | AnswersMultiple.SelectedItems != null;
            QuestionTextBox.Text = questions[Count].Text;
        }

        void Refreshing()
        {
            AnswersSingle.Items.Clear();
            AnswersMultiple.Items.Clear();
            foreach (Answer a in questions[Count].Answers)
            {
                if (questions[Count].Single_type)
                    AnswersSingle.Items.Add(a.Text);
                else
                    AnswersMultiple.Items.Add(a.Text);
            }
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
                NextButton.Text = Count == questions.Count - 1 ? "Завершить" : "Далее";
            }
            else
            {
                bool fail = false;
                foreach (int id in ids)
                {
                    if (!AnswersMultiple.CheckedIndices.Contains(id))
                    {
                        CorrectAnswers.Add(false);
                        fail = true;
                    }
                }
                if (!fail)
                    CorrectAnswers.Add(true);
            }
            if (Count >= questions.Count - 1)
            {
                hiding.Invoke();
                BackColor = Color.Bisque;
                QuestionTextBox.BackColor = BackColor;
                Progress.Show();
                int count = 0;
                foreach (bool q in CorrectAnswers)
                {
                    if (q)
                        count++;
                }
                double percent = 100 / questions.Count * count;
                Progress.Value = (int)percent;
                QuestionTextBox.Text = "Тест завершён, вот ваш результат:";
                PercentLabel.Text = percent + "%";
                PercentLabel.Show();
            }
            else
                QuestionTextBox.Text = questions[++Count].Text;
            Refreshing();
            ShowingElements();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            CorrectAnswers.RemoveAt(CorrectAnswers.Count - 1);
            QuestionTextBox.Text = questions[--Count].Text;
            Refreshing();
        }

        private void Test_passing_FormClosed(object sender, FormClosedEventArgs e)
        {
            TestMaker tm = new TestMaker();
            tm.Show();
            TestMaker.basic_showing.Invoke();
        }
    }
}
