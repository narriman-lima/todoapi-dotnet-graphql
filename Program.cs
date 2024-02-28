using Microsoft.EntityFrameworkCore;
using todoapi_graphql_dotnet.Database;
using todoapi_graphql_dotnet.Database.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddGraphQLServer();
builder.Services.AddDbContext<PgSqlContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("ServerConnection")));

builder.Services.AddScoped<ITodoRepository, TodoRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGraphQL();

app.Run();