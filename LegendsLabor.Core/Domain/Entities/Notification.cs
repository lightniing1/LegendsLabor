using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Microsoft.EntityFrameworkCore;


namespace LegendsLabor.Core.Domain.Entities
{
    public class Notification : AuditableEntity, IEntity<string>
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [Comment("The unique identifier for the notification.")]
        public string Id { get; set; } = ObjectId.GenerateNewId().ToString();

        [BsonElement("playerId")]
        [Comment("Foreign key to the Player definition in SQL.")]
        public string PlayerId { get; set; } = string.Empty; // FK to Player definition in SQL

        [BsonElement("type")]
        [BsonRequired]
        [Comment("The type of notification (e.g., Challenge, FriendRequest, SystemAnnouncement, TournamentResult, EventComplete, LaborComplete, TrainingComplete, EnergyFull).")]
        public string Type { get; set; } = string.Empty; // Challenge, FriendRequest, SystemAnnouncement, TournamentResult, EventComplete, LaborComplete, TrainingComplete, EnergyFull

        [BsonElement("title")]
        [BsonRequired]
        [Comment("The title of the notification.")]
        public string Title { get; set; } = string.Empty;

        [BsonElement("message")]
        [BsonRequired]
        [Comment("The message content of the notification.")]
        public string Message { get; set; } = string.Empty;

        [BsonElement("isRead")]
        [Comment("Indicates if the notification has been read by the player.")]
        public bool IsRead { get; set; }

        [BsonElement("expiresAt")]
        [Comment("The date and time when the notification expires. Nullable.")]
        public DateTime? ExpiresAt { get; set; }

        [BsonElement("actionType")]
        [Comment("The type of action associated with the notification. Nullable.")]
        public string? ActionType { get; set; }

        [BsonElement("actionTarget")]
        [Comment("The target of the action associated with the notification. Nullable.")]
        public string? ActionTarget { get; set; }
    }
}
