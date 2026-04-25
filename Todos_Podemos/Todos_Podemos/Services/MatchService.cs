using Todos_Podemos.Moduls;
using Microsoft.EntityFrameworkCore;
using Todos_Podemos.DB;
using Todos_Podemos.Moduls;

namespace Todos_Podemos.Services
{
    public class MatchService
    {
        private readonly AppDbContext _context;

        public MatchService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Match>> GetMatches()
        {
            return await _context.Matches.ToListAsync();
        }

        public async Task AddMatch(Match match)
        {
            _context.Matches.Add(match);
            await _context.SaveChangesAsync();
        }
    }
}