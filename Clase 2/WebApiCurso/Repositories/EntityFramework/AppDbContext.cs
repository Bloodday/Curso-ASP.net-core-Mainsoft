using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApiCurso.Repositories.EntityFramework
{
    public class AppDbContext : DbContext
    {
        protected AppDbContext(DbContextOptions opt):base(opt)
        {

        }

        DbSet<Task> Tasks { set; get; }
    }
}
