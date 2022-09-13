using server.Models;
using server.Repos;

namespace server.Services;

public class UserService
{
    private IUserRepo _repo;

    public UserService(IUserRepo userRepo)
    {
        _repo = userRepo;
    }

    public void createUser()
    {
        var user = new User { FirstName = "Joseph", LastName = "Bizzy" };
        Console.WriteLine("ASync");
        _repo.InsertOne(user);
    }
}