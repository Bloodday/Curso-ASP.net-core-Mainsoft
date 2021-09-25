using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Collections.Generic;

using WebApiCurso.Interfaces.Repositories;
using WebApiCurso.Models;
using WebApiCurso.Negocio;
using WebApiCurso.Repositories;

namespace TestProject
{
    [TestClass]
    public class BussinessTasksManagerTests
    {
        [TestMethod]
        public void se_pueden_obtener_las_tareas_antes_de_la_hora_minima()
        {
            IDatabaseRepository database = new MemoryDatabaseRepository();
            var bussinessTasksManager = new BussinesTasksManager(database);

            int minHour = 16;
            int currentHour = 3;

            var result = bussinessTasksManager.GetTasks(currentHour, minHour);
       
            Assert.AreNotEqual(null, result, "No se puede acceder a las tareas antes de la hora estipulada");
        }
    }
}
