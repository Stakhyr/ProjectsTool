using ProjectsTool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectsTool.Repositories.Interfaces
{
    public interface IEmpoyeeRepository:IDbRepository<EmployeeEntity>
    {
        IEnumerable<EmployeeEntity> GetEmployeeProject(int Id);
        IEnumerable<EmployeeEntity>RemoveEmployeeFromProject(int Id);
        IEnumerable<EmployeeEntity> AssignEmployeeToProject(int Id);
    }
}
