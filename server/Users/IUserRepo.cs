using MongoDB.Driver;

namespace server.Users;

public interface IUserRepo
{
    Task<string> InsertOne(User user);

    Task<List<User>> find();
}