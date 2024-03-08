using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;
using TodoApi.Repositories;

namespace TodoApi.Services
{
    public class ProjectTaskService : IProjectTaskService
    {
        private readonly IProjectTaskRepository _taskRepository;

        public ProjectTaskService(IProjectTaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public IEnumerable<Project> GetProjects()
        {
            return _taskRepository.GetProjects();
        }

        public IEnumerable<ProjectTask> GetTasksByProject(int projectId)
        {
            return _taskRepository.GetTasksByProject(projectId);
        }

        public Project CreateProject(Project project)
        {
            return _taskRepository.CreateProject(project);
        }

        public ProjectTask AddTaskToProject(int projectId, ProjectTask task)
        {
            return _taskRepository.AddTaskToProject(projectId, task);
        }

        public ProjectTask UpdateTask(int taskId, ProjectTask task)
        {
            return _taskRepository.UpdateTask(taskId, task);
        }

        public void DeleteTask(int taskId)
        {
            _taskRepository.DeleteTask(taskId);
        }
    }
}