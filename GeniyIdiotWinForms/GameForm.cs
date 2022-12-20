using GeniyIdiot.Common;

namespace GeniyIdiotWinForms
{
    public partial class GameForm : Form
    {
        List<Question> questions;
        int questionsCount;
        List<int> randomIndexes;
        User user = new User("Неизвестное имя");
        int timerTicks;
        int timerConfig;

        public GameForm(bool isTimerEnable, int secondsForAnswer)
        {
            timerConfig = secondsForAnswer;
            var userNameForm = new UserNameForm();

            if (userNameForm.ShowDialog() == DialogResult.OK)
            {
                user.Name = userNameForm.userNameTextBox.Text.Trim();
            }

            InitializeComponent();

            Game.CheckRequaredQuestions();

            questions = Game.GetQuestions();

            questionsCount = questions.Count;
            randomIndexes = Game.GetRandomIndexes(questionsCount);
            user.RightAnswer = 0;

            if (isTimerEnable)
            {
                answerTimer.Enabled = true;
                timerLabel.Visible = true;
                timerTicks = secondsForAnswer;
                timerLabel.Text = $"Оставшееся время для ответа: {secondsForAnswer}";
                answerTimer.Start();
            }
            else
            {
                answerTimer.Enabled = false;
                timerLabel.Visible = false;
            }

            numberQuestionLabel.Text = $"Вопрос №{randomIndexes[0] + 1}";
            questionLabel.Text = questions[randomIndexes[0]].Text;
        }

        private void userAnswerTextBox_Leave(object sender, EventArgs e)
        {
            if (DialogResult == DialogResult.Cancel)
            {
                answerTimer.Stop();
                this.Close();
                return;
            }

            var checkUserAnswer = CheckUserAnswer(Int32.MinValue, Int32.MaxValue);

            if (checkUserAnswer)
            {
                answerTimer.Stop();

                var userAnswer = Convert.ToInt32(userAnswerTextBox.Text);

                questions[randomIndexes[0]].IsAnswerCorrect = 0;
                questions[randomIndexes[0]].AskTotal++;

                if (userAnswer == questions[randomIndexes[0]].RightAnswer)
                {
                    user.RightAnswer++;
                    questions[randomIndexes[0]].IsAnswerCorrect++;
                    questions[randomIndexes[0]].RightAnwerTotal++;
                }

                answerButton.PerformClick();
                randomIndexes.RemoveAt(0);

                if (randomIndexes.Count == 0)
                {
                    EndGame(user, questions);

                    this.Close();
                    return;
                }

                numberQuestionLabel.Text = $"Вопрос №{randomIndexes[0] + 1}";
                questionLabel.Text = questions[randomIndexes[0]].Text;

                userAnswerTextBox.Focus();
                userAnswerTextBox.Clear();
                timerTicks = timerConfig;
                timerLabel.Text = $"Оставшееся время для ответа: {timerTicks}";
                answerTimer.Start();
            }
            else
            {
                MessageBox.Show($"Овет должен быть числом и быть в диапозоне {Int32.MinValue} ... {Int32.MaxValue}");
                userAnswerTextBox.Focus();
            }
        }

        private bool CheckUserAnswer(int userChoiceMinimal, int userChoiceMaximal)
        {
            return int.TryParse(userAnswerTextBox.Text.Trim(), out int x) && x <= userChoiceMaximal && x >= userChoiceMinimal;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void answerTimer_Tick(object sender, EventArgs e)
        {
            timerTicks--;
            timerLabel.Text = $"Оставшееся время для ответа: {timerTicks}";

            if (timerTicks == 0)
            {
                answerTimer.Stop();
                timerTicks = timerConfig;

                questionLabel.Text = String.Empty;

                MessageBox.Show("Время вышло, переходим к следующему вопросу.");

                answerButton.PerformClick();
                questions[randomIndexes[0]].IsAnswerCorrect = 0;
                questions[randomIndexes[0]].AskTotal++;
                randomIndexes.RemoveAt(0);

                if (randomIndexes.Count == 0)
                {
                    EndGame(user, questions);

                    this.Close();
                    return;
                }

                numberQuestionLabel.Text = $"Вопрос №{randomIndexes[0] + 1}";
                questionLabel.Text = questions[randomIndexes[0]].Text;

                userAnswerTextBox.Focus();
                userAnswerTextBox.Clear();
                timerLabel.Text = $"Оставшееся время для ответа: {timerTicks}";
                answerTimer.Start();
            }
        }

        private void GameForm_Shown(object sender, EventArgs e)
        {
            userAnswerTextBox.Focus();
        }

        private void EndGame(User user, List<Question> questions)
        {
            user.Diagnose = Game.GetDiagnose(questionsCount, user.RightAnswer);

            Game.Save(questions);
            Game.SaveResultTesting(user);

            MessageBox.Show($"Количество верных ответов: {user.RightAnswer}\n" +
                $"{user.Name}, Ваш дигноз: {user.Diagnose}");

            numberQuestionLabel.Text = "";
            questionLabel.Text = "Тест пройден!";
        }
    }
}
