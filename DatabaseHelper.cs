using MongoDB.Driver;

namespace TicketMate
{
    public static class DatabaseHelper
    {
        private static IMongoDatabase database;

        public static void Initialize()
        {
            string connectionString = "mongodb://localhost:27017"; // ✅ Correct
            var client = new MongoClient(connectionString);
            database = client.GetDatabase("TicketMateDb"); // ✅ Make sure TicketMateDb
        }

        public static IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            if (database == null)
                Initialize();
            return database.GetCollection<T>(collectionName);
        }
    }
}
