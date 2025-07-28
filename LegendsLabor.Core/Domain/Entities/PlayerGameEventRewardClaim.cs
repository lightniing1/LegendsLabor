using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LegendsLabor.Core.Domain.Entities
{
    // Represents a specific reward claimed by a player from a Game Event they participated in
    public class PlayerGameEventRewardClaim : AuditableEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        //The unique identifier for the player's game event reward claim.
        public string Id { get; set; } = ObjectId.GenerateNewId().ToString();

        [BsonElement("playerGameEventParticipationId")]
        //Foreign key to the PlayerGameEventParticipation instance in MongoDB.
        public string PlayerGameEventParticipationId { get; set; } // FK to PlayerGameEventParticipation in Mongo

        [BsonElement("gameEventRewardId")]
        //Foreign key to the specific GameEventReward definition in SQL.
        public int GameEventRewardId { get; set; } // FK to GameEventReward definition in SQL

        [BsonElement("claimedAt")]
        //The date and time when the reward was claimed.
        public DateTime ClaimedAt { get; set; } = DateTime.UtcNow;
    }
}
