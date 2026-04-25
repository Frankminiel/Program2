using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Todos_Podemos.Moduls;
using Todos_Podemos.Services;

namespace Todos_Podemos.Pages.Players
{
    public class CreateModel : PageModel
    {
        private readonly PlayerService _service;

        public CreateModel(PlayerService service)
        {
            _service = service;
        }

        [BindProperty]
        public Player Player { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            await _service.AddPlayer(Player);

            return RedirectToPage("Index");
        }
    }
}