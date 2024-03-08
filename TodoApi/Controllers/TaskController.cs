using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;
using TodoApi.Services;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly IProjectTaskService _taskService;

        public TaskController(IProjectTaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet("projects")]
        public ActionResult<IEnumerable<Project>> GetProjects()
        {
            var projects = _taskService.GetProjects();
            return Ok(projects);
        }

        [HttpGet("tasks/{projectId}")]
        public ActionResult<IEnumerable<Task>> GetTasksByProject(int projectId)
        {
            var tasks = _taskService.GetTasksByProject(projectId);
            return Ok(tasks);
        }

        [HttpPost("projects")]
        public ActionResult<Project> CreateProject(Project project)
        {
            var newProject = _taskService.CreateProject(project);
            return CreatedAtAction(nameof(GetProjects), new { id = newProject.Id }, newProject);
        }

        [HttpPost("tasks/{projectId}")]
        public ActionResult<ProjectTask> AddTaskToProject(int projectId, ProjectTask task)
        {
            var newTask = _taskService.AddTaskToProject(projectId, task);
            return CreatedAtAction(nameof(GetTasksByProject), new { projectId = projectId }, newTask);
        }

        [HttpPut("tasks/{taskId}")]
        public ActionResult<ProjectTask> UpdateTask(int taskId, ProjectTask task)
        {
            var updatedTask = _taskService.UpdateTask(taskId, task);
            return Ok(updatedTask);
        }

        [HttpDelete("tasks/{taskId}")]
        public IActionResult DeleteTask(int taskId)
        {
            _taskService.DeleteTask(taskId);
            return NoContent();
        }
    }
}