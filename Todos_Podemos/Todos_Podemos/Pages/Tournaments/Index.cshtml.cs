using Microsoft.AspNetCore.Mvc.RazorPages;
using Todos_Podemos.Moduls;
using Todos_Podemos.Services;

namespace Todos_Podemos.Pages.Tournaments
{
    public class IndexModel : PageModel
    {
        private readonly TournamentService _service;

        public IndexModel(TournamentService service)
        {
            _service = service;
        }

        public List<Tournament> Tournaments { get; set; } = new();

        public async Task OnGetAsync()
        {
            Tournaments = await _service.GetTournaments();
        }
    }
}