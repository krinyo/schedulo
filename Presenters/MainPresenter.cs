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
            var tasks = _context.Tasks.ToList();
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
            // Здесь вы можете добавить логику продвижения задачи
            // ...
        }
    }
}
