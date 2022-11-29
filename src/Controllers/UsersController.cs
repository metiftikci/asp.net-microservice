using AuthMicroservice.Models;
using AuthMicroservice.Services;
using Microsoft.AspNetCore.Mvc;

namespace AuthMicroservice.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private readonly UsersService _usersService;

    public UsersController(UsersService usersService)
    {
        _usersService = usersService;
    }

    [HttpGet]
    public async Task<List<User>> GetAsync()
        => await _usersService.GetAsync();

    // TODO: Change as Post method
    [HttpGet("Save")]
    public async Task<ActionResult> RegisterAsync()
    {
        var user = new User()
        {
            Name = "nameX",
            Surname = "surnameX",
            Age = 20,
            DateOfBirth = DateTime.Now,
            Username = "usernameX",
            Password = "passwordX"
        };

        await _usersService.CreateAsync(user);

        return Ok();
    }
}
