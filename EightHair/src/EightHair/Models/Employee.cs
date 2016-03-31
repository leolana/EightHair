using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EightHair.Models
{
    public class Employee : EnterpriseDependency
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime? Birthday { get; set; }
        public decimal Salary { get; set; }

        public Employee()
        {
            Id = new Guid();
        }
    }
}
