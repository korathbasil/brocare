using Microsoft.AspNetCore.Mvc;
using server.Services;
using server.Models;
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

    [HttpGet]
    public async Task<List<User>> GetUsers()
    {
        var users = await _service.getAllUsers();
        return users;
    }


    [HttpPost]
    public async Task<IActionResult> createUser(CreateUserDto data)
    {
        var userId = await _service.createUser(data.FirstName, data.LastName, data.Email, data.Phone, data.Password);
        return Created($"/users/{userId}", new { userId });
    }
}