using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EightHair.Models
{
    public class User : EnterpriseDependency
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User()
        {
            Id = new Guid();
        }
    }
}
