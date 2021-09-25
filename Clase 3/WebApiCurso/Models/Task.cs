using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCurso.Models
{
    public class Task
    {
        public Guid Id { set; get; }

        [MaxLength(100)]
        [Required]
        public string Name { get; set; } = null;
        public bool Completed { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
