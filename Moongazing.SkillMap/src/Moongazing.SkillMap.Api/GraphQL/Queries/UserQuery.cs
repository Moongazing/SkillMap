using HotChocolate;
using Moongazing.SkillMap.Application.Interfaces;

namespace Moongazing.SkillMap.Api.GraphQL.Queries;

public class UserQuery
{
    public async Task<List<User>> GetUsers([Service] IUserService userService)
        => await userService.GetAllAsync();

    public async Task<User?> GetUserById(Guid id, [Service] IUserService userService)
        => await userService.GetUserByIdAsync(id);
}
