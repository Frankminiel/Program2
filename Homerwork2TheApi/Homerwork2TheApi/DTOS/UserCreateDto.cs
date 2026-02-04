namespace Homerwork2TheApi.DTOS
{
    public class UserCreateDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public string Password { get; internal set; }
    }
}
