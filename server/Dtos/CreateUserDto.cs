using System.ComponentModel.DataAnnotations;

namespace server.Dtos;

public class CreateUserDto
{
    [Required]
    public string firstName { get; set; }

    [Required]
    public string lastName { get; set; }

    [Required]
    public string email { get; set; }

    [Required]
    public string phone { get; set; }

    [Required]
    public string password { get; set; }

}