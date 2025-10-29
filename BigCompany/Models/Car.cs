using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigCompany.Models
{
    public  class Car
    {
        [Key]
        public string CarPlatte { get; set; }

        public string Model { get; set; }
        public string Color { get; set; }

        [ForeignKey(nameof(employee))]
        public int EmpId { get; set; }
        public Employee employee { get; set; }
    }
}
