using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectsTool.Entities
{
    public class BaseEntity : IEntity
    {
        public Guid Id { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime DataCreated { get; set; } = DateTime.Now;
        public DateTime? DateUpdated { get; set; }
        public Guid? UserCreated { get; set; }
        public Guid? UserUpdated { get; set; }
    }
}
