using Domain.Entities;
using Persistence.Contexts;
using Persistence.Repositories.Abstraction.Write;

namespace Persistence.Repositories.Implementation.Write;

public class BooksWriteRepository : WriteRepository<Books>, IBooksWriteRepository
{
    protected BooksWriteRepository(CrudApiDbContext crudApiDbContext) : base(crudApiDbContext)
    {
    }
}