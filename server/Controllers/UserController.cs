using Microsoft.AspNetCore.Mvc;
using server.Services;
using server.Dtos;

namespace server.Controllers;

[ApiController]
[Route("users")]
public class UserController : ControllerBase
{
    private readonly UserService _service;
    private readonly ILogger<UserController> _logger;

    public UserController(UserService userService, ILogger<UserController> logger)
    {
        _service = userService;
        _logger = logger;
    }

    [HttpGet("hello")]
    public string GetHelloWorld()
    {
        return "Hello World";
    }


    [HttpPost]
    public async Task<IActionResult> createUser(CreateUserDto data)
    {
        var userId = await _service.createUser(data.firstName, data.lastName, data.email, data.phone, data.password);
        return Created($"/users/{userId}", new { userId });
    }
}