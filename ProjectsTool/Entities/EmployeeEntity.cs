using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectsTool.Entities
{
    public class EmployeeEntity :BaseEntity
    {
        public string FullName { get; set; }
        public string WorkPosition { get; set; }
    }
}
