using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigCompany.Models
{
    public class Department
    {
        
        public int id { get; set; }
        public string name { get; set; }
        public string Location { get; set; }

        public ICollection<Employee> employees { get; set; } = new List<Employee>();
    }
}
