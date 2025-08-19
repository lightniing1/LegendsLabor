using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace LegendsLabor.Core.Domain.Entities
{
    public class PlayerStatModifier : AuditableEntity, IEntity<int>
    {
        [Key]
        [Comment("Primary key for the PlayerStatModifier entity.")]
        public int Id { get; set; }

        [ForeignKey("Id")]
        [Comment("Foreign key to the Player entity.")]
        public int PlayerId { get; set; }

        [Comment("Navigation property to the Player entity.")]
        public Player Player { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        [Comment("The type of stat being modified (e.g., 'Might', 'Skill', 'Focus').")]
        public string StatType { get; set; } = string.Empty;

        [Comment("The value of the stat modification (can be positive or negative).")]
        public int Value { get; set; }

        [Required]
        [MaxLength(50)]
        [Comment("The source of the stat modifier (e.g., 'Item', 'Skill', 'Temporary Effect', 'Event').")]
        public string Source { get; set; } = string.Empty;

        [Comment("The ID of the source (e.g., ItemId, SkillId). Nullable.")]
        public int? SourceId { get; set; }

        [Comment("Indicates if the stat modifier is currently active.")]
        public bool IsActive { get; set; }

        [Comment("The date and time when the stat modifier expires. Nullable.")]
        public DateTime? ExpiresAt { get; set; }
    }
}
