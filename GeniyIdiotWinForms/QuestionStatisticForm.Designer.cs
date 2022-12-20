namespace GeniyIdiotWinForms
{
    partial class QuestionStatisticForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionStatisticForm));
            this.rightAnswerQuestionStatisticDataGridView = new System.Windows.Forms.DataGridView();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RightAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.rightAnswerQuestionStatisticDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rightAnswerQuestionStatisticDataGridView
            // 
            this.rightAnswerQuestionStatisticDataGridView.AllowUserToAddRows = false;
            this.rightAnswerQuestionStatisticDataGridView.AllowUserToDeleteRows = false;
            this.rightAnswerQuestionStatisticDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rightAnswerQuestionStatisticDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Question,
            this.RightAnswer,
            this.TotalAnswer,
            this.Percent});
            this.rightAnswerQuestionStatisticDataGridView.Location = new System.Drawing.Point(12, 30);
            this.rightAnswerQuestionStatisticDataGridView.Name = "rightAnswerQuestionStatisticDataGridView";
            this.rightAnswerQuestionStatisticDataGridView.ReadOnly = true;
            this.rightAnswerQuestionStatisticDataGridView.RowHeadersVisible = false;
            this.rightAnswerQuestionStatisticDataGridView.RowTemplate.Height = 25;
            this.rightAnswerQuestionStatisticDataGridView.Size = new System.Drawing.Size(820, 352);
            this.rightAnswerQuestionStatisticDataGridView.TabIndex = 0;
            // 
            // Question
            // 
            this.Question.HeaderText = "Вопрос";
            this.Question.Name = "Question";
            this.Question.ReadOnly = true;
            this.Question.Width = 500;
            // 
            // RightAnswer
            // 
            this.RightAnswer.HeaderText = "Правильных ответов";
            this.RightAnswer.Name = "RightAnswer";
            this.RightAnswer.ReadOnly = true;
            // 
            // TotalAnswer
            // 
            this.TotalAnswer.HeaderText = "Всего ответов";
            this.TotalAnswer.Name = "TotalAnswer";
            this.TotalAnswer.ReadOnly = true;
            // 
            // Percent
            // 
            this.Percent.HeaderText = "% правильных ответов";
            this.Percent.Name = "Percent";
            this.Percent.ReadOnly = true;
            this.Percent.Width = 115;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 388);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(820, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "&Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(841, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "&Файл";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "&Закрыть";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // QuestionStatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 419);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.rightAnswerQuestionStatisticDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QuestionStatisticForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра \"Гений или Идиот\". Статистика по вопросам";
            this.Load += new System.EventHandler(this.QuestionStatisticForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rightAnswerQuestionStatisticDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView rightAnswerQuestionStatisticDataGridView;
        private Button closeButton;
        private DataGridViewTextBoxColumn Question;
        private DataGridViewTextBoxColumn RightAnswer;
        private DataGridViewTextBoxColumn TotalAnswer;
        private DataGridViewTextBoxColumn Percent;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
    }
}