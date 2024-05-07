using Application.CQRS.Authors.Commands;
using Microsoft.AspNetCore.Mvc;

namespace Controllers.Controllers.v1.Authors;

public class CreateAuthorController : BaseApiController
{
    private readonly CreateAuthors _createAuthors;

    public CreateAuthorController(CreateAuthors createAuthors)
    {
        _createAuthors = createAuthors;
    }

    [HttpPost]
    private Task<IActionResult> CreateAuthor(Domain.Entities.Authors entity, CancellationToken cancellationToken)
    {
        if (entity is null)
            throw new ArgumentNullException($"The param {entity} cannot be null");

        return ProcessCreateAuthor(entity, cancellationToken);
    }

    private async Task<IActionResult> ProcessCreateAuthor(Domain.Entities.Authors entity, CancellationToken cancellationToken)
    {
        var result = await _createAuthors.Handle(entity, cancellationToken);
        return Created(Request.Path, entity);
    }

}