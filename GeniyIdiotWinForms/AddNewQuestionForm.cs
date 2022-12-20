using GeniyIdiot.Common;

namespace GeniyIdiotWinForms
{
    public partial class AddNewQuestionForm : Form
    {
        public AddNewQuestionForm()
        {
            InitializeComponent();
        }

        private void AddNewQuestionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.Cancel)
            {
                var newQuestion = newQuestionTextBox.Text.Trim();

                if (string.IsNullOrWhiteSpace(newQuestion))
                {
                    MessageBox.Show($"Вы забыли ввести вопрос. Пожалуйста повторите ввод.");
                    e.Cancel = true;
                    newQuestionTextBox.Focus();
                    return;
                }

                if (!CheckUserAnswer(Int32.MinValue, Int32.MaxValue))
                {
                    MessageBox.Show($"Овет должен быть в диапозоне {Int32.MinValue} ... {Int32.MaxValue}");
                    e.Cancel = true;
                    newAnswerTextBox.Focus();
                    return;
                }

                var newAnswer = Convert.ToInt32(newAnswerTextBox.Text.Trim());

                Game.CheckRequaredQuestions();
                Game.AddQuestion(new Question(newQuestion, newAnswer));
                
                MessageBox.Show("Вопрос успешно добавлен.");
            }
        }

        private bool CheckUserAnswer(int userChoiceMinimal, int userChoiceMaximal)
        {
            return int.TryParse(newAnswerTextBox.Text.Trim(), out int x) && x <= userChoiceMaximal && x >= userChoiceMinimal;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cancelButton.PerformClick();
        }
    }
}
