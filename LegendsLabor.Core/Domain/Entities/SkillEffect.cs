using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LegendsLabor.Core.Domain.Entities
{
    public class SkillEffect : AuditableEntity
    {
        [Key]
        [Comment("Primary key for the SkillEffect entity.")]
        public int Id { get; set; }

        [ForeignKey("Id")]
        [Comment("Foreign key to the Skill entity.")]
        public int SkillId { get; set; }

        [Comment("Navigation property to the Skill entity.")]
        public Skill Skill { get; set; } = null!; // Navigation property

        [Required]
        [MaxLength(50)]
        [Comment("The type of effect (e.g., StatBoost, StatusEffect, Damage, Healing, ChanceModifier, TriggeredEffect, PassiveEffect).")]
        public string EffectType { get; set; } = string.Empty;

        [MaxLength(50)]
        [Comment("The stat affected by the skill effect (e.g., 'Might', 'Skill', 'Focus'). Nullable.")]
        public string? AffectedStat { get; set; }

        [Comment("The base value of the effect.")]
        public int Value { get; set; }

        [Comment("Indicates if the effect gets stronger with skill level.")]
        public bool ScalesWithLevel { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        [Comment("How much the effect increases per level (e.g., 0.1 for +10%).")]
        public decimal ScalingFactor { get; set; }
    }
}
