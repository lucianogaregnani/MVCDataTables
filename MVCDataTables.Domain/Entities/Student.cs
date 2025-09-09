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

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Name { get; set; }

        [Range(1, 120, ErrorMessage = "Edad inválida")]
        public int Age { get; set; }

        [Required(ErrorMessage = "País obligatorio")]
        public string Country { get; set; }
    }
}
