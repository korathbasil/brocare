using server.DataAccess;
using server.Models;

namespace server.Repos;

public class UserRepo : IUserRepo
{
    private Db _db;

    public UserRepo(Db db)
    {
        _db = db;
    }

    public async void InsertOne(User user)
    {
        await _db.Users.InsertOneAsync(user);
        return;
    }
}