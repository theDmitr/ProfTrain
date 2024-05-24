using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Common.Dtos
{
    public class TaskStatusDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Color { get; set; }

        public TaskStatusDto() { }

        public TaskStatusDto(Models.TaskStatus taskStatus)
        {
            if (taskStatus == null)
                return;

            Id = taskStatus.Id;
            Name = taskStatus.Name;
            Color = taskStatus.Color;
        }
    }
}
