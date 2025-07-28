using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LegendsLabor.Core.Domain.Entities
{
    public class GameEventReward : AuditableEntity
    {
        [Key]
        [Comment("Primary key for the GameEventReward entity.")]
        public int Id { get; set; }

        [ForeignKey("Id")]
        [Comment("Foreign key to the GameEvent entity.")]
        public int GameEventId { get; set; }

        [Comment("Navigation property to the GameEvent entity.")]
        public GameEvent GameEvent { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        [Comment("The type of reward (e.g., Item, Gold, Experience, StatBoost, SkillPoints).")]
        public string RewardType { get; set; } = string.Empty; // Item, Gold, Experience, StatBoost, SkillPoints

        [ForeignKey("Id")]
        [Comment("Foreign key to the Item definition for the reward. Nullable.")]
        public int? ItemId { get; set; }

        [Comment("Navigation property to the Item reward. Nullable.")]
        public Item? Item { get; set; }

        [Comment("The quantity of the reward (for Item, Experience, SkillPoints). Nullable.")]
        public int? Quantity { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Comment("The gold value of the reward. Nullable.")]
        public decimal? GoldValue { get; set; }

        [MaxLength(50)]
        [Comment("The skill affected for SkillPoints rewards (e.g., 'Swordsmanship', 'Archery'). Nullable if RewardType is not SkillPoints.")]
        public string? AffectedStat { get; set; } // 'Might', 'Skill', 'Focus'. Nullable if RewardType is not StatBoost.

        [Comment("The value for StatBoost rewards. Nullable.")]
        public int? StatBoostValue { get; set; }

        [Comment("Indicates if the StatBoost is permanent. Nullable if not StatBoost.")]
        public bool? IsPermanent { get; set; }
    }
}
