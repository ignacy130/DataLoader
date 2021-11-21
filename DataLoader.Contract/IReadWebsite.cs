namespace DataLoader
{
    public interface IReadWebsite
    {
        string GetTitle(string source);
    }

    public interface ISaveWebsiteData
    {
        void Save();
    }

    public interface IMessageBroker
    {
        void Send();
        void Read();
    }
}
