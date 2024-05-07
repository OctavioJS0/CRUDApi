using Domain.Entities;
using Persistence.Contexts;
using Persistence.Repositories.Abstraction.Read;

namespace Persistence.Repositories.Implementation.Read;

public class AuthorsReadRepository : ReadRepository<Authors>, IAuthorsReadRepository
{
    protected AuthorsReadRepository(CrudApiDbContext crudApiDbContext) : base(crudApiDbContext)
    {
    }
}