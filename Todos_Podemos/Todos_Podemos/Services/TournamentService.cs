using Microsoft.EntityFrameworkCore;
using Todos_Podemos.DB;
using Todos_Podemos.Moduls;

namespace Todos_Podemos.Services
{
    public class TournamentService
    {
        private readonly AppDbContext _context;

        public TournamentService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Tournament>> GetTournaments()
        {
            return await _context.Tournaments.ToListAsync();
        }

        public async Task AddTournament(Tournament tournament)
        {
            _context.Tournaments.Add(tournament);
            await _context.SaveChangesAsync();
        }
    }
}