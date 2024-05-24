using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Common.Models;

namespace TaskManager.Common.Dtos
{
    public class CommentDto
    {
        public Guid Id { get; set; }

        public EmployeeDto Employee { get; set; }

        public TaskDto Task { get; set; }

        public string Content { get; set; }

        public DateTime Created { get; set; }

        public CommentDto() { }

        public CommentDto(Comment comment)
        {
            if (comment == null)
                return;

            Id = comment.Id;
            Employee = new(comment.Employee);
            Task = new(comment.Task);
            Content = comment.Content;
            Created = comment.Created;
        }
    }
}
