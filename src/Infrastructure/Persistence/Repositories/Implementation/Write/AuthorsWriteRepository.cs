using Domain.Entities;
using Persistence.Contexts;
using Persistence.Repositories.Abstraction.Write;

namespace Persistence.Repositories.Implementation.Write;

public class AuthorsWriteRepository : WriteRepository<Authors>, IAuthorsWriteRepository
{
    protected AuthorsWriteRepository(CrudApiDbContext crudApiDbContext) : base(crudApiDbContext)
    {
    }
}