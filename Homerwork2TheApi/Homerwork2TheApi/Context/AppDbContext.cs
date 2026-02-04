using Homerwork2TheApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace Homerwork2TheApi.Context
{

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}