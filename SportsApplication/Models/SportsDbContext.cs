using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsApplication.Models
{
    public class SportsDbContext : DbContext
    {
        public SportsDbContext(DbContextOptions<SportsDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<TestType> TestTypes { get; set; }
        public DbSet<TestTypeMapper> TestTypeMappers { get; set; }
        public DbSet<UserTestMapper> UserTestMappers { get; set; }
    }
}
