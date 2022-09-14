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

    public Task<string> createUser(string firstName, string lastName, string email, string phone, string password)
    {
        var user = new User { FirstName = firstName, LastName = lastName, Email = email, Phone = phone, Password = password };
        return _repo.InsertOne(user);
    }
}