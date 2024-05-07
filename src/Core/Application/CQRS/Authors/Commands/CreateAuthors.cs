using Persistence.Repositories.Implementation.Write;

namespace Application.CQRS.Authors.Commands;

public class CreateAuthors 
{

    private readonly WriteRepository<Domain.Entities.Authors> _authorsWriteRepository;

    public CreateAuthors(WriteRepository<Domain.Entities.Authors> writeRepository)
    {
        _authorsWriteRepository = writeRepository;
    }

    public Task<Guid> Handle(Domain.Entities.Authors request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        return ProcessHandle(request, cancellationToken);
    }

    private async Task<Guid> ProcessHandle(Domain.Entities.Authors request, CancellationToken cancellationToken)
    {
        _authorsWriteRepository.Create(request, cancellationToken);
        return request.Id;
    }
}