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
            newTasksListBox = new ListBox();
            taskContentTextBox = new TextBox();
            endedTasksListBox = new ListBox();
            advanceTaskButton = new Button();
            SuspendLayout();
            // 
            // createTaskButton
            // 
            createTaskButton.Location = new Point(326, 11);
            createTaskButton.Name = "createTaskButton";
            createTaskButton.Size = new Size(64, 24);
            createTaskButton.TabIndex = 0;
            createTaskButton.Text = "Create Task";
            createTaskButton.UseVisualStyleBackColor = true;
            createTaskButton.Click += createTaskButton_Click;
            // 
            // newTasksListBox
            // 
            newTasksListBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            newTasksListBox.FormattingEnabled = true;
            newTasksListBox.ItemHeight = 32;
            newTasksListBox.Location = new Point(12, 41);
            newTasksListBox.Name = "newTasksListBox";
            newTasksListBox.Size = new Size(308, 356);
            newTasksListBox.TabIndex = 1;
            // 
            // taskContentTextBox
            // 
            taskContentTextBox.Location = new Point(12, 12);
            taskContentTextBox.Name = "taskContentTextBox";
            taskContentTextBox.Size = new Size(308, 23);
            taskContentTextBox.TabIndex = 2;
            taskContentTextBox.Text = "Task content";
            taskContentTextBox.TextChanged += taskContentTextBox_TextChanged;
            // 
            // endedTasksListBox
            // 
            endedTasksListBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            endedTasksListBox.FormattingEnabled = true;
            endedTasksListBox.ItemHeight = 32;
            endedTasksListBox.Location = new Point(396, 41);
            endedTasksListBox.Name = "endedTasksListBox";
            endedTasksListBox.Size = new Size(309, 356);
            endedTasksListBox.TabIndex = 3;
            // 
            // advanceTaskButton
            // 
            advanceTaskButton.Location = new Point(326, 41);
            advanceTaskButton.Name = "advanceTaskButton";
            advanceTaskButton.Size = new Size(64, 355);
            advanceTaskButton.TabIndex = 4;
            advanceTaskButton.Text = "AdvanceTask";
            advanceTaskButton.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 408);
            Controls.Add(advanceTaskButton);
            Controls.Add(endedTasksListBox);
            Controls.Add(taskContentTextBox);
            Controls.Add(newTasksListBox);
            Controls.Add(createTaskButton);
            Name = "MainView";
            Text = "schedulo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createTaskButton;
        private ListBox newTasksListBox;
        private TextBox taskContentTextBox;
        private ListBox endedTasksListBox;
        private Button advanceTaskButton;
    }
}