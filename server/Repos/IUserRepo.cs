using server.Models;

namespace server.Repos;

public interface IUserRepo
{
    void InsertOne(User user);
}