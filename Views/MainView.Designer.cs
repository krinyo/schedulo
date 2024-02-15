using schedulo.Custom;
namespace schedulo.Views
{
    partial class MainView
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
            createTaskButton = new Button();
            newTasksListBox = new MultiLineListBox();
            taskContentTextBox = new TextBox();
            endedTasksListBox = new MultiLineListBox();
            advanceTaskButton = new Button();
            newTasksLabel = new Label();
            endedTasksLabel = new Label();
            SuspendLayout();
            // 
            // createTaskButton
            // 
            createTaskButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            createTaskButton.Location = new Point(419, 15);
            createTaskButton.Margin = new Padding(4);
            createTaskButton.Name = "createTaskButton";
            createTaskButton.Size = new Size(82, 31);
            createTaskButton.TabIndex = 0;
            createTaskButton.Text = "Create Task";
            createTaskButton.UseVisualStyleBackColor = true;
            createTaskButton.Click += createTaskButton_Click;
            // 
            // newTasksListBox
            // 
            newTasksListBox.BackColor = Color.FromArgb(223, 244, 255);
            newTasksListBox.DrawMode = DrawMode.OwnerDrawVariable;
            newTasksListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            newTasksListBox.FormattingEnabled = true;
            newTasksListBox.ItemHeight = 21;
            newTasksListBox.Location = new Point(13, 86);
            newTasksListBox.Margin = new Padding(4);
            newTasksListBox.Name = "newTasksListBox";
            newTasksListBox.Size = new Size(395, 193);
            newTasksListBox.TabIndex = 1;
            // 
            // taskContentTextBox
            // 
            taskContentTextBox.BackColor = Color.FromArgb(223, 244, 255);
            taskContentTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            taskContentTextBox.Location = new Point(15, 17);
            taskContentTextBox.Margin = new Padding(4);
            taskContentTextBox.Name = "taskContentTextBox";
            taskContentTextBox.Size = new Size(395, 29);
            taskContentTextBox.TabIndex = 2;
            taskContentTextBox.Text = "Task content";
            taskContentTextBox.TextChanged += taskContentTextBox_TextChanged;
            // 
            // endedTasksListBox
            // 
            endedTasksListBox.BackColor = Color.FromArgb(223, 244, 255);
            endedTasksListBox.DrawMode = DrawMode.OwnerDrawVariable;
            endedTasksListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            endedTasksListBox.FormattingEnabled = true;
            endedTasksListBox.ItemHeight = 21;
            endedTasksListBox.Location = new Point(509, 86);
            endedTasksListBox.Margin = new Padding(4);
            endedTasksListBox.Name = "endedTasksListBox";
            endedTasksListBox.Size = new Size(396, 193);
            endedTasksListBox.TabIndex = 3;
            // 
            // advanceTaskButton
            // 
            advanceTaskButton.Location = new Point(419, 84);
            advanceTaskButton.Margin = new Padding(4);
            advanceTaskButton.Name = "advanceTaskButton";
            advanceTaskButton.Size = new Size(82, 195);
            advanceTaskButton.TabIndex = 4;
            advanceTaskButton.Text = "AdvanceTask";
            advanceTaskButton.UseVisualStyleBackColor = true;
            // 
            // newTasksLabel
            // 
            newTasksLabel.AutoSize = true;
            newTasksLabel.ForeColor = Color.FromArgb(223, 244, 255);
            newTasksLabel.Location = new Point(131, 61);
            newTasksLabel.Name = "newTasksLabel";
            newTasksLabel.Size = new Size(111, 21);
            newTasksLabel.TabIndex = 5;
            newTasksLabel.Text = "Новые задачи";
            // 
            // endedTasksLabel
            // 
            endedTasksLabel.AutoSize = true;
            endedTasksLabel.ForeColor = Color.FromArgb(223, 244, 255);
            endedTasksLabel.Location = new Point(631, 61);
            endedTasksLabel.Name = "endedTasksLabel";
            endedTasksLabel.Size = new Size(164, 21);
            endedTasksLabel.TabIndex = 6;
            endedTasksLabel.Text = "Выполненные задачи";
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 65, 101);
            ClientSize = new Size(922, 292);
            Controls.Add(endedTasksLabel);
            Controls.Add(newTasksLabel);
            Controls.Add(advanceTaskButton);
            Controls.Add(endedTasksListBox);
            Controls.Add(taskContentTextBox);
            Controls.Add(newTasksListBox);
            Controls.Add(createTaskButton);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            MinimumSize = new Size(938, 296);
            Name = "MainView";
            Text = "schedulo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createTaskButton;
        private MultiLineListBox newTasksListBox;
        private TextBox taskContentTextBox;
        private MultiLineListBox endedTasksListBox;
        private Button advanceTaskButton;
        private Label newTasksLabel;
        private Label endedTasksLabel;
    }
}