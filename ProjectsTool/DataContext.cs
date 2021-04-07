using Microsoft.EntityFrameworkCore;
using ProjectsTool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectsTool
{
    public class DataContext:DbContext
    {
        public DbSet<EmployeeEntity> Employees { get; set; }
        public DbSet<ProjectsEntity> Projects { get; set; }

        public DataContext(DbContextOptions<DataContext> options): base(options) { }
    }
}
