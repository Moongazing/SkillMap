using Microsoft.EntityFrameworkCore;
using Moongazing.SkillMap.Application.Dtos;
using Moongazing.SkillMap.Application.Interfaces;
using Moongazing.SkillMap.Persistence.Context;

namespace Moongazing.SkillMap.Persistence.Services;

public class UserService : IUserService
{
    private readonly SkillMapDbContext _context;

    public UserService(SkillMapDbContext context)
    {
        _context = context;
    }

    public async Task<User> CreateUserAsync(CreateUserDto dto)
    {
        var user = new User
        {
            Id = Guid.NewGuid(),
            Username = dto.Username,
            Email = dto.Email
        };

        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        return user;
    }

    public async Task<User?> GetUserByIdAsync(Guid id)
        => await _context.Users.Include(u => u.Skills).FirstOrDefaultAsync(u => u.Id == id);

    public async Task<List<User>> GetAllAsync()
        => await _context.Users.Include(u => u.Skills).ToListAsync();
}
