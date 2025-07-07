using Moongazing.SkillMap.Application.Dtos;

namespace Moongazing.SkillMap.Application.Interfaces;

public interface IUserService
{
    Task<User> CreateUserAsync(CreateUserDto dto);
    Task<User?> GetUserByIdAsync(Guid id);
    Task<List<User>> GetAllAsync();
}
