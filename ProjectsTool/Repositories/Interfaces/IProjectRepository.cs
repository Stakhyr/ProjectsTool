using ProjectsTool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectsTool.Repositories.Interfaces
{
    public interface IProjectRepository : IDbRepository<ProjectsEntity>
    {
        IEnumerable<ProjectsEntity> GetDaysCountBeforeRelise(int id);
    }
}
