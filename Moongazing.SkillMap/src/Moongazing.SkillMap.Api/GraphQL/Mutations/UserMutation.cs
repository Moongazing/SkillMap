using HotChocolate;
using Moongazing.SkillMap.Application.Dtos;
using Moongazing.SkillMap.Application.Interfaces;

namespace Moongazing.SkillMap.Api.GraphQL.Mutations;

public class UserMutation
{
    public async Task<User> CreateUser(CreateUserDto input, [Service] IUserService service)
        => await service.CreateUserAsync(input);

    public async Task<Skill> AddSkill(AddSkillDto input, [Service] ISkillService service)
        => await service.AddSkillAsync(input);
}