namespace server.Chats;

public interface IChatRepo
{
    Task<string> InsertOne(Chat chat);

    Task<List<Chat>> find();
}