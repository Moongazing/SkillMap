using Moongazing.SkillMap.Api.GraphQL.Mutations;
using Moongazing.SkillMap.Api.GraphQL.Queries;
using Moongazing.SkillMap.Api.GraphQL.Types;
using Moongazing.SkillMap.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructure(builder.Configuration);

builder.Services
    .AddGraphQLServer()
    .AddQueryType<UserQuery>()
    .AddMutationType<UserMutation>()
    .AddType<SkillLevelType>()
    .AddProjections()
    .AddFiltering()
    .AddSorting();

builder.Services.AddCors();

var app = builder.Build();

app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.MapGraphQL();
app.UseRouting();
app.Run();
