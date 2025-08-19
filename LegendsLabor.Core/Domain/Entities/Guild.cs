using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LegendsLabor.Core.Domain.Entities
{
    public class Guild : AuditableEntity, IEntity<Guid>
    {
        [Key]
        [Comment("Primary key for the Guild entity.")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [ForeignKey("Id")]
        [Comment("Foreign key to the Player who owns the guild.")]
        public Guid PlayerId { get; set; }

        [Comment("Navigation property to the Player who owns the guild.")]
        public Player Owner { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        [Comment("The name of the guild.")]
        public string Name { get; set; } = string.Empty;

        [MaxLength(255)]
        [Comment("URL for the guild's logo. Nullable.")]
        public string? Logo { get; set; }

        [Comment("The date when the guild was founded.")]
        public DateTime FoundationDate { get; set; }

        [Comment("The overall rating of the guild, calculated based on its members.")]
        public int OverallRating { get; set; }

        [Comment("Collection of members belonging to this guild.")]
        public ICollection<GuildMember> GuildMembers { get; set; } = new List<GuildMember>();
    }
}
