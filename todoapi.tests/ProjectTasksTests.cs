using System.Collections.Generic;
using NUnit.Framework;
using TodoApi.Models;
using TodoApi.Services;

namespace todoapi.tests;
[TestFixture]
public class ProjectTasksTests
{
    private IProjectTaskService _taskManagerService;

    [SetUp]
    public void Setup()
    {
        // Inicialização do serviço de gerenciamento de tarefas
        _taskManagerService = new IProjectTaskService();
    }

    [Test]
    public void TestCreateProject()
    {
        // Testa a criação de um projeto
        var project = new Project { Id = 1, Name = "Test Project" };
        _taskManagerService.CreateProject(project);
        Assert.IsTrue(_taskManagerService.GetProjects().Contains(project));
    }

    [Test]
    public void TestCreateTask()
    {
        // Testa a criação de uma tarefa
        var project = new Project { Id = 1, Name = "Test Project" };
        var task = new Task { Id = 1, Title = "Test Task", ProjectId = project.Id };
        _taskManagerService.CreateTask(task);
        Assert.IsTrue(_taskManagerService.GetTasksByProject(project.Id).Contains(task));
    }

}