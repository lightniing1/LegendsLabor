using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LegendsLabor.Core.Domain.Entities
{
    public class PlayerHistoryEntry : AuditableEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        //The unique identifier for the player history entry.")]
        public string Id { get; set; } = ObjectId.GenerateNewId().ToString();

        [BsonElement("playerId")]
        //Foreign key to the Player definition in SQL.")]
        public int PlayerId { get; set; } // FK to Player definition in SQL

        [BsonElement("actionType")]
        [BsonRequired]
        //The type of action performed by the player.")]
        public string ActionType { get; set; } = string.Empty;

        [BsonElement("relatedEntityType")]
        //The type of entity related to the action (e.g., 'Item', 'Work', 'CombatLog'). Nullable.")]
        public string? RelatedEntityType { get; set; } // e.g., 'Item', 'Work', 'CombatLog', 'Tournament', 'TrainingType', 'Collection', 'GameEvent', 'Skill', 'Stat'

        [BsonElement("relatedEntityId")]
        //The ID of the related entity. Nullable.")]
        public string? RelatedEntityId { get; set; } // Store ID as string to handle ObjectId (Mongo) or int (SQL) FKs. Nullable.
        [BsonElement("description")]
        [BsonRequired]
        //A description of the player action.")]
        public string Description { get; set; } = string.Empty;

        [BsonElement("previousValue")]
        //The previous value for tracking changes (e.g., previous energy value). Nullable.")]
        public string? PreviousValue { get; set; }

        [BsonElement("newValue")]
        //The new value for tracking changes (e.g., new energy value). Nullable.")]
        public string? NewValue { get; set; }

        [BsonElement("goldChange")]
        [BsonRepresentation(BsonType.Decimal128)]
        //The change in gold. Nullable.")]
        public decimal? GoldChange { get; set; }

        [BsonElement("experienceChange")]
        //The change in character experience. Nullable.")]
        public int? ExperienceChange { get; set; }

        [BsonElement("skillPointsChange")]
        //The change in skill points. Nullable.")]
        public int? SkillPointsChange { get; set; }

        [BsonElement("energyChange")]
        //The change in energy. Nullable.")]
        public int? EnergyChange { get; set; }

        [BsonElement("ipAddress")]
        //The IP address from which the action was performed. Nullable.")]
        public string? IPAddress { get; set; }

        [BsonElement("deviceInfo")]
        //Information about the device used for the action. Nullable.")]
        public string? DeviceInfo { get; set; }
    }
}
