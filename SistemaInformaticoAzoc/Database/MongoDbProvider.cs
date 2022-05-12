using MongoDB.Driver;

namespace SistemaInformaticoAzoc.Database
{
    public class MongoDbProvider
    {
        public static IMongoDatabase GetDatabase()
        {
            var client = new MongoClient(Properties.Settings.Default.ConnectionString);
            var database = client.GetDatabase("azocdb");

            return database;
        }
    }
}
