using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EightHair.Models
{
    public class Enterprise
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }

        public Enterprise()
        {
            Id = new Guid();
        }
    }
}
