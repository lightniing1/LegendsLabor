using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LegendsLabor.Core.Domain.Entities
{
    // Represents a historical transaction record (Gold movement)
    public class Transaction : AuditableEntity, IEntity<string>
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        //The unique identifier for the transaction.")]
        public string Id { get; set; } = ObjectId.GenerateNewId().ToString();

        [BsonElement("playerId")]
        //Foreign key to the Player definition in SQL.")]
        public string PlayerId { get; set; } = string.Empty;

        [BsonElement("amount")]
        [BsonRepresentation(BsonType.Decimal128)]
        //The gold amount of the transaction. Positive for income, negative for expense.")]
        public decimal Amount { get; set; }

        [BsonElement("type")]
        [BsonRequired]
        //The type of transaction (e.g., Income, Expense).")]
        public string Type { get; set; } = string.Empty;

        [BsonElement("category")]
        [BsonRequired]
        //The category of the transaction (e.g., Work, Combat, Base, Item, Bank, Training, Collection, Event, Tournament, Gift).")]
        public string Category { get; set; } = string.Empty;

        [BsonElement("description")]
        [BsonRequired]
        //A description of the transaction.")]
        public string Description { get; set; } = string.Empty;
    }
}
