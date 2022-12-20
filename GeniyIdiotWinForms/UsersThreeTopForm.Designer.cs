namespace GeniyIdiotWinForms
{
    partial class UsersThreeTopForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersThreeTopForm));
            this.topThreeDataGridView = new System.Windows.Forms.DataGridView();
            this.userPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.topThreeDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topThreeDataGridView
            // 
            this.topThreeDataGridView.AllowUserToAddRows = false;
            this.topThreeDataGridView.AllowUserToDeleteRows = false;
            this.topThreeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.topThreeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userPosition,
            this.userName,
            this.rightAnswer});
            this.topThreeDataGridView.Location = new System.Drawing.Point(12, 27);
            this.topThreeDataGridView.Name = "topThreeDataGridView";
            this.topThreeDataGridView.ReadOnly = true;
            this.topThreeDataGridView.RowHeadersVisible = false;
            this.topThreeDataGridView.RowTemplate.Height = 25;
            this.topThreeDataGridView.Size = new System.Drawing.Size(455, 116);
            this.topThreeDataGridView.TabIndex = 0;
            // 
            // userPosition
            // 
            this.userPosition.HeaderText = "№";
            this.userPosition.Name = "userPosition";
            this.userPosition.ReadOnly = true;
            this.userPosition.Width = 30;
            // 
            // userName
            // 
            this.userName.HeaderText = "ФИО";
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            this.userName.Width = 300;
            // 
            // rightAnswer
            // 
            this.rightAnswer.HeaderText = "Верных ответов";
            this.rightAnswer.Name = "rightAnswer";
            this.rightAnswer.ReadOnly = true;
            this.rightAnswer.Width = 120;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 149);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(455, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(476, 24);
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
            // UsersThreeTopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 180);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.topThreeDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UsersThreeTopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра \"Гений или Идиот\". Топ 3 игрока.";
            this.Load += new System.EventHandler(this.UsersThreeTopForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.topThreeDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView topThreeDataGridView;
        private Button closeButton;
        private DataGridViewTextBoxColumn userPosition;
        private DataGridViewTextBoxColumn userName;
        private DataGridViewTextBoxColumn rightAnswer;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
    }
}