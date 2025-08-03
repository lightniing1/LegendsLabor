using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LegendsLabor.Core.Domain.Entities
{
    public class CombatLog : AuditableEntity
    {
        [BsonId] // MongoDB's primary key
        [BsonRepresentation(BsonType.ObjectId)] // Typically ObjectId for Mongo
        // The unique identifier for the combat log.
        public string Id { get; set; } = ObjectId.GenerateNewId().ToString(); // Use string for ObjectId

        [BsonElement("matchType")]
        [BsonRequired]
        // The type of match (e.g., "PvP", "PvE").
        public string MatchType { get; set; } = "PvP"; // "PvP", "PvE"

        [BsonElement("combatType")]
        [BsonRequired]
        // The type of combat (e.g., "Auto", "Manual").
        public string CombatType { get; set; } = "Auto"; // "Auto", "Manual"

        [BsonElement("player1Id")]
        // The ID of the first player (initiating/challenging).
        public string Player1Id { get; set; } = string.Empty;

        [BsonElement("player2Id")]
        // The ID of the second player (for PvP) or a placeholder for PvE.
        public string Player2Id { get; set; } = string.Empty; // For PvP, ID of the challenged player

        [BsonElement("monsterOrQuestId")]
        // The ID of the monster or quest encounter definition for PvE. Nullable for PvP.
        public int? MonsterOrQuestId { get; set; } // Nullable for PvP

        [BsonElement("combatState")]
        [BsonRequired]
        // The state of the combat log (e.g., "Completed", "Cancelled").
        public string CombatState { get; set; } = "Completed"; // State pattern (e.g., Completed, Cancelled - Active states likely in memory/Redis)

        [BsonElement("startedAt")]
        // The date and time when the combat started. Nullable.
        public DateTime? StartedAt { get; set; }

        [BsonElement("completedAt")]
        // The date and time when the combat was completed. Nullable.
        public DateTime? CompletedAt { get; set; }

        [BsonElement("winnerPlayerId")]
        // Player ID of the winner (Nullable if draw or PvE success not applicable)
        public int? WinnerPlayerId { get; set; }

        [BsonElement("isSuccess")]
        // For PvE: indicates if the player succeeded
        public bool? IsSuccess { get; set; } // Nullable for PvP

        [BsonElement("player1Score")]
        // Score or relevant metric for Player 1
        public int Player1Score { get; set; }

        [BsonElement("player2Score")]
        // Score or relevant metric for Player 2 (or Monster/Quest metric for PvE)
        public int Player2Score { get; set; }

        [BsonElement("experienceGained")]
        // Character Experience gained by player1
        public int ExperienceGained { get; set; }

        [BsonElement("goldGained")]
        [BsonRepresentation(BsonType.Decimal128)]
        // Gold gained by player1
        public decimal GoldGained { get; set; }

        [BsonElement("skillPointsGained")]
        // Skill Points gained by player1
        public int SkillPointsGained { get; set; }

        [BsonElement("ratingChangePlayer1")]
        // Rating change for player1 (e.g., PvP rating)
        public int RatingChangePlayer1 { get; set; }

        [BsonElement("ratingChangePlayer2")]
        // Rating change for player2 (e.g., PvP rating). Nullable/0 for PvE
        public int RatingChangePlayer2 { get; set; } // Nullable/0 for PvE

        [BsonElement("itemRewards")]
        // Embedded array of items gained from this combat instance
        public List<CombatRewardItem>? ItemRewards { get; set; } // Nullable if no items

        [BsonElement("turnLogs")]
        [BsonIgnoreIfNull]
        // Optional: Embedded array for manual battle history
        public List<CombatTurnLogEntry>? TurnLogs { get; set; } // Nullable, only present for manual combat if stored
    }
}
