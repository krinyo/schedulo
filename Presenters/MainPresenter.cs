using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using schedulo.Data;
using schedulo.Models;
using schedulo.Views;

namespace schedulo.Presenters
{
    internal class MainPresenter
    {
        private IMainView _view;
        private MyDbContext _context;

        public MainPresenter(IMainView view, IConfiguration configuration)
        {
            _view = view;
            _context = new MyDbContext(configuration);
            _context.Initialize();

            _view.CreateTask += OnCreateTask;
            _view.AdvanceTask += OnAdvanceTask;

            LoadTasks();
        }

        public void LoadTasks()
        {
            var tasks = _context.Tasks.Include(t => t.TaskStatus).ToList();
            _view.DisplayTasks(tasks);
        }

        private void OnCreateTask(string taskContent)
        {
            var newStatus = _context.Statuses.FirstOrDefault(s => s.StatusName == "Новая");
            if (newStatus == null)
            {
                newStatus = new Status { StatusName = "Новая" };
                _context.Statuses.Add(newStatus);
                _context.SaveChanges();
            }
            var newTask = new Models.Task { Content = taskContent, TaskStatus = newStatus };
            _context.Tasks.Add(newTask);
            _context.SaveChanges();
            LoadTasks();
        }

        private void OnAdvanceTask(int taskId)
        {
            if (taskId >= 0)
            {
                var task = _context.Tasks.Where(t => t.Id == taskId).FirstOrDefault();
                var nextStatus = _context.Statuses
                    .Where(s => s.Order > task.TaskStatus.Order)
                    .OrderBy(s => s.Order)
                    .FirstOrDefault();
                if (nextStatus != null)
                {
                    task.TaskStatus = nextStatus;
                    _context.SaveChanges();
                    LoadTasks();
                }
            }
        }


    }
}
