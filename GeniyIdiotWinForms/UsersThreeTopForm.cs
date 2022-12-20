using GeniyIdiot.Common;

namespace GeniyIdiotWinForms
{
    public partial class UsersThreeTopForm : Form
    {
        public UsersThreeTopForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UsersThreeTopForm_Load(object sender, EventArgs e)
        {
            var allUsers = Game.GetUserResults();

            if (allUsers.Count != 0)
            {
                var testingUsers = Game.SortingUsers(allUsers);

                var usersTop = testingUsers != null ? testingUsers.Count() : 0;

                if (testingUsers.Count > 3)
                {
                    usersTop = 3;
                }

                topThreeDataGridView.RowCount = usersTop;

                for (int i = 0; i < usersTop; i++)
                {
                    topThreeDataGridView[0, i].Value = i + 1;
                    topThreeDataGridView[1, i].Value = testingUsers[i].Name;
                    topThreeDataGridView[2, i].Value = testingUsers[i].RightAnswer;
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
