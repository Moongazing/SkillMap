using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moongazing.SkillMap.Application.Interfaces;
using Moongazing.SkillMap.Persistence.Context;
using Moongazing.SkillMap.Persistence.Services;

namespace Moongazing.SkillMap.Persistence;

public static class ServiceRegistration
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<SkillMapDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<IUserService, UserService>();
        services.AddScoped<ISkillService, SkillService>();

        return services;
    }
}
