using Microsoft.EntityFrameworkCore;
using todoapi_graphql_dotnet.Database.Domain;

namespace todoapi_graphql_dotnet.Database
{
    public class PgSqlContext : DbContext
    {
        public PgSqlContext(DbContextOptions<PgSqlContext> options) : base(options)
        {
        }
        
        public DbSet<Todo> Todos { get; set; }
    }
}