using School.Domain.Entities;

namespace School.Application.Contract
{
    public interface IUserService1
    {
        Task<List<User>> GetAllUsers();
        Task<User?> GetUser(int id);
        Task<User> CreateUser(User user);
        Task UpdateUser(User user);
        Task DeleteUser(int id);
    }
}