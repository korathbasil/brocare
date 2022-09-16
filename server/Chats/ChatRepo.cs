namespace server.Chats;

public class ChatRepo : IChatRepo
{
    public Task<List<Chat>> find()
    {
        throw new NotImplementedException();
    }

    public Task<string> InsertOne(Chat chat)
    {
        throw new NotImplementedException();
    }
}