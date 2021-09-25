using System;
using System.Collections.Generic;
using System.Linq;

using WebApiCurso.Interfaces.Bussines;
using WebApiCurso.Interfaces.Repositories;
using WebApiCurso.Models;

namespace WebApiCurso.Negocio
{
    public class BussinesTasksManager: IBussinesTasksManager
    {
        private readonly IDatabaseRepository _dbRepository;

        public BussinesTasksManager(IDatabaseRepository dbRepository)
        {
            _dbRepository = dbRepository;
        }

        public IEnumerable<Task> GetTasks(int currentHour,int minHour )
        {
 

            if (currentHour > minHour)
                return null;
            
            return _dbRepository.GetTasks();

        }
    }
}