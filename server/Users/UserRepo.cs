using MongoDB.Driver;
using server.Data;

namespace server.Users;

public class UserRepo : IUserRepo
{
    private Db _db;

    public UserRepo(Db db)
    {
        _db = db;
    }

    public async Task<string> InsertOne(User user)
    {
        await _db.Users.InsertOneAsync(user);
        return user.Id;
    }

    public Task<List<User>> find()
    {
        return _db.Users.FindAsync<User>(_ => true).Result.ToListAsync();
    }
}