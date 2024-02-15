using schedulo.Custom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schedulo.Views
{
    public partial class MainView : Form, IMainView
    {
        public event Action<string> CreateTask;
        public event Action<int> AdvanceTask;

        public MainView()
        {
            InitializeComponent();
            this.createTaskButton.Click += (sender, e) => CreateTask?.Invoke(taskContentTextBox.Text);
            this.advanceTaskButton.Click += advanceTaskButton_Click;
        }


        public void DisplayTasks(List<Models.Task> tasks)
        {
            newTasksListBox.Items.Clear();
            endedTasksListBox.Items.Clear();
            foreach (var task in tasks)
            {
                var taskItem = new TaskItem($"{task.Content}", task.Id);
                if (task.TaskStatus.StatusName == "Новая")
                {
                    newTasksListBox.Items.Add(taskItem);
                }
                else if (task.TaskStatus.StatusName == "Выполненная")
                {
                    endedTasksListBox.Items.Add(taskItem);
                }
            }
        }
        private void advanceTaskButton_Click(object sender, EventArgs e)
        {
            if (newTasksListBox.SelectedItem != null)
            {
                var selectedTask = (TaskItem)newTasksListBox.SelectedItem;
                int selectedTaskId = selectedTask.Id;
                AdvanceTask?.Invoke(selectedTaskId);
            }
        }

        private void taskContentTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void createTaskButton_Click(object sender, EventArgs e)
        {

        }
    }

}
