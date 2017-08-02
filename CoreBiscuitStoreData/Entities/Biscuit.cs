using MongoDB.Bson.Serialization.Attributes;

namespace CoreBiscuitStoreData.Entities
{
    public class Biscuit : IEntity
    {
        [BsonId]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}