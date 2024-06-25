using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BrainHack.Core.Entities
{
    public class Deck
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OwnerId { get; set; } //Owner user id

        public Dictionary<string, Card> Cards { get; set; }

        public Deck(string id, string name, string description, string ownweId, Dictionary<string, Card> cards)
        {
            Id = id;
            Name = name;
            Description = description;
            Cards = cards;
            OwnerId = ownweId;
        }        
        
        public Deck(string name, string description, string ownweId, Dictionary<string, Card> cards)
        {
            Id = "";
            Name = name;
            Description = description;
            Cards = cards;
            OwnerId = ownweId;
        }
    }
}
