using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Common.Models
{
    public class Observer
    {
        public Guid Id { get; set; }

        public Employee Employee { get; set; }

        public Task Task { get; set; }
    }
}
