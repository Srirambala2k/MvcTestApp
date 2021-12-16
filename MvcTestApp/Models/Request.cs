using System;
using System.Collections.Generic;

namespace MvcTestApp.Models
{
    public partial class Request
    {
        public int RequestId { get; set; }
        public string StudentName { get; set; } = null!;
        public string Subject { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; } = null!;
        public string Action { get; set; } = null!;
    }
}
