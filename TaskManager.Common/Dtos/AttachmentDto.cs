using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Common.Models;

namespace TaskManager.Common.Dtos
{
    public class AttachmentDto
    {
        public Guid Id { get; set; }

        public TaskDto Task { get; set; }

        public string Title { get; set; }

        public byte[] Content { get; set; }

        public AttachmentDto() { }

        public AttachmentDto(Attachment attachment)
        {
            if (attachment == null)
                return;

            Id = attachment.Id;
            Title = attachment.Title;
            Content = attachment.Content;
            Task = new(attachment.Task);
        }
    }
}
