using AuthMicroservice.Requests;
using MediatR;

namespace AuthMicroservice.Handlers;

public class AuthRequestHandler : IRequestHandler<AuthRequest, string>
{
    private readonly ILogger<AuthRequestHandler> _logger;

    public AuthRequestHandler(ILogger<AuthRequestHandler> logger)
    {
        _logger = logger;
    }

    public Task<string> Handle(AuthRequest request, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Auth request handler.");

        return Task.FromResult("Success: QWERTY");
    }
}
