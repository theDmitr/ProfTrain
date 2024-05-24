using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Common.Models;

namespace TaskManager.Common.Dtos
{
    public class ProjectDto
    {
        public Guid Id { get; set; }

        public string FullTitle { get; set; }

        public string ShortTitle { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? DeletedTime { get; set; }

        public TimeOnly StartScheduledTime { get; set; }

        public TimeOnly FinishScheduledTime { get; set; }

        public string Description { get; set; }

        public EmployeeDto CreatorEmployee { get; set; }

        public EmployeeDto ResponsibleEmployee { get; set; }

        public ProjectDto() { }

        public ProjectDto(Project project)
        {
            if (project == null)
                return;

            Id = project.Id;
            FullTitle = project.FullTitle;
            ShortTitle = project.ShortTitle;
            CreatedTime = project.CreatedTime;
            DeletedTime = project.DeletedTime;
            StartScheduledTime = project.StartScheduledTime;
            FinishScheduledTime = project.FinishScheduledTime;
            Description = project.Description;
            CreatorEmployee = new(project.CreatorEmployee);
            ResponsibleEmployee = new(project.ResponsibleEmployee);
        }
    }
}
