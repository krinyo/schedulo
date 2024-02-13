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
            this.tasksListBox.SelectedIndexChanged += (sender, e) => AdvanceTask?.Invoke(tasksListBox.SelectedIndex);
        }


        public void DisplayTasks(List<Models.Task> tasks)
        {
            tasksListBox.Items.Clear();
            foreach (var task in tasks)
            {
                tasksListBox.Items.Add($"{task.Content} - {task.TaskStatus}");
            }
        }

    }

}
