using System.ComponentModel.DataAnnotations;

namespace server.Users;

public class CreateUserDto
{
    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string Phone { get; set; }

    [Required]
    public string Password { get; set; }

}