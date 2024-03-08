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
        public ProjectTaskPriority Priority { get; set; } = new ProjectTaskPriority();
        public ProjectTaskStatus Status { get; set; } = new ProjectTaskStatus();
        public List<ProjectTaskHistory> History { get; set; } = new List<ProjectTaskHistory>();
        public List<Comment> Comments { get; set; } = new List<Comment>();
        public User AssignedTo { get; set; }

    }
}