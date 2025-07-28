using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LegendsLabor.Core.Domain.Entities
{
    public class TournamentReward : AuditableEntity
    {
        [Key]
        [Comment("Primary key for the TournamentReward entity.")]
        public int Id { get; set; }

        [ForeignKey("Id")]
        [Comment("Foreign key to the Tournament entity.")]
        public int TournamentId { get; set; }

        [Comment("Navigation property to the Tournament entity.")]
        public Tournament Tournament { get; set; } = null!; // Navigation property

        [Comment("The rank that receives this reward.")]
        public int Position { get; set; } // The rank that receives this reward

        [Column(TypeName = "decimal(18,2)")]
        [Comment("The gold reward for this position. Nullable.")]
        public decimal? Gold { get; set; } // Gold Reward. Nullable.

        [Comment("The character experience reward for this position. Nullable.")]
        public int? Experience { get; set; } // Character Experience Reward. Nullable.

        // Navigation property
        [Comment("Collection of item rewards for this tournament position.")]
        // Collection of item rewards for this tournament position.
        public ICollection<TournamentRewardItem> Items { get; set; } = new List<TournamentRewardItem>();
    }
}
