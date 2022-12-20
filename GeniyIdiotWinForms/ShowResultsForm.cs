using GeniyIdiot.Common;

namespace GeniyIdiotWinForms
{
    public partial class ShowResultsForm : Form
    {
        public ShowResultsForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowAllPreviousResultsForm_Load(object sender, EventArgs e)
        {
            var userResults = Game.GetUserResults();

            var userCount = userResults != null ? userResults.Count() : 0;
            
            if (userCount != 0)
            {
                foreach (var value in userResults)
                {
                    allResultDataGridView.Rows.Add(value.Name, value.RightAnswer, value.Diagnose);
                }
            }
            else
            {
                MessageBox.Show("Нет сохранённых результатов, пожалуйста пройдите тестирование.");
                this.Close();
            }
        }
    }
}
