using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;

using WebApiCurso.Interfaces.Bussines;
using WebApiCurso.Interfaces.Repositories;
using WebApiCurso.Models;

namespace WebApiCurso.Controllers
{
    [Route("api/tasks")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly IDatabaseRepository _databaseRepository;
        private readonly IBussinesTasksManager _bussinesTasksManager;

        public TasksController(IDatabaseRepository databaseRepository, IBussinesTasksManager bussinesTasksManager)
        {
            _databaseRepository = databaseRepository;
            _bussinesTasksManager = bussinesTasksManager;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Task>> GetTasks()
        {
            return Ok(_bussinesTasksManager.GetTasks(DateTime.Now.Hour,16));
        }

        // "/api/tasks/asdasdasd/{id}"
        [HttpGet("{id}")]
        public ActionResult<Task> GetTasks(Guid id)
        {
            return _databaseRepository.GetTask(id);
        }

        [HttpPost]
        public ActionResult<Task> CreateTask(Task task)
        {
            return _databaseRepository.CreateTask(task);
        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteTask(Guid id)
        {
            return _databaseRepository.DeleteTask(id);
        }

        [HttpPut]
        public ActionResult<bool> UpdateTask(Task task)
        {
            return _databaseRepository.UpdateTask(task);
        }

    }
}
