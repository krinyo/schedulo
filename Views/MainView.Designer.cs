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
            tasksListBox = new ListBox();
            taskContentTextBox = new TextBox();
            SuspendLayout();
            // 
            // createTaskButton
            // 
            createTaskButton.Location = new Point(12, 12);
            createTaskButton.Name = "createTaskButton";
            createTaskButton.Size = new Size(103, 23);
            createTaskButton.TabIndex = 0;
            createTaskButton.Text = "button1";
            createTaskButton.UseVisualStyleBackColor = true;
            // 
            // tasksListBox
            // 
            tasksListBox.FormattingEnabled = true;
            tasksListBox.ItemHeight = 15;
            tasksListBox.Location = new Point(12, 41);
            tasksListBox.Name = "tasksListBox";
            tasksListBox.Size = new Size(700, 349);
            tasksListBox.TabIndex = 1;
            // 
            // taskContentTextBox
            // 
            taskContentTextBox.Location = new Point(121, 12);
            taskContentTextBox.Name = "taskContentTextBox";
            taskContentTextBox.Size = new Size(584, 23);
            taskContentTextBox.TabIndex = 2;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 408);
            Controls.Add(taskContentTextBox);
            Controls.Add(tasksListBox);
            Controls.Add(createTaskButton);
            Name = "MainView";
            Text = "MainView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createTaskButton;
        private ListBox tasksListBox;
        private TextBox taskContentTextBox;
    }
}