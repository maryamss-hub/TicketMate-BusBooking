using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TicketMate
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }   // 🛠 Handle MongoDB _id field

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
