using Microsoft.AspNetCore.Mvc.RazorPages;
using Todos_Podemos.Moduls;
using Todos_Podemos.Services;

namespace Todos_Podemos.Pages.Players
{
    public class IndexModel : PageModel
    {
        private readonly PlayerService _service;

        public IndexModel(PlayerService service)
        {
            _service = service;
        }

        public List<Player> Players { get; set; } = new();

        public async Task OnGetAsync()
        {
            Players = await _service.GetPlayers();
        }
    }
}