using Microsoft.Extensions.Configuration;

namespace schedulo
{
    internal class CreateTaskButton : Button
    {
        private readonly IConfiguration _configuration;
        public CreateTaskButton(IConfiguration configuration, string Text) 
        {
            _configuration = configuration;
            this.Width = 100;
            this.Height = 30;
            this.Text = Text;
            this.Click += CreateTask;
        }

        private void CreateTask(object sender, EventArgs e) 
        {
            var taskForm = new TaskForm();
            var result = taskForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                using (var dbContext = new MyDbContext(_configuration))
                {
                    var newStatus = dbContext.Statuses.FirstOrDefault(s => s.StatusName == "Новый");
                    if (newStatus == null)
                    {
                        newStatus = new Status { StatusName = "Новый" };
                        dbContext.Statuses.Add(newStatus);
                    }
                    var task = new Task
                    {
                        Content = taskForm.TaskContent.Text,
                        TaskStatus = newStatus
                    };
                    dbContext.Tasks.Add(task);
                    dbContext.SaveChanges();
                }
            }
        }
    }
}
