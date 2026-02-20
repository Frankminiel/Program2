using School.Infrastructure.Context;
using School.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Homerwork2TheApi.DTOS;


namespace Homework2TheApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        public SchoolContext Context { get; }

        public UsersController(SchoolContext context)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
        }

        // GET: api/users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserReadDto>>> Get()
        {
            var users = await Context.Users
                .Select(u => new UserReadDto
                {
                    Id = u.Id,
                    Name = u.Name,
                    Email = u.Email,
                    CreatedAt = u.CreatedAt
                })
                .ToListAsync();

            return Ok(users);
        }

        // POST: api/users
        [HttpPost]
        public async Task<ActionResult> Post(UserCreateDto dto)
        {
            var user = new User
            {
                Name = dto.Name,
                Email = dto.Email,
                Password = dto.Password,
                CreatedAt = DateTime.Now
            };

            Context.Users.Add(user);
            await Context.SaveChangesAsync();

            return Ok(user);
        }

        // PUT: api/users/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, UserUpdateDto dto)
        {
            var user = await Context.Users.FindAsync(id);
            if (user == null)
                return NotFound();

            user.Name = dto.Name;
            user.Email = dto.Email;

            await Context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/users/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var user = await Context.Users.FindAsync(id);
            if (user == null)
                return NotFound();

            Context.Users.Remove(user);
            await Context.SaveChangesAsync();
            return NoContent();
        }
    }
}
            