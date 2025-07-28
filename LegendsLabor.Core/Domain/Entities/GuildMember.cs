using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LegendsLabor.Core.Domain.Entities
{
    public class GuildMember : AuditableEntity
    {
        [Key]
        [Comment("Primary key for the GuildMember entity.")]
        public int Id { get; set; }

        [ForeignKey("Id")]
        [Comment("Foreign key to the Guild this member belongs to.")]
        public int GuildId { get; set; }

        [Comment("Navigation property to the Guild entity.")]
        public Guild Guild { get; set; } = null!;

        [ForeignKey("Id")]
        [Comment("Foreign key to the MemberType of this guild member.")]
        public int MemberTypeId { get; set; }

        [Comment("Navigation property to the MemberType entity.")]
        public MemberType MemberType { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        [Comment("The name of the guild member.")]
        public string Name { get; set; } = string.Empty;

        [Comment("The level of the guild member.")]
        public int Level { get; set; }
        [Required]
        [MaxLength(50)]
        [Comment("The rarity of the guild member (e.g., 'Common').")]
        public string Rarity { get; set; } = "Common";

        [Required]
        [MaxLength(50)]
        [Comment("The position or role of the guild member (e.g., 'Warrior').")]
        public string Position { get; set; } = "Warrior";

        [Comment("The might combat stat of the guild member.")]
        public int Might { get; set; }
        [Comment("The skill combat stat of the guild member.")]

        public int Skill { get; set; }
        [Comment("The focus combat stat of the guild member.")]
        public int Focus { get; set; }

        public int OverallRating { get; set; } // Calculated based on stats

        [Column(TypeName = "decimal(18,2)")]
        [Comment("The gold stipend for the guild member.")]
        public decimal Stipend { get; set; }

        public DateTime ContractExpiration { get; set; }

        public bool IsActive { get; set; }
    }
}
