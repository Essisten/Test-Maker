using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Test_Maker
{
    public partial class TestMaker : Form
    {
        List<Question> Questions = new List<Question>();
        byte? mode, function;
        static Action basic_showing;
        public TestMaker()
        {
            InitializeComponent();
            basic_showing += ModeSelection.Show;
            basic_showing += FunctionSelection.Show;
            basic_showing += ContinueButton.Show;
            basic_showing += Resetting;
        }

        void SelectedFunctionChanged(object sender, EventArgs e)
        {
            function = (byte)FunctionSelection.SelectedIndex;
            if (function == 0 && mode == 0)
                TextBox.Clear();
            ShowingUp();
        }

        void ModeChanged(object sender, EventArgs e)
        {
            mode = (byte)ModeSelection.SelectedIndex;
            ShowingUp();
        }

        void Resetting()
        {
            mode = null;
            function = null;
            ModeSelection.SelectedItem = null;
            FunctionSelection.SelectedItem = null;
        }

        void ShowingUp()
        {
            TextBox.Hide();
            QuestionIndex.Hide();
            TypesOfAnswers.Hide();
            AnswerTypeLabel.Hide();
            AnswersLabel.Hide();
            SelectionOfAnswers.Hide();
            AnswerTextBoxLabel.Hide();
            AnswerTextBox.Hide();
            CorrectAnswerChecker.Hide();
            ExampleButton1.Hide();
            ExampleButton2.Hide();
            TextBox.ReadOnly = false;
            if (ModeSelection.SelectedItem != null && FunctionSelection.SelectedItem != null)
            {
                QuestionLabel.Show();
                if (mode == 0)
                {
                    TextBox.Show();
                    if (function == 1)
                        TextBox.ReadOnly = true;
                    else
                    {
                        TypesOfAnswers.Show();
                        AnswerTypeLabel.Show();
                        ExampleButton1.Show();
                        ExampleButton2.Show();
                    }
                    if (function > 0)
                        QuestionIndex.Show();
                }
                else if (mode == 1)
                {
                    TextBox.Show();
                    TextBox.ReadOnly = true;
                    AnswersLabel.Show();
                    SelectionOfAnswers.Show();
                    QuestionIndex.Show();
                    if (QuestionIndex.Value >= Questions.Count)
                        QuestionIndex.Value = 0;
                    else
                        TextBox.Text = Questions[(int)QuestionIndex.Value].Text;
                    if (function == 0 || function == 2)
                    {
                        AnswerTextBoxLabel.Show();
                        AnswerTextBox.Show();
                        CorrectAnswerChecker.Show();
                    }
                    else
                        TextBox.ReadOnly = false;
                }
            }
        }

        void ContinueButton_Click(object sender, EventArgs e)
        {
            int QI = (int)QuestionIndex.Value;  //Question index
            int AI = SelectionOfAnswers.SelectedIndex;  //Answer index
            if (mode == 0)
            {
                switch (function)
                {
                    case 0:
                        if (TextBox.Text != null && TextBox.Text.Length >= 10)
                            Questions.Add(new Question(TextBox.Text));
                        else
                            MessageBox.Show("Вопрос должен быть длиннее!");
                        break;
                    case 1:
                        if (QuestionIndex.Value < Questions.Count)
                            Questions.RemoveAt(QI);
                        else
                            MessageBox.Show("Такого вопроса в тесте нет!");
                        break;
                    case 2:
                        if (TextBox.Text != null && TextBox.Text.Length >= 10 && QuestionIndex.Value < Questions.Count)
                            Questions[QI].Text = TextBox.Text;
                        else
                            MessageBox.Show("Не удалось изменить вопрос. Убедитесь в том, что вопрос не короче 10 символов и вы выбрали индекс существующего вопроса в тесте.");
                        break;
                }
            }
            else if (mode == 1)
            {
                if (QuestionIndex.Value <= Questions.Count && Questions.Count > 0)
                {
                    switch (function)
                    {
                        case 0:
                            SelectionOfAnswers.Items.Add(AnswerTextBox.Text);
                            Questions[QI].Answers.Add(new Answer(CorrectAnswerChecker.Checked, AnswerTextBox.Text));
                            break;
                        case 1:
                            Questions[QI].Answers.RemoveAt(AI);
                            SelectionOfAnswers.Items.RemoveAt(AI);
                            break;
                        case 3: //undone function
                            Questions[QI].Answers[AI] = new Answer(CorrectAnswerChecker.Checked, AnswerTextBox.Text);
                            SelectionOfAnswers.Items.RemoveAt(AI);
                            SelectionOfAnswers.Items.Insert(AI, TextBox.Text);
                            break;
                    }
                }
                else
                    MessageBox.Show("Неверный индекс вопроса!");
            }
        }

        void SaveTest_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == SavingTestWindow.ShowDialog())
            {
                if (SavingTestWindow.FileName != null)
                {
                    using (StreamWriter file = new StreamWriter(File.OpenWrite(SavingTestWindow.FileName), Encoding.Unicode))
                    {
                        foreach (Question q in Questions)
                        {
                            file.Write($"<<<{q.Text}>>> <<<{q.Single_type}>>> <<<");
                            foreach (Answer a in q.Answers)
                            {
                                file.Write($" {a.Text} ||| {a.Correct}");
                                if (q.Answers[q.Answers.Count - 1] != a)
                                    file.Write(" |||");
                            }
                            file.Write(">>>");
                            if (Questions[Questions.Count - 1] != q)
                                file.WriteLine();
                        }
                    }
                }
            }
        }

        void QuestionIndex_ValueChanged(object sender, EventArgs e)
        {
            if (QuestionIndex.Value < Questions.Count)
            {
                TextBox.Text = Questions[(int)QuestionIndex.Value].Text;
                SelectionOfAnswers.Items.Clear();
                foreach (Answer a in Questions[(int)QuestionIndex.Value].Answers)
                {
                    SelectionOfAnswers.Items.Add(a.Text);
                }
            }
            QuestionIndex.Maximum = Questions.Count - 1;
        }

        void CreateTest_Click(object sender, EventArgs e)
        {
            
        }

        void OpenTest_Click(object sender, EventArgs e)
        {
            if (CreateTestWindow.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader file = new StreamReader(CreateTestWindow.FileName, Encoding.Unicode))
                {
                    
                }
                basic_showing.Invoke();
            }
        }

    }
    public class Question
    {
        List<Answer> answers = new List<Answer>();
        public List<Answer> Answers
        { 
            get { return answers; }
            set
            {
                if (value is List<Answer> && value != null)
                    answers = value;
            }
        }
        public string Text;
        public bool Single_type;
        public Question(string q) => Text = q;
    }
    public class Answer
    {
        public bool Correct { get; private set; }
        string text;
        public string Text
        {
            get { return text; }
            private set
            {
                if (value is string && value.Length > 0)
                    text = value;
                return;
            }
        }
        public Answer(bool correct, string text)
        {
            Correct = correct;
            Text = text;
        }
    }
}
