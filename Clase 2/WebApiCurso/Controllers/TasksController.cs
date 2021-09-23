using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using WebApiCurso.Interfaces.Repositories;
using WebApiCurso.Models;

namespace WebApiCurso.Controllers
{
    [Route("api/tasks")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly IDatabaseRepository _databaseRepository;

        public TasksController(IDatabaseRepository databaseRepository)
        {
            _databaseRepository = databaseRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Task>> GetTasks()
        {
            return Ok(_databaseRepository.GetTasks());
        }

        // "/api/tasks/asdasdasd/{id}"
        [HttpGet("{id}")]
        public ActionResult<Task> GetTasks(string id)
        {
            return _databaseRepository.GetTask(id);
        }

        [HttpPost]
        public ActionResult<Task> CreateTask(Task task)
        {
            return _databaseRepository.CreateTask(task);
        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteTask(string id)
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
