using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Common.Models
{
    public class Project
    {
        public Guid Id { get; set; }

        public string FullTitle { get; set; }

        public string ShortTitle { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? DeletedTime { get; set; }

        public TimeOnly StartScheduledTime { get; set; }

        public TimeOnly FinishScheduledTime { get; set; }

        public string Description { get; set; }

        public Employee CreatorEmployee { get; set; }

        public Employee ResponsibleEmployee { get; set; }
    }
}
