using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EightHair.Models
{
    public class EnterpriseDependency
    {
        public Guid EnterpriseId { get; set; }
        public virtual Enterprise Enterprise { get; set; }
    }
}
