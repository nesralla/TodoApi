using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.Services
{
    public interface IProjectTaskService
    {
        IEnumerable<Project> GetProjects();
        IEnumerable<ProjectTask> GetTasksByProject(int projectId);
        Project CreateProject(Project project);
        ProjectTask AddTaskToProject(int projectId, ProjectTask task);
        ProjectTask UpdateTask(int taskId, ProjectTask task);
        void DeleteTask(int taskId);
    }
}