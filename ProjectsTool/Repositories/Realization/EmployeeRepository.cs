using ProjectsTool.Entities;
using ProjectsTool.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectsTool.Repositories.Realization
{
    public class EmployeeRepository : DBRepository<EmployeeEntity>, IEmpoyeeRepository
    {
        public EmployeeRepository(DataContext context) 
            : base(context) { }
        public IEnumerable<EmployeeEntity> AssignEmployeeToProject(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeEntity> GetEmployeeProject(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeEntity> RemoveEmployeeFromProject(int Id)
        {
            throw new NotImplementedException();
        }

        
    }
}
