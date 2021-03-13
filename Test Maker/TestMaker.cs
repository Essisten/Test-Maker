using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Convert;

namespace Test_Passing
{
    public partial class TestMaker : Form
    {
        public static List<Question> Questions = new List<Question>();
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
            if (mode == 0)
            {
                if (function == 0)
                    TextBox.Clear();
                else if (function == 1)
                    AnswerTextBox.Clear();
            }
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
            TextBox.Clear();
            SelectionOfAnswers.Items.Clear();
            AnswerTextBox.Clear();
            CorrectAnswerChecker.Checked = false;
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
            if (mode == 0)  //If you're acting with questions
            {
                if (TypesOfAnswers.SelectedItem != null)
                {
                    switch (function)   //Acts with questions
                    {
                        case 0:
                            if (TextBox.Text != null && TextBox.Text.Length >= 10 && TypesOfAnswers.SelectedIndex < 2)
                                Questions.Add(new Question(TextBox.Text, TypesOfAnswers.SelectedIndex.Equals(0)));
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
                            if (TextBox.Text != null && TextBox.Text.Length >= 10 && QuestionIndex.Value < Questions.Count && TypesOfAnswers.SelectedIndex < 2)
                            {
                                Questions[QI].Text = TextBox.Text;
                                Questions[QI].Single_type = TypesOfAnswers.SelectedIndex.Equals(0);
                            }
                            else
                                MessageBox.Show("Не удалось изменить вопрос. Убедитесь в том, что вопрос не короче 10 символов и вы выбрали индекс существующего вопроса в тесте.");
                            break;
                    }
                }
                else
                    MessageBox.Show("Выберите тип ответов!");
            }
            else if (mode == 1) //If you're acting with answers
            {
                if (QuestionIndex.Value <= Questions.Count && Questions.Count > 0)  //Checking if question contain only one correct answer
                {
                    if (Questions[QI].Single_type)
                    {
                        byte CorrectCount = 0;
                        foreach (Answer a in Questions[QI].Answers)
                        {
                            if (a.Correct)
                                CorrectCount++;
                            if (CorrectCount > 1 && a.Correct)
                                break;
                        }
                        if (CorrectCount > 1)
                        {
                            MessageBox.Show("Было задано более одного правильного ответа в вопросе. У данного вопроса может быть лишь один правильный ответ.");
                            return;
                        }
                    }
                    if (AnswerTextBox.Text != null && AnswerTextBox.Text.Length > 0)
                    {
                        switch (function)   //Acts with answers
                        {
                            case 0:
                                SelectionOfAnswers.Items.Add(AnswerTextBox.Text);
                                Questions[QI].Answers.Add(new Answer(CorrectAnswerChecker.Checked, AnswerTextBox.Text));
                                break;
                            case 1:
                                Questions[QI].Answers.RemoveAt(AI);
                                SelectionOfAnswers.Items.RemoveAt(AI);
                                break;
                            case 2:
                                Questions[QI].Answers[AI] = new Answer(CorrectAnswerChecker.Checked, AnswerTextBox.Text);
                                SelectionOfAnswers.Items.RemoveAt(AI);
                                SelectionOfAnswers.Items.Insert(AI, AnswerTextBox.Text);
                                break;
                        }
                    }
                    else
                        MessageBox.Show("Введите вопрос");
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
                                file.Write($"{a.Text}|||{a.Correct}");
                                if (q.Answers[q.Answers.Count - 1] != a)
                                    file.Write("|||");
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
                TypesOfAnswers.SelectedIndex = Questions[(int)QuestionIndex.Value].Single_type ? 0 : 1;
                foreach (Answer a in Questions[(int)QuestionIndex.Value].Answers)
                {
                    SelectionOfAnswers.Items.Add(a.Text);
                }
            }
            QuestionIndex.Maximum = Questions.Count - 1;
        }

        void CreateTest_Click(object sender, EventArgs e)
        {
            Resetting();
            basic_showing.Invoke();
        }

        private void SelectionOfAnswers_SelectedIndexChanged(object sender, EventArgs e)
        {
            AnswerTextBox.Text = SelectionOfAnswers.SelectedItem.ToString();
            CorrectAnswerChecker.Checked = Questions[(int)QuestionIndex.Value].Answers[SelectionOfAnswers.SelectedIndex].Correct;
        }

        private void StartTest_Click(object sender, EventArgs e)
        {
            Hide();

        }

        void OpenTest_Click(object sender, EventArgs e)
        {
            if (CreateTestWindow.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader file = new StreamReader(CreateTestWindow.FileName, Encoding.Unicode))
                {
                    while (!file.EndOfStream)   //Reading till end of file
                    {
                        string line = file.ReadLine();
                        List<Answer> answers = new List<Answer>();
                        byte m = 0;
                        string[] elements = new string[3];
                        for (int i = 0; i < line.Length; i++)   //Reading all line
                        {
                            if (i + 2 < line.Length && line.Substring(i, 3) == "<<<")
                            {
                                i += 3;
                                for (int j = i; j + 2 < line.Length && line.Substring(j, 3) != ">>>"; j++)    //Finding elements
                                {
                                    elements[m] += line[j];
                                }
                                if (m == 2)
                                {
                                    bool AnswerOrCorrect = true, AnswerIsCorrect = false;
                                    string tmp = "", tmp2 = "";
                                    for (int j = 0; j <= elements[2].Length; j++)    //Reading answers
                                    {
                                        if ((j < elements[2].Length - 3 && elements[2].Substring(j, 3) == "|||") || j == elements[2].Length)   //Checking is this element is answer or correction of answer
                                        {
                                            if (AnswerOrCorrect)
                                            {
                                                AnswerOrCorrect = false;
                                                j += tmp2.Length + 2;
                                            }
                                            else
                                            {
                                                AnswerOrCorrect = true;
                                                if (tmp2 == "True")
                                                    AnswerIsCorrect = true;
                                                else if (tmp2 == "False")
                                                    AnswerIsCorrect = false;
                                                if (j == elements[2].Length - 1)
                                                    break;
                                                answers.Add(new Answer(AnswerIsCorrect, tmp));
                                                tmp = "";
                                                tmp2 = "";
                                                j += tmp.Length + 2;
                                            }
                                        }
                                        else
                                        {
                                            if (AnswerOrCorrect)
                                                tmp += elements[2][j];
                                            else
                                                tmp2 += elements[2][j];
                                        }
                                    }
                                }
                                i += elements[m].Length;
                                if (m < 3)
                                    m++;
                                else
                                    m = 0;
                            }
                        }
                        Questions.Add(new Question(elements[0], ToBoolean(elements[1])));   //Now we're adding our questions into a list
                        Questions[Questions.Count - 1].Answers = answers;
                    }
                }
                QuestionIndex.Value = 0;
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
        public Question(string text, bool type)
        {
            Text = text;
            Single_type = type;
        }
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
