using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace LegendsLabor.Core.Domain.Entities
{
    public class TournamentRewardItem : AuditableEntity, IEntity<int>
    {
        [Key]
        [Comment("Primary key for the TournamentRewardItem entity.")]
        public int Id { get; set; }

        [ForeignKey("Id")]
        [Comment("Foreign key to the TournamentReward entity.")]
        public int TournamentRewardId { get; set; }

        [Comment("Navigation property to the TournamentReward entity.")]
        public TournamentReward TournamentReward { get; set; } = null!;

        [ForeignKey("Id")]
        [Comment("Foreign key to the Item entity.")]
        public int ItemId { get; set; }

        [Comment("Navigation property to the Item entity.")]
        public Item Item { get; set; } = null!;

        [Comment("The quantity of the item reward.")]
        public int Quantity { get; set; }
    }
}
