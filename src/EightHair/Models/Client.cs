using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EightHair.Models
{
    public enum Gender
    {
        Male = 0,
        Female = 1
    }

    public class Client : EnterpriseDependency
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public Gender Gender { get; set; }
        public DateTime? Birthday { get; set; }

        public virtual ICollection<Schedule> Schedules { get; set; }

        public Client()
        {
            Id = new Guid();
            Schedules = new List<Schedule>();
        }
    }
}
