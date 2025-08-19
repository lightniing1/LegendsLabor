using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace LegendsLabor.Core.Domain.Entities
{
    public class PlayerCollection : AuditableEntity, IEntity<int>
    {
        [Key]
        [Comment("Primary key for the PlayerCollection entity.")]
        public int Id { get; set; }

        [ForeignKey("Id")]
        [Comment("Foreign key to the Player entity.")]
        public int PlayerId { get; set; }

        [Comment("Navigation property to the Player entity.")]
        public Player Player { get; set; } = null!;

        [ForeignKey("Id")]
        [Comment("Foreign key to the Collection entity.")]
        public int CollectionId { get; set; }

        [Comment("Navigation property to the Collection entity.")]
        public Collection Collection { get; set; } = null!;

        [Comment("The date and time when the collection was completed.")]
        public DateTime CompletedAt { get; set; }

        [Comment("Indicates if the reward for completing the collection has been claimed.")]
        public bool RewardClaimed { get; set; }
    }
}
