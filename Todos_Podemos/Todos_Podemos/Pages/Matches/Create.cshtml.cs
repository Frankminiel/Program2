using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Todos_Podemos.Moduls;
using Todos_Podemos.Services;

namespace Todos_Podemos.Pages.Matches
{
    public class CreateModel : PageModel
    {
        private readonly MatchService _service;

        public CreateModel(MatchService service)
        {
            _service = service;
        }

        [BindProperty]
        public Match Match { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            await _service.AddMatch(Match);

            return RedirectToPage("Index");
        }
    }
}