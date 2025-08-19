using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LegendsLabor.Core.Domain.Entities
{
    public class Friendship : AuditableEntity, IEntity<Guid>
    {
        [Key]
        [Comment("Primary key for the Friendship entity.")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [ForeignKey("Id")]
        [Comment("Foreign key to the first player in the friendship.")]
        public Guid PlayerIdA { get; set; }

        [Comment("Navigation property to the first player in the friendship.")]
        public Player PlayerA { get; set; } = null!;

        [ForeignKey("Id")]
        [Comment("Foreign key to the second player in the friendship.")]
        public Guid PlayerIdB { get; set; }

        [Comment("Navigation property to the second player in the friendship.")]
        public Player PlayerB { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        [Comment("The nickname of the first player in the friendship.")]
        public string Status { get; set; } = "Pending"; // Pending, Accepted, Blocked
    }
}
