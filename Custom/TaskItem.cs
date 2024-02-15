using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schedulo.Custom
{
    public class TaskItem
    {
        public string DisplayText { get; set; }
        public int Id { get; set; }

        public TaskItem(string displayText, int id)
        {
            DisplayText = displayText;
            Id = id;
        }

        public override string ToString()
        {
            return DisplayText;
        }
    }

}
