namespace GeniyIdiotWinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.exitButton = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.showAllPreviousResultsButton = new System.Windows.Forms.Button();
            this.usersThreeTopButton = new System.Windows.Forms.Button();
            this.questionStatisticButton = new System.Windows.Forms.Button();
            this.addNewQuestionButton = new System.Windows.Forms.Button();
            this.removeQuestionButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllPreviousResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userThreeTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questionStatisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.enableTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableTimerCheckBox = new System.Windows.Forms.CheckBox();
            this.secondsAnswerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondsAnswerNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 281);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(315, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "&Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.applicationExit);
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(12, 38);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(315, 23);
            this.newGameButton.TabIndex = 2;
            this.newGameButton.Text = "&Новая игра";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGame);
            // 
            // showAllPreviousResultsButton
            // 
            this.showAllPreviousResultsButton.Location = new System.Drawing.Point(12, 67);
            this.showAllPreviousResultsButton.Name = "showAllPreviousResultsButton";
            this.showAllPreviousResultsButton.Size = new System.Drawing.Size(315, 23);
            this.showAllPreviousResultsButton.TabIndex = 3;
            this.showAllPreviousResultsButton.Text = "&Прошлые результаты";
            this.showAllPreviousResultsButton.UseVisualStyleBackColor = true;
            this.showAllPreviousResultsButton.Click += new System.EventHandler(this.showAllPreviousResults);
            // 
            // usersThreeTopButton
            // 
            this.usersThreeTopButton.Location = new System.Drawing.Point(12, 96);
            this.usersThreeTopButton.Name = "usersThreeTopButton";
            this.usersThreeTopButton.Size = new System.Drawing.Size(315, 23);
            this.usersThreeTopButton.TabIndex = 4;
            this.usersThreeTopButton.Text = "&Топ 3 игроков";
            this.usersThreeTopButton.UseVisualStyleBackColor = true;
            this.usersThreeTopButton.Click += new System.EventHandler(this.usersThreeTop);
            // 
            // questionStatisticButton
            // 
            this.questionStatisticButton.Location = new System.Drawing.Point(12, 125);
            this.questionStatisticButton.Name = "questionStatisticButton";
            this.questionStatisticButton.Size = new System.Drawing.Size(315, 23);
            this.questionStatisticButton.TabIndex = 5;
            this.questionStatisticButton.Text = "&Статистика по вопросам";
            this.questionStatisticButton.UseVisualStyleBackColor = true;
            this.questionStatisticButton.Click += new System.EventHandler(this.questionStatistic);
            // 
            // addNewQuestionButton
            // 
            this.addNewQuestionButton.Location = new System.Drawing.Point(12, 154);
            this.addNewQuestionButton.Name = "addNewQuestionButton";
            this.addNewQuestionButton.Size = new System.Drawing.Size(315, 23);
            this.addNewQuestionButton.TabIndex = 6;
            this.addNewQuestionButton.Text = "&Добавить новый вопрос";
            this.addNewQuestionButton.UseVisualStyleBackColor = true;
            this.addNewQuestionButton.Click += new System.EventHandler(this.addNewQuestion);
            // 
            // removeQuestionButton
            // 
            this.removeQuestionButton.Location = new System.Drawing.Point(12, 183);
            this.removeQuestionButton.Name = "removeQuestionButton";
            this.removeQuestionButton.Size = new System.Drawing.Size(315, 23);
            this.removeQuestionButton.TabIndex = 7;
            this.removeQuestionButton.Text = "&Удалить вопрос";
            this.removeQuestionButton.UseVisualStyleBackColor = true;
            this.removeQuestionButton.Click += new System.EventHandler(this.removeQuestion);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(339, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.toolStripSeparator1,
            this.statisticsToolStripMenuItem,
            this.toolStripSeparator2,
            this.addNewQuestionToolStripMenuItem,
            this.removeQuestionToolStripMenuItem,
            this.toolStripSeparator3,
            this.enableTimerToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "&Файл";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGameToolStripMenuItem.Text = "&Новая игра";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGame);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllPreviousResultsToolStripMenuItem,
            this.userThreeTopToolStripMenuItem,
            this.questionStatisticToolStripMenuItem});
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.statisticsToolStripMenuItem.Text = "&Статистика";
            // 
            // showAllPreviousResultsToolStripMenuItem
            // 
            this.showAllPreviousResultsToolStripMenuItem.Name = "showAllPreviousResultsToolStripMenuItem";
            this.showAllPreviousResultsToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.showAllPreviousResultsToolStripMenuItem.Text = "&Прошлые результаты";
            this.showAllPreviousResultsToolStripMenuItem.Click += new System.EventHandler(this.showAllPreviousResults);
            // 
            // userThreeTopToolStripMenuItem
            // 
            this.userThreeTopToolStripMenuItem.Name = "userThreeTopToolStripMenuItem";
            this.userThreeTopToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.userThreeTopToolStripMenuItem.Text = "&Топ 3 Игроков";
            this.userThreeTopToolStripMenuItem.Click += new System.EventHandler(this.usersThreeTop);
            // 
            // questionStatisticToolStripMenuItem
            // 
            this.questionStatisticToolStripMenuItem.Name = "questionStatisticToolStripMenuItem";
            this.questionStatisticToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.questionStatisticToolStripMenuItem.Text = "&Статистика по вопросам";
            this.questionStatisticToolStripMenuItem.Click += new System.EventHandler(this.questionStatistic);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // addNewQuestionToolStripMenuItem
            // 
            this.addNewQuestionToolStripMenuItem.Name = "addNewQuestionToolStripMenuItem";
            this.addNewQuestionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewQuestionToolStripMenuItem.Text = "&Добавить вопрос";
            this.addNewQuestionToolStripMenuItem.Click += new System.EventHandler(this.addNewQuestion);
            // 
            // removeQuestionToolStripMenuItem
            // 
            this.removeQuestionToolStripMenuItem.Name = "removeQuestionToolStripMenuItem";
            this.removeQuestionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeQuestionToolStripMenuItem.Text = "&Удалить вопрос";
            this.removeQuestionToolStripMenuItem.Click += new System.EventHandler(this.removeQuestion);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // enableTimerToolStripMenuItem
            // 
            this.enableTimerToolStripMenuItem.CheckOnClick = true;
            this.enableTimerToolStripMenuItem.Name = "enableTimerToolStripMenuItem";
            this.enableTimerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.enableTimerToolStripMenuItem.Text = "В&ключить таймер";
            this.enableTimerToolStripMenuItem.Click += new System.EventHandler(this.enableTimerToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restartToolStripMenuItem.Text = "&Перезапустить";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "&Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.applicationExit);
            // 
            // enableTimerCheckBox
            // 
            this.enableTimerCheckBox.AutoSize = true;
            this.enableTimerCheckBox.Location = new System.Drawing.Point(12, 227);
            this.enableTimerCheckBox.Name = "enableTimerCheckBox";
            this.enableTimerCheckBox.Size = new System.Drawing.Size(124, 19);
            this.enableTimerCheckBox.TabIndex = 9;
            this.enableTimerCheckBox.Text = "&Включить таймер";
            this.enableTimerCheckBox.UseVisualStyleBackColor = true;
            this.enableTimerCheckBox.CheckedChanged += new System.EventHandler(this.enableTimerCheckBox_CheckedChanged);
            // 
            // secondsAnswerNumericUpDown
            // 
            this.secondsAnswerNumericUpDown.Enabled = false;
            this.secondsAnswerNumericUpDown.Location = new System.Drawing.Point(233, 227);
            this.secondsAnswerNumericUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.secondsAnswerNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.secondsAnswerNumericUpDown.Name = "secondsAnswerNumericUpDown";
            this.secondsAnswerNumericUpDown.Size = new System.Drawing.Size(94, 23);
            this.secondsAnswerNumericUpDown.TabIndex = 10;
            this.secondsAnswerNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.secondsAnswerNumericUpDown.ValueChanged += new System.EventHandler(this.secondsAnswerNumericUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "С&екунд на ответ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 310);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondsAnswerNumericUpDown);
            this.Controls.Add(this.enableTimerCheckBox);
            this.Controls.Add(this.removeQuestionButton);
            this.Controls.Add(this.addNewQuestionButton);
            this.Controls.Add(this.questionStatisticButton);
            this.Controls.Add(this.usersThreeTopButton);
            this.Controls.Add(this.showAllPreviousResultsButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра \"Гений или Идиот\"";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondsAnswerNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button exitButton;
        private Button newGameButton;
        private Button showAllPreviousResultsButton;
        private Button usersThreeTopButton;
        private Button questionStatisticButton;
        private Button addNewQuestionButton;
        private Button removeQuestionButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem statisticsToolStripMenuItem;
        private ToolStripMenuItem showAllPreviousResultsToolStripMenuItem;
        private ToolStripMenuItem userThreeTopToolStripMenuItem;
        private ToolStripMenuItem questionStatisticToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem addNewQuestionToolStripMenuItem;
        private ToolStripMenuItem removeQuestionToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem restartToolStripMenuItem;
        private CheckBox enableTimerCheckBox;
        private NumericUpDown secondsAnswerNumericUpDown;
        private Label label1;
        private ToolStripMenuItem enableTimerToolStripMenuItem;
    }
}