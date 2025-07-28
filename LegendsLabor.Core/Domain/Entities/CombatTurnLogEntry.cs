using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LegendsLabor.Core.Domain.Entities
{
    public class CombatTurnLogEntry : AuditableEntity
    {
        [BsonElement("turnId")]
        public int TurnId { get; set; }

        [BsonElement("playerId")]
        public int PlayerId { get; set; }

        [BsonElement("actionType")]
        public string ActionType { get; set; } = string.Empty;

        [BsonElement("skillId")]
        public int? SkillId { get; set; }

        [BsonElement("itemId")]
        public int? ItemId { get; set; }

        [BsonElement("targetPlayerId")]
        public int? TargetPlayerId { get; set; }

        [BsonElement("targetMonsterId")]
        public int? TargetMonsterId { get; set; }

        [BsonElement("details")]
        [BsonIgnoreIfNull]
        public BsonDocument? Details { get; set; }
    }
}
