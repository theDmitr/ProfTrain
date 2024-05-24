using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Common.Models
{
    public class Comment
    {
        public Guid Id { get; set; }

        public Employee Employee { get; set; }

        public Task Task { get; set; }

        public string Content { get; set; }

        public DateTime Created { get; set; }
    }
}
