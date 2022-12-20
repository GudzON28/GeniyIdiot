using GeniyIdiot.Common;

namespace GeniyIdiotWinForms
{
    public partial class RemoveQuestionForm : Form
    {
        List<Question> allQuestions;

        public RemoveQuestionForm()
        {
            InitializeComponent();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (allQuestions.Count != 0 && DialogResult != DialogResult.Cancel)
            {
                var userChoice = questionsListBox.SelectedIndex;
                Game.RemoveQuestion(allQuestions[userChoice].Text);

                reloadListBox();
            }
        }

        private void RemoveQuestionForm_Load(object sender, EventArgs e)
        {
            reloadListBox();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cancelButton.PerformClick();
        }

        private void reloadListBox()
        {
            questionsListBox.Items.Clear();
            allQuestions = Game.GetQuestions();

            var questionsCount = allQuestions.Count;

            if (questionsCount != 0)
            {
                for (int i = 0; i < questionsCount; i++)
                {
                    questionsListBox.Items.Add(allQuestions[i].Text);
                }
                questionsListBox.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Нет сохранённых вопросов, пожалуйста добавьте вопрос.");
                this.Close();
            }
        }
    }
}
