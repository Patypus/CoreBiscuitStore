using MongoDB.Bson.Serialization.Attributes;

namespace CoreBiscuitStoreData.Entities
{
    public class Biscuit
    {
        [BsonId]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}