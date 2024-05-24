using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Common.Models;

namespace TaskManager.Common.Dtos
{
    public class ObserverDto
    {
        public Guid Id { get; set; }

        public EmployeeDto Employee { get; set; }

        public TaskDto Task { get; set; }

        public ObserverDto() { }

        public ObserverDto(Observer observer)
        {
            if (observer == null)
                return;

            Id = observer.Id;
            Employee = new(observer.Employee);
            Task = new(observer.Task);
        }
    }
}
