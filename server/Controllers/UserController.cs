using Microsoft.AspNetCore.Mvc;
using server.Services;

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


    [HttpGet]
    public string createUser()
    {
        _service.createUser();
        Console.Write("Not");
        return "done";
    }
}