using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace LegendsLabor.Core.Domain.Entities
{
    public class MemberType : AuditableEntity
    {
        [Key]
        [Comment("Primary key for the MemberType entity.")]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Comment("The type of member (e.g., Warrior, Mage, Scout).")]
        public string Type { get; set; } = string.Empty;

        [MaxLength(255)]
        [Comment("A description of the member type. Nullable.")]
        public string? Description { get; set; }

        // Navigation property
        [Comment("Collection of GuildMember instances associated with this member type.")]
        public ICollection<GuildMember> GuildMembers { get; set; } = new List<GuildMember>();
    }
}
