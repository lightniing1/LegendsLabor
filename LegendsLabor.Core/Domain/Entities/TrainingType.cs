using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LegendsLabor.Core.Domain.Entities
{
    public class TrainingType : AuditableEntity
    {
        [Key]
        [Comment("Primary key for the TrainingType entity.")]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Comment("The name of the training activity.")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(255)]
        [Comment("A description of the training activity.")]
        public string Description { get; set; } = string.Empty;

        [Comment("The energy cost to perform this training activity.")]
        public int EnergyCost { get; set; }

        [Comment("The duration of the training activity in minutes.")]
        public int DurationMinutes { get; set; }

        [Comment("The character experience reward for completing this training activity.")]
        public int ExperienceReward { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Comment("Optional gold cost for training. Nullable.")]
        public decimal? GoldCost { get; set; }

        [MaxLength(50)]
        [Comment("The type of stat targeted by the training (e.g., 'Might', 'Skill', 'Focus'). Nullable if training targets skills or gives general XP/rewards.")]
        public string? TargetStatType { get; set; }

        [Comment("The base value of the stat increase from training. Nullable.")]
        public int? StatIncreaseValue { get; set; }

        [ForeignKey("Id")]
        [Comment("Foreign key to the targeted Skill. Nullable if not targeting a specific skill.")]
        public int? TargetSkillId { get; set; }

        [Comment("Navigation property to the targeted Skill. Nullable.")]
        public Skill? TargetSkill { get; set; } // Navigation property

        [Comment("Experience gained towards a specific skill. Nullable.")]
        public int? SkillExperienceReward { get; set; }

        [Comment("Skill Points gained from training. Nullable.")]
        public int? SkillPointsReward { get; set; }

        [Comment("The minimum player level required to undertake this training activity.")]
        public int MinimumPlayerLevel { get; set; }
        
        [Comment("cooldown period in minutes before this training activity can be attempted again.")]
        public int CooldownMinutes { get; set; }

        [Comment("The tier of the training activity")]
        public int Tier { get; set; } = 1;

        [Column(TypeName = "decimal(5,2)")]
        public decimal FailureChance { get; set; } = 0.0m;
        [MaxLength(255)]
        public string? FailurePenalty { get; set; }

        // PlayerTrainingSession instances are in MongoDB
    }
}
