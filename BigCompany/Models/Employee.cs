using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigCompany.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string Zone { get; set; }
        public string City { get; set; }

        public int ContractId { get; set; }
        public DateOnly ContractStartDate { get; set; }
        public DateOnly ContractEndDate { get; set; }

        [ForeignKey(nameof(department))]
        public int DepId { get; set; } // 3
        // Navigational Property+
        public Department department { get; set; }


        public ICollection<Skill> skills { get; set; } = new HashSet<Skill>();
        public ICollection<Project> projects { get; set; } = new HashSet<Project>();

    }
}
