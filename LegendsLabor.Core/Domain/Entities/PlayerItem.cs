using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace LegendsLabor.Core.Domain.Entities
{
    public class PlayerItem : AuditableEntity
    {
        [Key]
        [Comment("Primary key for the PlayerItem entity.")]
        public int Id { get; set; }

        [ForeignKey("Id")]
        [Comment("Foreign key to the Player entity.")]
        public int PlayerId { get; set; }

        [Comment("Navigation property to the Player entity.")]
        public Player Player { get; set; } = null!;

        [ForeignKey("Id")]
        [Comment("Foreign key to the Item entity.")]
        public int ItemId { get; set; }

        [Comment("Navigation property to the Item entity.")]
        public Item Item { get; set; } = null!;

        [Comment("The quantity of the item the player possesses.")]
        public int Quantity { get; set; }

        [Comment("Indicates if the item is currently equipped by the player.")]
        public bool IsEquipped { get; set; }

        [MaxLength(50)]
        [Comment("The equipment slot for the item (e.g., Weapon, Helmet, Chest). Nullable if not equipped or equippable.")]
        public string? EquipSlot { get; set; }

        [Comment("The date and time when the item was acquired.")]
        public DateTime AcquiredAt { get; set; }

        [Comment("The date and time when the item expires (for limited-time items). Nullable.")]
        public DateTime? ExpiresAt { get; set; }
    }
}
