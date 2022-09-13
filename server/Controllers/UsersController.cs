using Microsoft.AspNetCore.Mvc;

namespace server.Controllers;

[ApiController]
[Route("users")]
public class UsersController : ControllerBase
{
    [HttpGet]
    string GetAllUsers() => "HEllo";
}