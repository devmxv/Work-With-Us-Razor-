using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkWithUsRazor.Model
{
    public class Vacancy
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public int Salary { get; set; }
        [Required]
        public int Status { get; set; }
        public string Comment { get; set; }


    }
}
