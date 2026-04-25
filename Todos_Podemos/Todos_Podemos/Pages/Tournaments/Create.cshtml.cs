using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Todos_Podemos.Moduls;
using Todos_Podemos.Services;

namespace Todos_Podemos.Pages.Tournaments
{
    public class CreateModel : PageModel
    {
        private readonly TournamentService _service;

        public CreateModel(TournamentService service)
        {
            _service = service;
        }

        [BindProperty]
        public Tournament Tournament { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            await _service.AddTournament(Tournament);

            return RedirectToPage("Index");
        }
    }
}