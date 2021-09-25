using System;
using System.Collections.Generic;
using System.Linq;

using WebApiCurso.Interfaces.Repositories;
using WebApiCurso.Models;

namespace WebApiCurso.Repositories
{
    public class MemoryDatabaseRepository : IDatabaseRepository
    {
        private readonly List<Task> databaseTasks = new List<Task>();
        public Task CreateTask(Task task)
        {

            task.Id = Guid.NewGuid();
            databaseTasks.Add(task);
            return task;
        }

        public bool DeleteTask(Guid Id)
        {
            var task = GetTask(Id);
            if (task == null)
                return true;


            return databaseTasks.Remove(task);
        }

        public Task GetTask(Guid Id)
        {
            return databaseTasks.FirstOrDefault(parametro => parametro.Id == Id);
        }

        public IEnumerable<Task> GetTasks()
        {
            return databaseTasks;
        }

        public bool UpdateTask(Task task)
        {
            var databasetask = GetTask(task.Id);
            if (databasetask == null)
                return false;

            task = databasetask;
            return true;
        }
    }
}
