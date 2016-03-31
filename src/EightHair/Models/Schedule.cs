using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EightHair.Models
{
    public class Schedule : EnterpriseDependency
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }

        public Guid ClientId { get; set; }
        public virtual Client Client { get; set; }

        public Guid EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        public Schedule()
        {
            Id = new Guid();
        }
    }
}
