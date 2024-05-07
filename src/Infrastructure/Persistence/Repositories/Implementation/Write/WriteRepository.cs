using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using Persistence.Repositories.Abstraction.Write;

namespace Persistence.Repositories.Implementation.Write;

public class WriteRepository<T> : IWriteRepository<T> where T : class
{
    
    protected CrudApiDbContext CrudApiDbContext { get; set; }
    
    protected WriteRepository(CrudApiDbContext crudApiDbContext)
    {
        this.CrudApiDbContext = crudApiDbContext;
    }
    
    public virtual async Task<List<T>> GetByCondition(Expression<Func<T, bool>> expression)
    {
        return await CrudApiDbContext.Set<T>().Where(expression).ToListAsync();
    }

    public virtual async void Create(T entity, CancellationToken cancellationToken)
    {
        CrudApiDbContext.Set<T>().Add(entity);
        await CrudApiDbContext.SaveChangesAsync(cancellationToken);
    }

    public virtual async void Update(T entity, CancellationToken cancellationToken)
    {
        CrudApiDbContext.Set<T>().Update(entity);
        await CrudApiDbContext.SaveChangesAsync(cancellationToken);
    }

    public virtual async void Delete(T entity, CancellationToken cancellationToken)
    {
        CrudApiDbContext.Set<T>().Remove(entity);
        await CrudApiDbContext.SaveChangesAsync(cancellationToken);
    }

    public virtual async void LogicalDelete(T entity, CancellationToken cancellationToken)
    {
        CrudApiDbContext.Set<T>().Update(entity);
        await CrudApiDbContext.SaveChangesAsync(cancellationToken);
    }
}