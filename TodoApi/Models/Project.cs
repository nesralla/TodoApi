using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public User Owner { get; set; }
        public List<ProjectTask> Tasks { get; set; }
    }
}