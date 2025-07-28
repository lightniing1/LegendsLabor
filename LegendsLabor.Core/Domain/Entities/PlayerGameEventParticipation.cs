using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LegendsLabor.Core.Domain.Entities
{
    public class PlayerGameEventParticipation : AuditableEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        //The unique identifier for the player's game event participation.
        public string Id { get; set; } = ObjectId.GenerateNewId().ToString();

        [BsonElement("gameEventId")]
        //Foreign key to the GameEvent definition in SQL.
        public int GameEventId { get; set; } // FK to GameEvent definition in SQL

        [BsonElement("playerId")]
        //Foreign key to the Player definition in SQL.
        public int PlayerId { get; set; } // FK to Player definition in SQL

        [BsonElement("joinedAt")]
        //The date and time when the player joined the event.
        public DateTime JoinedAt { get; set; } = DateTime.UtcNow;

        [BsonElement("progress")]
        //The player's progress in the event (percentage or points towards completion)
        public int Progress { get; set; } // Percentage or points towards completion

        [BsonElement("completedAt")]
        //The date and time when the player completed the event. Nullable.
        public DateTime? CompletedAt { get; set; }

        // Rewards claimed from this event are tracked in PlayerGameEventRewardClaim
    }
}
