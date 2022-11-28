using MediatR;
using System.ComponentModel.DataAnnotations;

namespace AuthMicroservice.Requests;

public class AuthRequest : IRequest<string>
{
    [Required]
    [MinLength(4)]
    public string Username { get; set; }

    [Required]
    [MinLength(4)]
    public string Password { get; set; }

    public AuthRequest()
    {
        Username = string.Empty;
        Password = string.Empty;
    }
}
