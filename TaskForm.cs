using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schedulo
{
    public class TaskForm : Form
    {
        public TextBox TaskContent;
        private Panel panel1;
        private Button okButton;

        private void InitializeComponent()
        {
            TaskContent = new TextBox();
            okButton = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TaskContent
            // 
            TaskContent.Location = new Point(3, 3);
            TaskContent.Name = "TaskContent";
            TaskContent.Size = new Size(250, 23);
            TaskContent.TabIndex = 0;
            // 
            // okButton
            // 
            okButton.Location = new Point(86, 58);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(okButton);
            panel1.Controls.Add(TaskContent);
            panel1.Location = new Point(237, 173);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 84);
            panel1.TabIndex = 2;
            // 
            // TaskForm
            // 
            ClientSize = new Size(816, 480);
            Controls.Add(panel1);
            Name = "TaskForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        public TaskForm()
        {

        }

    }
}
