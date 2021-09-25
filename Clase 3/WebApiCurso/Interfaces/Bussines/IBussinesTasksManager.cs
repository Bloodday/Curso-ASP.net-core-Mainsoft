using System;
using System.Collections.Generic;
using System.Linq;

using WebApiCurso.Models;

namespace WebApiCurso.Interfaces.Bussines
{
    public interface IBussinesTasksManager
    {
        IEnumerable<Task> GetTasks(int currenntHour, int minHour);
    }
}
