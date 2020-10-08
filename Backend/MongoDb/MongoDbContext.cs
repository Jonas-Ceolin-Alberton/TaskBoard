using MongoDB.Driver;

namespace Backend.MongoDb
{
    public class MongoDbContext
    {
        public MongoClient Client { get; }
        public IMongoDatabase Database { get; }

        public MongoDbContext()
        {
            var mongoUrl = new MongoUrl("mongodb://root:rootpassword@localhost:27017/?authSource=admin&readPreference=primary&appname=MongoDB%20Compass&ssl=false");

            Client = new MongoClient(mongoUrl);

            Database = Client.GetDatabase("taskboard");
        }
    }
}
