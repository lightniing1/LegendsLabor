using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LegendsLabor.Core.Domain.Entities
{
    public class Item : AuditableEntity, IEntity<int>
    {
        [Key]
        [Comment("Primary key for the Item entity.")]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Comment("The name of the item.")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(255)]
        [Comment("A description of the item.")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        [Comment("The category of the item (e.g., Equipment, Consumable, Collectible).")]
        public string Category { get; set; } = "Equipment";

        [Required]
        [MaxLength(50)]
        [Comment("The sub-category of the item (e.g., Sword, Axe, Shield, Helmet, Potion, Gem).")]
        public string SubCategory { get; set; } = "Weapon";

        [Comment("The required player level to use this item.")]
        public int Level { get; set; }

        [MaxLength(255)]
        [Comment("URL for the item's image. Nullable.")]
        public string? ImageUrl { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Comment("The cost of the item in Gold.")]
        public decimal GoldPrice { get; set; }

        [Comment("Indicates if the item is available for purchase in the store.")]
        public bool IsAvailableInStore { get; set; }

        // Navigation properties
        [Comment("Collection of effects associated with this item.")]
        // Collection of effects associated with this item.
        public ICollection<ItemEffect> Effects { get; set; } = new List<ItemEffect>();
        [Comment("Collection of PlayerItem instances related to this item.")]
        // Collection of PlayerItem instances related to this item.
        public ICollection<PlayerItem> PlayerItems { get; set; } = new List<PlayerItem>();
        // Collection of work rewards that can include this item.
        public ICollection<WorkReward> WorkRewards { get; set; } = new List<WorkReward>();
        // Collection of tournament rewards that can include this item.
        public ICollection<TournamentRewardItem> TournamentRewards { get; set; } = new List<TournamentRewardItem>();
        // Collection of game event rewards that can include this item.
        public ICollection<GameEventReward> GameEventRewards { get; set; } = new List<GameEventReward>();
        // Collection of collection items that can include this item.
        public ICollection<CollectionItem> CollectionItems { get; set; } = new List<CollectionItem>();
    }
}
