using server.Models;

namespace server.Repos;

public interface IUserRepo
{
    Task<string> InsertOne(User user);
}