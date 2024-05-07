using Domain.Entities;
using Persistence.Contexts;
using Persistence.Repositories.Abstraction.Read;

namespace Persistence.Repositories.Implementation.Read;

public class BooksReadRepository : ReadRepository<Books>, IBooksReadRepository
{
    protected BooksReadRepository(CrudApiDbContext crudApiDbContext) : base(crudApiDbContext)
    {
    }
}