using System;
using System.Collections.Generic;
using WebApiCurso.Models;
using System.Linq;

using WebApiCurso.Interfaces.Repositories;

namespace WebApiCurso.Repositories.EntityFramework
{
    public class EntityFrameworkRepository : IDatabaseRepository
    {
        public Task CreateTask(Task task)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTask(string Id)
        {
            throw new NotImplementedException();
        }

        public Task GetTask(string Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Task> GetTasks()
        {
            throw new NotImplementedException();
        }

        public bool UpdateTask(Task task)
        {
            throw new NotImplementedException();
        }
    }
}
