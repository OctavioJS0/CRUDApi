using System.Linq.Expressions;

namespace Persistence.Repositories.Abstraction.Read;

public interface IReadRepository<T>
{
    public Task<List<T>> GetAll();
    public Task<List<T>> GetById(Expression<Func<T, bool>> expression);
}