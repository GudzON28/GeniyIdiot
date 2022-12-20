using GeniyIdiot.Common;

namespace GeniyIdiotWinForms
{
    public partial class MainForm : Form
    {
        int secondsForAnswer;

        public MainForm()
        {
            InitializeComponent();
        }

        private void newGame(object sender, EventArgs e)
        {
            new GameForm(secondsAnswerNumericUpDown.Enabled, secondsForAnswer).ShowDialog();
        }

        private void applicationExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showAllPreviousResults(object sender, EventArgs e)
        {
            new ShowResultsForm().ShowDialog();
        }

        private void usersThreeTop(object sender, EventArgs e)
        {
            new UsersThreeTopForm().ShowDialog();
        }

        private void questionStatistic(object sender, EventArgs e)
        {
            new QuestionStatisticForm().ShowDialog();
        }

        private void addNewQuestion(object sender, EventArgs e)
        {
            new AddNewQuestionForm().ShowDialog();
        }

        private void removeQuestion(object sender, EventArgs e)
        {
            new RemoveQuestionForm().ShowDialog();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void enableTimerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (enableTimerCheckBox.Checked)
            {
                secondsAnswerNumericUpDown.Enabled = true;
                enableTimerToolStripMenuItem.Checked = true;
                secondsForAnswer = Convert.ToInt32(secondsAnswerNumericUpDown.Value);
            }
            else
            {
                secondsAnswerNumericUpDown.Enabled = false;
                enableTimerToolStripMenuItem.Checked = false;
            }
        }

        private void secondsAnswerNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            secondsForAnswer = Convert.ToInt32(secondsAnswerNumericUpDown.Value);
        }

        private void enableTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (enableTimerToolStripMenuItem.Checked)
            {
                enableTimerCheckBox.Checked = true;
            }
            else
            {
                enableTimerCheckBox.Checked = false;
            }
        }
    }
}