
namespace Test_Passing
{
    partial class Test_passing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BackButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.AnswersMultiple = new System.Windows.Forms.CheckedListBox();
            this.QuestionTextBox = new System.Windows.Forms.TextBox();
            this.AnswersSingle = new System.Windows.Forms.ComboBox();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.PercentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Enabled = false;
            this.BackButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(12, 221);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 28);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Enabled = false;
            this.NextButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextButton.Location = new System.Drawing.Point(297, 221);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 28);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Далее";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // AnswersMultiple
            // 
            this.AnswersMultiple.BackColor = System.Drawing.Color.Lime;
            this.AnswersMultiple.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AnswersMultiple.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswersMultiple.FormattingEnabled = true;
            this.AnswersMultiple.Location = new System.Drawing.Point(93, 215);
            this.AnswersMultiple.Name = "AnswersMultiple";
            this.AnswersMultiple.Size = new System.Drawing.Size(198, 42);
            this.AnswersMultiple.TabIndex = 2;
            this.AnswersMultiple.Visible = false;
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.BackColor = System.Drawing.Color.Lime;
            this.QuestionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuestionTextBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionTextBox.ForeColor = System.Drawing.Color.Black;
            this.QuestionTextBox.Location = new System.Drawing.Point(12, 12);
            this.QuestionTextBox.Multiline = true;
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.Size = new System.Drawing.Size(360, 197);
            this.QuestionTextBox.TabIndex = 3;
            this.QuestionTextBox.Text = "Здесь должен был быть вопрос...";
            // 
            // AnswersSingle
            // 
            this.AnswersSingle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AnswersSingle.FormattingEnabled = true;
            this.AnswersSingle.Location = new System.Drawing.Point(93, 221);
            this.AnswersSingle.Name = "AnswersSingle";
            this.AnswersSingle.Size = new System.Drawing.Size(198, 21);
            this.AnswersSingle.TabIndex = 4;
            this.AnswersSingle.Visible = false;
            // 
            // Progress
            // 
            this.Progress.Location = new System.Drawing.Point(12, 142);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(360, 23);
            this.Progress.TabIndex = 5;
            this.Progress.Visible = false;
            // 
            // PercentLabel
            // 
            this.PercentLabel.AutoSize = true;
            this.PercentLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PercentLabel.Location = new System.Drawing.Point(162, 109);
            this.PercentLabel.Name = "PercentLabel";
            this.PercentLabel.Size = new System.Drawing.Size(43, 30);
            this.PercentLabel.TabIndex = 6;
            this.PercentLabel.Text = "0%";
            // 
            // Test_passing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.PercentLabel);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.QuestionTextBox);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AnswersSingle);
            this.Controls.Add(this.AnswersMultiple);
            this.Name = "Test_passing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test_passing";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Test_passing_FormClosed);
            this.Load += new System.EventHandler(this.Test_passing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.CheckedListBox AnswersMultiple;
        private System.Windows.Forms.TextBox QuestionTextBox;
        private System.Windows.Forms.ComboBox AnswersSingle;
        private System.Windows.Forms.ProgressBar Progress;
        private System.Windows.Forms.Label PercentLabel;
    }
}