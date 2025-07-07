using Moongazing.SkillMap.Application.Dtos;
using Moongazing.SkillMap.Application.Interfaces;
using Moongazing.SkillMap.Persistence.Context;

namespace Moongazing.SkillMap.Persistence.Services;

public class SkillService : ISkillService
{
    private readonly SkillMapDbContext _context;

    public SkillService(SkillMapDbContext context)
    {
        _context = context;
    }

    public async Task<Skill> AddSkillAsync(AddSkillDto dto)
    {
        var user = await _context.Users.FindAsync(dto.UserId);
        if (user is null)
            throw new Exception("User not found");

        var skill = new Skill
        {
            Id = Guid.NewGuid(),
            Name = dto.Name,
            Level = dto.Level,
            UserId = dto.UserId
        };

        _context.Skills.Add(skill);
        await _context.SaveChangesAsync();
        return skill;
    }
}
