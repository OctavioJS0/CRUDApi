using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using Persistence.Repositories.Abstraction.Read;

namespace Persistence.Repositories.Implementation.Read;

public class ReadRepository<T> : IReadRepository<T> where T : class
{
    protected CrudApiDbContext CrudApiDbContext { get; set; }
    
    protected ReadRepository(CrudApiDbContext crudApiDbContext)
    {
        this.CrudApiDbContext = crudApiDbContext;
    }
    
    public virtual async Task<List<T>> GetAll()
    {
        return await CrudApiDbContext.Set<T>()
            .AsNoTracking()
            .ToListAsync();
    }

    public virtual async Task<List<T>> GetById(Expression<Func<T, bool>> expression)
    {
        return await CrudApiDbContext.Set<T>()
            .Where(expression)
            .AsNoTracking()
            .ToListAsync();
    }
}