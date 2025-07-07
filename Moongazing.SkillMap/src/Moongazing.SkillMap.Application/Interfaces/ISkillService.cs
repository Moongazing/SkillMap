using Moongazing.SkillMap.Application.Dtos;

namespace Moongazing.SkillMap.Application.Interfaces;

public interface ISkillService
{
    Task<Skill> AddSkillAsync(AddSkillDto dto);
}