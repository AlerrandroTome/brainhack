namespace BrainHack.Infrastructure.Persistence.Configuration
{
    public class MongoDBSettings : IMongoDBConfig
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string CollectionName { get; set; } = null!;
    }

    public interface IMongoDBConfig { }
}