using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDataTables.Domain.Entities
{
    public class Student
    {
        public int Id { get; set; }
        [MinLength(3)]
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Country { get; set; }
    }
}
