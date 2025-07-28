using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LegendsLabor.Core.Domain.Entities
{
    // Represents a player's participation and stats within a specific Tournament
    public class TournamentParticipantRecord : AuditableEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        //The unique identifier for the tournament participant record.")]
        public string Id { get; set; } = ObjectId.GenerateNewId().ToString();

        [BsonElement("tournamentId")]
        //Foreign key to the Tournament definition in SQL.")]
        public int TournamentId { get; set; } // FK to Tournament definition in SQL

        [BsonElement("playerId")]
        //Foreign key to the Player definition in SQL.")]
        public int PlayerId { get; set; } // FK to Player definition in SQL

        [BsonElement("points")]
        //The points accumulated by the player in the tournament.")]
        public int Points { get; set; }

        [BsonElement("wins")]
        //The number of wins by the player in the tournament.")]
        public int Wins { get; set; }

        [BsonElement("draws")]
        //The number of draws by the player in the tournament.")]
        public int Draws { get; set; }

        [BsonElement("losses")]
        //The number of losses by the player in the tournament.")]
        public int Losses { get; set; }

        [BsonElement("DamageDealt")]
        //The total damage dealt by the player in the tournament.")]
        public int DamageDealt { get; set; }

        [BsonElement("DamageReceived")]
        //The total damage received by the player in the tournament.")]
        public int DamageReceived { get; set; }

        [BsonElement("currentPosition")]
        //The player's current position/rank in the tournament.")]
        public int CurrentPosition { get; set; }

        [BsonElement("rewardClaimed")]
        // Indicates if the player has claimed their tournament reward.
        public bool RewardClaimed { get; set; }

        [BsonElement("joinedAt")]
        // The date and time when the player joined the tournament.
        public DateTime JoinedAt { get; set; } = DateTime.UtcNow;
    }
}
