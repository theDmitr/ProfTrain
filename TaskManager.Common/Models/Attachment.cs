using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Common.Models
{
    public class Attachment
    {
        public Guid Id { get; set; }

        public Task Task { get; set; }

        public string Title { get; set; }

        public byte[] Content { get; set; }
    }
}
