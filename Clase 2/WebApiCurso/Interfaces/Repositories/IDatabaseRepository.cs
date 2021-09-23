using System;
using System.Collections.Generic;
using System.Linq;

using WebApiCurso.Models;

namespace WebApiCurso.Interfaces.Repositories
{
    public interface IDatabaseRepository
    {
        IEnumerable<Task> GetTasks();
        Task GetTask(string Id);
        Task CreateTask(Task task);
        bool UpdateTask(Task task);
        bool DeleteTask(string Id);
    }
}
