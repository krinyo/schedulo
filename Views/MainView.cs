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
                if (task.TaskStatus.StatusName == "Новая")
                {
                    newTasksListBox.Items.Add(new Tuple<string, int>($"{task.Content} - {task.TaskStatus.StatusName}", task.Id));
                }
                else if (task.TaskStatus.StatusName == "Выполненная")
                {
                    endedTasksListBox.Items.Add(new Tuple<string, int>($"{task.Content} - {task.TaskStatus.StatusName}", task.Id));
                }
            }
        }
        private void advanceTaskButton_Click(object sender, EventArgs e)
        {
            if (newTasksListBox.SelectedItem != null)
            {
                var selectedTaskId = ((Tuple<string, int>)newTasksListBox.SelectedItem).Item2;
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
