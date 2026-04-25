using Microsoft.EntityFrameworkCore;
using Todos_Podemos.DB;
using Todos_Podemos.Moduls;

namespace Todos_Podemos.Services
{
    public class PlayerService
    {
        private readonly AppDbContext _context;

        public PlayerService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Player>> GetPlayers()
        {
            return await _context.Players.ToListAsync();
        }

        public async Task AddPlayer(Player player)
        {
            _context.Players.Add(player);
            await _context.SaveChangesAsync();
        }
    }
}