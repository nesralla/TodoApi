using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Utils;
namespace TodoApi.Models
{
    public class ProjectTask
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public ProjectTaskPriority Priority { get; set; }
        public ProjectTaskStatus Status { get; set; }
        public List<ProjectTaskHistory> History { get; set; }
        public List<Comment> Comments { get; set; }
        public User AssignedTo { get; set; }

    }
}