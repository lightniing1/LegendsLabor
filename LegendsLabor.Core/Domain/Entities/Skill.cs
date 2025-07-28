using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace LegendsLabor.Core.Domain.Entities
{
    public class Skill : AuditableEntity
    {
        [Key]
        [Comment("Primary key for the Skill entity.")]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Comment("The name of the skill.")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(255)]
        [Comment("A description of the skill.")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        [Comment("The category of the skill (e.g., Offensive, Defensive, Passive, Active).")]
        public string Category { get; set; } = string.Empty;

        [Comment("The maximum level this skill can reach.")]
        public int MaxLevel { get; set; }

        [Comment("The base cooldown of the skill in seconds (0 if passive or turn-based).")]
        public int BaseCooldown { get; set; }

        [Comment("The base effectiveness value for skill effects.")]
        public int BaseEffectiveness { get; set; }

        [Comment("The minimum player level required to unlock this skill.")]
        public int RequiredPlayerLevel { get; set; }

        [Comment("The cost in Skill Points to unlock this skill.")]
        public int SkillPointsCostToUnlock { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Comment("Optional gold cost to unlock this skill.")]
        public decimal GoldCostToUnlock { get; set; }

        // Navigation properties
        [Comment("Collection of effects associated with this skill.")]
        // Collection of effects associated with this skill.
        public ICollection<SkillEffect> Effects { get; set; } = new List<SkillEffect>();
        [Comment("Collection of PlayerSkill instances related to this skill.")]
        // Collection of PlayerSkill instances related to this skill.
        public ICollection<PlayerSkill> PlayerSkills { get; set; } = new List<PlayerSkill>();
        // Collection of training types that can target this skill.
        public ICollection<TrainingType> TrainingTypes { get; set; } = new List<TrainingType>(); // Training can target specific skills
    }
}
