
namespace Test_Passing
{
    partial class TestMaker
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.UpperMenu = new System.Windows.Forms.MenuStrip();
            this.CreateTest = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveTest = new System.Windows.Forms.ToolStripMenuItem();
            this.StartTest = new System.Windows.Forms.ToolStripMenuItem();
            this.FunctionSelection = new System.Windows.Forms.ListBox();
            this.ModeSelection = new System.Windows.Forms.ComboBox();
            this.QuestionIndex = new System.Windows.Forms.NumericUpDown();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.TypesOfAnswers = new System.Windows.Forms.ComboBox();
            this.AnswerTypeLabel = new System.Windows.Forms.Label();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.SelectionOfAnswers = new System.Windows.Forms.ComboBox();
            this.AnswersLabel = new System.Windows.Forms.Label();
            this.AnswerTextBox = new System.Windows.Forms.TextBox();
            this.AnswerTextBoxLabel = new System.Windows.Forms.Label();
            this.SavingTestWindow = new System.Windows.Forms.SaveFileDialog();
            this.ExampleButton1 = new System.Windows.Forms.RadioButton();
            this.ExampleButton2 = new System.Windows.Forms.CheckBox();
            this.CorrectAnswerChecker = new System.Windows.Forms.CheckBox();
            this.CreateTestWindow = new System.Windows.Forms.OpenFileDialog();
            this.UpperMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // UpperMenu
            // 
            this.UpperMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateTest,
            this.OpenTest,
            this.SaveTest,
            this.StartTest});
            this.UpperMenu.Location = new System.Drawing.Point(0, 0);
            this.UpperMenu.Name = "UpperMenu";
            this.UpperMenu.Size = new System.Drawing.Size(584, 24);
            this.UpperMenu.TabIndex = 0;
            this.UpperMenu.Text = "UpperMenu";
            // 
            // CreateTest
            // 
            this.CreateTest.Name = "CreateTest";
            this.CreateTest.Size = new System.Drawing.Size(62, 20);
            this.CreateTest.Text = "Создать";
            this.CreateTest.Click += new System.EventHandler(this.CreateTest_Click);
            // 
            // OpenTest
            // 
            this.OpenTest.Name = "OpenTest";
            this.OpenTest.Size = new System.Drawing.Size(66, 20);
            this.OpenTest.Text = "Открыть";
            this.OpenTest.Click += new System.EventHandler(this.OpenTest_Click);
            // 
            // SaveTest
            // 
            this.SaveTest.Name = "SaveTest";
            this.SaveTest.Size = new System.Drawing.Size(78, 20);
            this.SaveTest.Text = "Сохранить";
            this.SaveTest.Click += new System.EventHandler(this.SaveTest_Click);
            // 
            // StartTest
            // 
            this.StartTest.Name = "StartTest";
            this.StartTest.Size = new System.Drawing.Size(74, 20);
            this.StartTest.Text = "Запустить";
            this.StartTest.Click += new System.EventHandler(this.StartTest_Click);
            // 
            // FunctionSelection
            // 
            this.FunctionSelection.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FunctionSelection.FormattingEnabled = true;
            this.FunctionSelection.ItemHeight = 30;
            this.FunctionSelection.Items.AddRange(new object[] {
            "Добавить",
            "Удалить",
            "Изменить"});
            this.FunctionSelection.Location = new System.Drawing.Point(6, 73);
            this.FunctionSelection.Name = "FunctionSelection";
            this.FunctionSelection.Size = new System.Drawing.Size(121, 94);
            this.FunctionSelection.TabIndex = 1;
            this.FunctionSelection.Visible = false;
            this.FunctionSelection.SelectedIndexChanged += new System.EventHandler(this.SelectedFunctionChanged);
            // 
            // ModeSelection
            // 
            this.ModeSelection.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModeSelection.FormattingEnabled = true;
            this.ModeSelection.Items.AddRange(new object[] {
            "Вопросы",
            "Ответы"});
            this.ModeSelection.Location = new System.Drawing.Point(5, 173);
            this.ModeSelection.Name = "ModeSelection";
            this.ModeSelection.Size = new System.Drawing.Size(121, 35);
            this.ModeSelection.TabIndex = 2;
            this.ModeSelection.Visible = false;
            this.ModeSelection.SelectedIndexChanged += new System.EventHandler(this.ModeChanged);
            // 
            // QuestionIndex
            // 
            this.QuestionIndex.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionIndex.Location = new System.Drawing.Point(6, 33);
            this.QuestionIndex.Name = "QuestionIndex";
            this.QuestionIndex.Size = new System.Drawing.Size(120, 34);
            this.QuestionIndex.TabIndex = 3;
            this.QuestionIndex.Visible = false;
            this.QuestionIndex.ValueChanged += new System.EventHandler(this.QuestionIndex_ValueChanged);
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox.Location = new System.Drawing.Point(132, 59);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(440, 228);
            this.TextBox.TabIndex = 4;
            this.TextBox.Text = "";
            this.TextBox.Visible = false;
            // 
            // ContinueButton
            // 
            this.ContinueButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContinueButton.Location = new System.Drawing.Point(6, 394);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(210, 35);
            this.ContinueButton.TabIndex = 5;
            this.ContinueButton.Text = "Подтвердить изменения";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Visible = false;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // TypesOfAnswers
            // 
            this.TypesOfAnswers.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypesOfAnswers.FormattingEnabled = true;
            this.TypesOfAnswers.Items.AddRange(new object[] {
            "Один",
            "Несколько"});
            this.TypesOfAnswers.Location = new System.Drawing.Point(7, 237);
            this.TypesOfAnswers.Name = "TypesOfAnswers";
            this.TypesOfAnswers.Size = new System.Drawing.Size(100, 31);
            this.TypesOfAnswers.TabIndex = 6;
            this.TypesOfAnswers.Visible = false;
            // 
            // AnswerTypeLabel
            // 
            this.AnswerTypeLabel.AutoSize = true;
            this.AnswerTypeLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerTypeLabel.Location = new System.Drawing.Point(2, 211);
            this.AnswerTypeLabel.Name = "AnswerTypeLabel";
            this.AnswerTypeLabel.Size = new System.Drawing.Size(112, 23);
            this.AnswerTypeLabel.TabIndex = 7;
            this.AnswerTypeLabel.Text = "Вид ответов:";
            this.AnswerTypeLabel.Visible = false;
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionLabel.Location = new System.Drawing.Point(141, 33);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(72, 23);
            this.QuestionLabel.TabIndex = 8;
            this.QuestionLabel.Text = "Вопрос:";
            this.QuestionLabel.Visible = false;
            // 
            // SelectionOfAnswers
            // 
            this.SelectionOfAnswers.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectionOfAnswers.FormattingEnabled = true;
            this.SelectionOfAnswers.Location = new System.Drawing.Point(389, 350);
            this.SelectionOfAnswers.Name = "SelectionOfAnswers";
            this.SelectionOfAnswers.Size = new System.Drawing.Size(183, 27);
            this.SelectionOfAnswers.TabIndex = 9;
            this.SelectionOfAnswers.Visible = false;
            this.SelectionOfAnswers.SelectedIndexChanged += new System.EventHandler(this.SelectionOfAnswers_SelectedIndexChanged);
            // 
            // AnswersLabel
            // 
            this.AnswersLabel.AutoSize = true;
            this.AnswersLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswersLabel.Location = new System.Drawing.Point(444, 320);
            this.AnswersLabel.Name = "AnswersLabel";
            this.AnswersLabel.Size = new System.Drawing.Size(76, 23);
            this.AnswersLabel.TabIndex = 10;
            this.AnswersLabel.Text = "Ответы:";
            this.AnswersLabel.Visible = false;
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerTextBox.Location = new System.Drawing.Point(200, 350);
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(183, 26);
            this.AnswerTextBox.TabIndex = 11;
            this.AnswerTextBox.Visible = false;
            // 
            // AnswerTextBoxLabel
            // 
            this.AnswerTextBoxLabel.AutoSize = true;
            this.AnswerTextBoxLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerTextBoxLabel.Location = new System.Drawing.Point(232, 324);
            this.AnswerTextBoxLabel.Name = "AnswerTextBoxLabel";
            this.AnswerTextBoxLabel.Size = new System.Drawing.Size(119, 23);
            this.AnswerTextBoxLabel.TabIndex = 12;
            this.AnswerTextBoxLabel.Text = "Текст ответа:";
            this.AnswerTextBoxLabel.Visible = false;
            // 
            // SavingTestWindow
            // 
            this.SavingTestWindow.FileName = "test.t";
            this.SavingTestWindow.Filter = "\"Все файлы|*.*|Тесты|*.t\"";
            // 
            // ExampleButton1
            // 
            this.ExampleButton1.AutoSize = true;
            this.ExampleButton1.Location = new System.Drawing.Point(12, 274);
            this.ExampleButton1.Name = "ExampleButton1";
            this.ExampleButton1.Size = new System.Drawing.Size(51, 17);
            this.ExampleButton1.TabIndex = 13;
            this.ExampleButton1.TabStop = true;
            this.ExampleButton1.Text = "Один";
            this.ExampleButton1.UseVisualStyleBackColor = true;
            this.ExampleButton1.Visible = false;
            // 
            // ExampleButton2
            // 
            this.ExampleButton2.AutoSize = true;
            this.ExampleButton2.Location = new System.Drawing.Point(12, 297);
            this.ExampleButton2.Name = "ExampleButton2";
            this.ExampleButton2.Size = new System.Drawing.Size(82, 17);
            this.ExampleButton2.TabIndex = 14;
            this.ExampleButton2.Text = "Несколько";
            this.ExampleButton2.UseVisualStyleBackColor = true;
            this.ExampleButton2.Visible = false;
            // 
            // CorrectAnswerChecker
            // 
            this.CorrectAnswerChecker.AutoSize = true;
            this.CorrectAnswerChecker.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CorrectAnswerChecker.Location = new System.Drawing.Point(392, 383);
            this.CorrectAnswerChecker.Name = "CorrectAnswerChecker";
            this.CorrectAnswerChecker.Size = new System.Drawing.Size(157, 27);
            this.CorrectAnswerChecker.TabIndex = 15;
            this.CorrectAnswerChecker.Text = "Верность ответа";
            this.CorrectAnswerChecker.UseVisualStyleBackColor = true;
            this.CorrectAnswerChecker.Visible = false;
            // 
            // CreateTestWindow
            // 
            this.CreateTestWindow.FileName = "test.t";
            this.CreateTestWindow.Filter = "\"Все файлы|*.*|Тесты|*.t\"";
            // 
            // TestMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.CorrectAnswerChecker);
            this.Controls.Add(this.ExampleButton2);
            this.Controls.Add(this.ExampleButton1);
            this.Controls.Add(this.AnswerTextBoxLabel);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.AnswersLabel);
            this.Controls.Add(this.SelectionOfAnswers);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.AnswerTypeLabel);
            this.Controls.Add(this.TypesOfAnswers);
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.QuestionIndex);
            this.Controls.Add(this.ModeSelection);
            this.Controls.Add(this.FunctionSelection);
            this.Controls.Add(this.UpperMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.UpperMenu;
            this.Name = "TestMaker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Maker";
            this.UpperMenu.ResumeLayout(false);
            this.UpperMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip UpperMenu;
        private System.Windows.Forms.ToolStripMenuItem CreateTest;
        private System.Windows.Forms.ToolStripMenuItem OpenTest;
        private System.Windows.Forms.ToolStripMenuItem SaveTest;
        private System.Windows.Forms.ToolStripMenuItem StartTest;
        private System.Windows.Forms.ListBox FunctionSelection;
        private System.Windows.Forms.ComboBox ModeSelection;
        private System.Windows.Forms.NumericUpDown QuestionIndex;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.ComboBox TypesOfAnswers;
        private System.Windows.Forms.Label AnswerTypeLabel;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.ComboBox SelectionOfAnswers;
        private System.Windows.Forms.Label AnswersLabel;
        private System.Windows.Forms.TextBox AnswerTextBox;
        private System.Windows.Forms.Label AnswerTextBoxLabel;
        public System.Windows.Forms.SaveFileDialog SavingTestWindow;
        private System.Windows.Forms.RadioButton ExampleButton1;
        private System.Windows.Forms.CheckBox ExampleButton2;
        private System.Windows.Forms.CheckBox CorrectAnswerChecker;
        private System.Windows.Forms.OpenFileDialog CreateTestWindow;
    }
}

