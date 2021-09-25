using System;
using System.Collections.Generic;
using WebApiCurso.Models;
using System.Linq;

using WebApiCurso.Interfaces.Repositories;

namespace WebApiCurso.Repositories.EntityFramework
{
    public class EntityFrameworkRepository : IDatabaseRepository
    {
        private readonly AppDbContext _dbContext;

        public EntityFrameworkRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task CreateTask(Task task)
        {
            _dbContext.Add(task);

            _dbContext.SaveChanges();
            return null;
        }

        public bool DeleteTask(Guid Id)
        {

            _dbContext.Tasks.Remove(GetTask(Id));
            _dbContext.SaveChanges();
            return true;
        }

        public Task GetTask(Guid Id)
        {
            return _dbContext.Find<Task>(Id);
        }

        public IEnumerable<Task> GetTasks()
        {
            return _dbContext.Tasks.Where(x => true);
        }

        public bool UpdateTask(Task task)
        {
            _dbContext.Tasks.Update(task);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
