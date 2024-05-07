using System.Linq.Expressions;

namespace Persistence.Repositories.Abstraction.Write;

public interface IWriteRepository<T>
{
    public Task<List<T>> GetByCondition(Expression<Func<T, bool>> expression);
    public void Create(T entity, CancellationToken cancellationToken);
    public void Update(T entity, CancellationToken cancellationToken);
    public void Delete(T entity, CancellationToken cancellationToken);
    public void LogicalDelete(T entity, CancellationToken cancellationToken);
}