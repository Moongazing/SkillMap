namespace Moongazing.SkillMap.Application.Dtos;

public record AddSkillDto(Guid UserId, string Name, SkillLevel Level);