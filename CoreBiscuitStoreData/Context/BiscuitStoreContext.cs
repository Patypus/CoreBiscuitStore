using MongoDB.Driver;
using CoreBiscuitStoreData.Entities;
using CoreBiscuitStoreCommon.Settings;
using MongoDB.Bson;

namespace CoreBiscuitStoreData.Context
{
    public class BiscuitStoreContext : IBiscuitStoreContext
    {
        private IMongoDatabase _database;

        public BiscuitStoreContext(ApplicationConfiguration configuration)
        {
            var client = new MongoClient(configuration.ConnectionString);

            if (client != null)
            {
                _database = client.GetDatabase(configuration.Database);
            }
        }

        public IMongoCollection<Biscuit> Biscuits
        {
            get
            {
                return _database.GetCollection<Biscuit>("Biscuit");
            }
        }
    }
}