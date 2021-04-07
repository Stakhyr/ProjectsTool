using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectsTool.Entities
{
    public interface IEntity
    {
        Guid Id { get; set; }
        bool IsActive { get; set; }
        DateTime DataCreated { get; set; }
        DateTime? DateUpdated { get; set; }
        Guid? UserCreated { get;set; }
        Guid? UserUpdated { get; set; }
    }
}
