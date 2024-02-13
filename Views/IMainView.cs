using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schedulo.Views
{
    internal interface IMainView
    {
        event Action<string> CreateTask;
        event Action<int> AdvanceTask;
        void DisplayTasks(List<Models.Task> tasks);
    }
}
