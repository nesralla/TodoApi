using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;
using TodoApi.Utils;

namespace TodoApi.Repositories
{
    public class ProjectTaskRepository : IProjectTaskRepository
    {
        private List<Project> _projects = new List<Project>();
        private readonly DataContext _context;

        public ProjectTaskRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Project> GetProjects()
        {
            return _context.Projects;
        }

        public IEnumerable<ProjectTask> GetTasksByProject(int projectId)
        {
            var tasks = _context.Tasks.Select(p => p.ProjectId == projectId);
            if (tasks != null)
            {
                return (IEnumerable<ProjectTask>)tasks;
            }
            return null;
        }

        public Project CreateProject(Project project)
        {
            project.Id = _projects.Count + 1;
            _context.Projects.Add(project);
            _context.SaveChanges();
            return project;
        }

        public ProjectTask AddTaskToProject(int projectId, ProjectTask task)
        {
            var project = _context.Projects.First(p => p.Id == projectId);
            if (project != null)
            {
                task.Id = _context.Tasks.Count() + 1;
                _context.Tasks.Add(task);
                _context.SaveChanges();
                return task;
            }
            return null;
        }

        public ProjectTask UpdateTask(int taskId, ProjectTask task)
        {
            foreach (var project in _projects)
            {
                var existingTask = project.Tasks.Find(t => t.Id == taskId);
                if (existingTask != null)
                {
                    existingTask.Title = task.Title;
                    existingTask.Description = task.Description;
                    existingTask.DueDate = task.DueDate;
                    existingTask.Status = task.Status;
                    return existingTask;
                }
            }
            return null;
        }

        public void DeleteTask(int taskId)
        {
            foreach (var project in _projects)
            {
                var taskToRemove = project.Tasks.Find(t => t.Id == taskId);
                if (taskToRemove != null)
                {
                    project.Tasks.Remove(taskToRemove);
                    break;
                }
            }
        }
    }
}