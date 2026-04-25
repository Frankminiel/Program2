using Microsoft.AspNetCore.Mvc.RazorPages;
using Todos_Podemos.Moduls;
using Todos_Podemos.Services;

namespace Todos_Podemos.Pages.Matches
{
    public class IndexModel : PageModel
    {
        private readonly MatchService _service;

        public IndexModel(MatchService service)
        {
            _service = service;
        }

        public List<Match> Matches { get; set; }

        public async Task OnGetAsync()
        {
            Matches = await _service.GetMatches();
        }
    }
}