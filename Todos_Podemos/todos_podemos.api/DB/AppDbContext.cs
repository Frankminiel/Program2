using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using todospodemos.api.Models;

namespace Todos_Podemos.API.DB
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
    }
}