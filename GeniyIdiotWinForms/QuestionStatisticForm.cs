using GeniyIdiot.Common;

namespace GeniyIdiotWinForms
{
    public partial class QuestionStatisticForm : Form
    {
        public QuestionStatisticForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuestionStatisticForm_Load(object sender, EventArgs e)
        {
            var allQuestions = Game.GetQuestions();

            if (allQuestions.Count != 0)
            {
                rightAnswerQuestionStatisticDataGridView.RowCount = allQuestions.Count;

                for (int i = 0; i < allQuestions.Count; i++)
                {
                    rightAnswerQuestionStatisticDataGridView[0, i].Value = allQuestions[i].Text;
                    rightAnswerQuestionStatisticDataGridView[1, i].Value = allQuestions[i].RightAnwerTotal;
                    rightAnswerQuestionStatisticDataGridView[2, i].Value = allQuestions[i].AskTotal;

                    if (allQuestions[i].AskTotal != 0)
                    {
                        var percentRightAnswers = allQuestions[i].RightAnwerTotal * 100 / allQuestions[i].AskTotal;

                        rightAnswerQuestionStatisticDataGridView[3, i].Value = percentRightAnswers;
                    }
                    else
                    {
                        rightAnswerQuestionStatisticDataGridView[3, i].Value = 0;
                    }
                }
            }
            else
            {
                MessageBox.Show("Отсутствует статистика ответов на вопросы");
                this.Close();
            }
        }
    }
}
