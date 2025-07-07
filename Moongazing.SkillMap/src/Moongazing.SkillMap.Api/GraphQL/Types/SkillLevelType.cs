using HotChocolate.Types;

namespace Moongazing.SkillMap.Api.GraphQL.Types;

public class SkillLevelType : EnumType<SkillLevel>
{
    protected override void Configure(IEnumTypeDescriptor<SkillLevel> descriptor)
    {
        descriptor.Name("SkillLevel");
        descriptor.BindValuesExplicitly()
            .Value(SkillLevel.Beginner)
            .Value(SkillLevel.Intermediate)
            .Value(SkillLevel.Advanced)
            .Value(SkillLevel.Expert);
    }
}
