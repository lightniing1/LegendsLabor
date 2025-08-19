using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LegendsLabor.Core.Domain.Entities
{
    public class ItemEffect : AuditableEntity, IEntity<int>
    {
        [Key]
        [Comment("Primary key for the ItemEffect entity.")]
        public int Id { get; set; }

        [ForeignKey("Id")]
        [Comment("Foreign key to the Item entity.")]
        public int ItemId { get; set; }

        [Comment("Navigation property to the Item entity.")]
        public Item Item { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        [Comment("The type of effect (e.g., StatBoost, Recovery, Special).")]
        public string EffectType { get; set; } = string.Empty;

        [MaxLength(50)]
        [Comment("The stat affected by the item effect (e.g., 'Might', 'Skill', 'Focus'). Nullable.")]
        public string? AffectedStat { get; set; }

        [Comment("The amount of boost/effect.")]
        public int Value { get; set; }

        [Comment("Indicates whether the effect lasts permanently *while equipped* (for equipment).")]
        public bool IsPermanent { get; set; }

        [Comment("Duration of the effect in minutes for temporary effects (consumables, timed buffs). Nullable.")]
        public int? DurationMinutes { get; set; }

        [Comment("Indicates whether using the effect consumes the item (typically true for Consumables).")]
        public bool ConsumesItem { get; set; }
    }
}
