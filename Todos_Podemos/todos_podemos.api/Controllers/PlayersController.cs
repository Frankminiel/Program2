using Microsoft.AspNetCore.Mvc;
using Todos_Podemos.API.DB;
using todospodemos.api.Models;

namespace todos_podemos.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PlayersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Players.ToList());
        }

        [HttpPost]
        public IActionResult Post(Player player)
        {
            _context.Players.Add(player);
            _context.SaveChanges();
            return Ok(player);
        }
    }
}