using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Common.Models
{
    public class Task
    {
        public Guid Id { get; set; }

        public string ShortTitle { get; set; }
        
        public string FullTitle { get; set; }

        public string Description { get; set; }

        public Employee Creator { get; set; }

        public Employee Executor { get; set; }

        public TaskStatus TaskStatus { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? DeletedTime { get; set; }

        public DateTime? UpdatedTime { get; set; }

        public DateTime DeadLine { get; set; }

        public TimeOnly StartTime { get; set; }

        public TimeOnly FinishTime { get; set; }

        public Task? Previous {  get; set; }
    }
}
