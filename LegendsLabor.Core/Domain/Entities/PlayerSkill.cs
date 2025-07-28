using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LegendsLabor.Core.Domain.Entities
{
    public class PlayerSkill : AuditableEntity
    {
        [Key]
        [Comment("Primary key for the PlayerSkill entity.")]
        public int Id { get; set; }

        [ForeignKey("Id")]
        [Comment("Foreign key to the Player entity.")]
        public int PlayerId { get; set; }

        [Comment("Navigation property to the Player entity.")]
        public Player Player { get; set; } = null!; // Navigation property

        [ForeignKey("Id")]
        [Comment("Foreign key to the Skill entity.")]
        public int SkillId { get; set; }

        [Comment("Navigation property to the Skill entity.")]
        public Skill Skill { get; set; } = null!; // Navigation property

        [Comment("The current level of the player's skill.")]
        public int Level { get; set; }

        [Comment("Experience towards this skill.")]
        public int Experience { get; set; }

        [Comment("The date and time when the skill was unlocked.")]
        public DateTime UnlockedAt { get; set; }

        [Comment("Indicates if the skill is active (e.g., if skills can be toggled or are passive/active).")]
        public bool IsActive { get; set; }
    }
}
