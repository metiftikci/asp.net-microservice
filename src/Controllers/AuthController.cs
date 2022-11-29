using AuthMicroservice.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AuthMicroservice.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly ILogger<AuthController> _logger;

    public AuthController(IMediator mediator, ILogger<AuthController> logger)
    {
        _mediator = mediator;
        _logger = logger;
    }

    [HttpPost]
    public async Task<ActionResult<string>> CreateTokenAsync([FromBody] AuthRequest request)
    {
        _logger.LogInformation("Auth request starting.");

        try
        {
            return await _mediator.Send(request);
        }
        catch (InvalidOperationException ex)
        {
            _logger.LogError(ex.Message);

            return StatusCode(403);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);

            return StatusCode(500);
        }
    }
}
