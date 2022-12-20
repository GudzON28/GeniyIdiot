namespace GeniyIdiotWinForms
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.numberQuestionLabel = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.answerButton = new System.Windows.Forms.Button();
            this.userAnswerTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.answerTimer = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numberQuestionLabel
            // 
            this.numberQuestionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numberQuestionLabel.Location = new System.Drawing.Point(0, 29);
            this.numberQuestionLabel.Name = "numberQuestionLabel";
            this.numberQuestionLabel.Size = new System.Drawing.Size(852, 24);
            this.numberQuestionLabel.TabIndex = 0;
            this.numberQuestionLabel.Text = "Неизвестный номер вопроса";
            this.numberQuestionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.questionLabel.Location = new System.Drawing.Point(12, 62);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(828, 23);
            this.questionLabel.TabIndex = 1;
            this.questionLabel.Text = "Неизвестный вопрос";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(828, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите ответ:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // answerButton
            // 
            this.answerButton.Location = new System.Drawing.Point(12, 186);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(828, 45);
            this.answerButton.TabIndex = 4;
            this.answerButton.Text = "&Ответить";
            this.answerButton.UseVisualStyleBackColor = true;
            // 
            // userAnswerTextBox
            // 
            this.userAnswerTextBox.Location = new System.Drawing.Point(12, 157);
            this.userAnswerTextBox.Name = "userAnswerTextBox";
            this.userAnswerTextBox.Size = new System.Drawing.Size(828, 23);
            this.userAnswerTextBox.TabIndex = 5;
            this.userAnswerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userAnswerTextBox.Leave += new System.EventHandler(this.userAnswerTextBox_Leave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(852, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "&Файл";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.exitToolStripMenuItem.Text = "&Выход из тестирования";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // answerTimer
            // 
            this.answerTimer.Interval = 1000;
            this.answerTimer.Tick += new System.EventHandler(this.answerTimer_Tick);
            // 
            // timerLabel
            // 
            this.timerLabel.Location = new System.Drawing.Point(12, 99);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(828, 23);
            this.timerLabel.TabIndex = 7;
            this.timerLabel.Text = "Оставшееся время для ответа: ";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timerLabel.Visible = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 236);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.userAnswerTextBox);
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.numberQuestionLabel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра \"Гений или Идиот\". Новая игра";
            this.Shown += new System.EventHandler(this.GameForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label numberQuestionLabel;
        private Label questionLabel;
        private Label label3;
        private Button answerButton;
        private TextBox userAnswerTextBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer answerTimer;
        private Label timerLabel;
    }
}