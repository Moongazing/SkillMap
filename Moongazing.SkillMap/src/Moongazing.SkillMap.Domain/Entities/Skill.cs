public class Skill
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = null!;
    public SkillLevel Level { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; } = null!;
}
