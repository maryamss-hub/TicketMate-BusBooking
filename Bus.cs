using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TicketMate
{
    public class Bus
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }  // 🛠 Handle MongoDB _id field correctly

        public string Name { get; set; }
        public string DepartureCity { get; set; }
        public string DestinationCity { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
        public decimal Price { get; set; }
        public List<string> Features { get; set; }
        public double Rating { get; set; }
        public int TotalSeats { get; set; }
    }
}