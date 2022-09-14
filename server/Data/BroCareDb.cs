using MongoDB.Driver;
using server.Users;

namespace server.Data;

public class Db
{
    private const string CONNECTION_URL = "mongodb://localhost:27017";
    private const string DB_NAME = "brocare_dev";

    private const string UsersCollectionName = "users";

    public IMongoCollection<User> Users { get; }

    public Db()
    {
        var client = new MongoClient(CONNECTION_URL);
        var db = client.GetDatabase(DB_NAME);

        Users = db.GetCollection<User>(UsersCollectionName);
    }
}