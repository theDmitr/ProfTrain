using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Common.Models;

namespace TaskManager.Common.Dtos
{
    public class TaskDto
    {
        public Guid Id { get; set; }

        public string ShortTitle { get; set; }

        public string FullTitle { get; set; }

        public string Description { get; set; }

        public EmployeeDto Creator { get; set; }

        public EmployeeDto Executor { get; set; }

        public TaskStatusDto TaskStatus { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? DeletedTime { get; set; }

        public DateTime? UpdatedTime { get; set; }

        public DateTime DeadLine { get; set; }

        public TimeOnly StartTime { get; set; }

        public TimeOnly FinishTime { get; set; }

        public TaskDto? Previous { get; set; }

        public TaskDto() { }

        public TaskDto(Models.Task task)
        {
            if (task == null)
                return;

            Id = task.Id;
            ShortTitle = task.ShortTitle;
            FullTitle = task.FullTitle;
            Description = task.Description;
            Creator = new(task.Creator);
            Executor = new(task.Executor);
            TaskStatus = new(task.TaskStatus);
            CreatedTime = task.CreatedTime;
            DeletedTime = task.DeletedTime;
            UpdatedTime = task.UpdatedTime;
            DeadLine = task.DeadLine;
            StartTime = task.StartTime;
            FinishTime = task.FinishTime;
            Previous = task.Previous == null ? null : new(task.Previous);
        }
    }
}
