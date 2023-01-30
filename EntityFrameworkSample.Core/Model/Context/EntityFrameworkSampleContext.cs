using EntityFrameworkSample.Core.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSample.Core.Model.Context
{
    public class EntityFrameworkSampleContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
