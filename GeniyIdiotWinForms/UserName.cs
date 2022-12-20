namespace GeniyIdiotWinForms
{
    public partial class UserNameForm : Form
    {
        public UserNameForm()
        {
            InitializeComponent();
            userNameTextBox.Focus();
        }

        private void userNameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (userNameTextBox.Text == "")
            {
                MessageBox.Show("Пожалуйста введите имя.");
                e.Cancel = true;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
