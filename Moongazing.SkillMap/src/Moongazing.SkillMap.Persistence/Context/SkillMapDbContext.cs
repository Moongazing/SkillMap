using Microsoft.EntityFrameworkCore;

namespace Moongazing.SkillMap.Persistence.Context;

public class SkillMapDbContext : DbContext
{
    public SkillMapDbContext(DbContextOptions<SkillMapDbContext> options) : base(options) { }

    public DbSet<User> Users => Set<User>();
    public DbSet<Skill> Skills => Set<Skill>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(SkillMapDbContext).Assembly);
    }
}
