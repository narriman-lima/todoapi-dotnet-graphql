using todoapi_graphql_dotnet.Database.Domain;

namespace todoapi_graphql_dotnet.Database.Repositories
{
    public interface ITodoRepository
    {
        IQueryable<Todo> GetAll();
        Todo GetById(Guid id);
        Todo Save(Todo entity);
    }
}