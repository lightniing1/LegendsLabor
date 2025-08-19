using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace LegendsLabor.Core.Domain.Entities
{
    public class WorkReward : AuditableEntity, IEntity<int>
    {
        [Key]
        [Comment("Primary key for the WorkReward entity.")]
        public int Id { get; set; }

        [ForeignKey("Id")]
        [Comment("Foreign key to the Work entity.")]
        public int WorkId { get; set; }

        [Comment("Navigation property to the Work entity.")]
        public Work Work { get; set; } = null!; // Navigation property

        [Required]
        [MaxLength(50)]
        [Comment("The type of reward (e.g., Item, Experience, StatBoost).")]
        public string RewardType { get; set; } = string.Empty;

        [ForeignKey("Id")]
        [Comment("Foreign key to the Item definition. Nullable.")]
        public int? ItemId { get; set; }

        [Comment("Navigation property to the Item definition. Nullable.")]
        public Item? Item { get; set; } // Navigation property

        [Comment("The quantity of the reward (for Item or Experience).")]
        public int Quantity { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Comment("The value for StatBoost rewards. Nullable.")]
        public decimal? Value { get; set; }

        [MaxLength(50)]
        [Comment("The stat affected for StatBoost rewards (e.g., 'Might', 'Skill', 'Focus'). Nullable if not StatBoost.")]
        public string? AffectedStat { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        [Comment("The percentage chance for this specific reward item/type to drop.")]
        public decimal DropChance { get; set; }
    }
}
