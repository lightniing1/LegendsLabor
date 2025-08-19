using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace LegendsLabor.Core.Domain.Entities
{
    public class Work : AuditableEntity, IEntity<int>
    {
        [Key]
        [Comment("Primary key for the Work entity.")]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Comment("The name of the work activity.")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(255)]
        [Comment("A description of the work activity.")]
        public string Description { get; set; } = string.Empty;

        [Comment("The energy cost to perform this work activity.")]
        public int EnergyCost { get; set; }

        [Comment("The duration of the work activity in minutes.")]
        public int DurationMinutes { get; set; }

        [Comment("The character experience reward for completing this work activity.")]
        public int ExperienceReward { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Comment("The fixed gold reward for completing this work activity.")]
        public decimal GoldReward { get; set; }

        [Comment("The minimum player level required to undertake this work activity.")]
        public int MinimumPlayerLevel { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        [Comment("The total chance for ANY item to drop from WorkRewards for this activity.")]
        public decimal ItemDropChance { get; set; }

        [Comment("The cooldown period in minutes before this work activity can be attempted again.")]
        public int CooldownMinutes { get; set; }

        [Comment("The tier of the work activity.")]
        public int Tier { get; set; } = 1;

        [Column(TypeName = "decimal(5,2)")]
        [Comment("The chance of failure for the activity.")]
        public decimal FailureChance { get; set; } = 0.0m;

        [MaxLength(255)]
        [Comment("A description of the failure condition. Nullable.")]
        public string? FailureDescription { get; set; }

        // Navigation property
        // Collection of rewards associated with this work activity.
        public ICollection<WorkReward> Rewards { get; set; } = new List<WorkReward>();
        // PlayerWorkSession instances are in MongoDB
    }
}
