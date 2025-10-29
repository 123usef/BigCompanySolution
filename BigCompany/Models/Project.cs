using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigCompany.Models
{
    public class Project
    {
        public int Id   { get; set; }
        public string Name { get; set; }

        public ICollection<Employee> employees { get; set; } = new HashSet<Employee>();
        public ICollection<Skill> skills { get; set; } = new HashSet<Skill>();
    }
}
