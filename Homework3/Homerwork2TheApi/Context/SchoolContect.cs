using School.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace School.Infrastructure.Context
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}