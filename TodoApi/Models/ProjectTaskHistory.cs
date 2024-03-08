using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class ProjectTaskHistory
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public string FieldUpdated { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public DateTime DateUpdated { get; set; }
        public int UserId { get; set; }
    }
}