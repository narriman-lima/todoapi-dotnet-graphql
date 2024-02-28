using todoapi_graphql_dotnet.Database.Domain;

namespace todoapi_graphql_dotnet.Database.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private readonly PgSqlContext _db;

        public TodoRepository(PgSqlContext db)
        {
            _db = db;
        }
        
        public IQueryable<Todo> GetAll()
        {
            return _db.Todos.AsQueryable();
        }

        public Todo GetById(Guid id)
        {
            return _db.Todos.SingleOrDefault(t => t.Id == id);
        }

        public Todo Save(Todo entity)
        {
            if (!entity.Id.HasValue)
            {
                entity.Id = Guid.NewGuid();
                _db.Todos.Add(entity);
            }

            _db.SaveChanges();

            return entity;
        }
    }
}