using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreCrud.Models
{
    public class EmployeeOne
    {
        public int Id { get; set; }
        [Required,MinLength(3)]
        public String Name { get; set; }
        [Required]
        public String Email { get; set; }
        [Required]
        public String Password { get; set; }
    }
}
