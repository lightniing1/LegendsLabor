using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LegendsLabor.Core.Domain.Entities
{
    public class Collection : AuditableEntity, IEntity<int>
    {
        [Key]
        [Comment("Primary key for the Collection entity.")]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Comment("The name of the collection.")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(255)]
        [Comment("A description of the collection.")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [MaxLength(255)]
        [Comment("A description of the reward for completing the collection.")]
        public string RewardDescription { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        [Comment("The gold reward value for completing the collection. Nullable.")]
        public decimal? GoldRewardValue { get; set; }

        [Comment("The character experience reward for completing the collection. Nullable.")]
        public int? ExperienceReward { get; set; }

        [ForeignKey("Id")]
        [Comment("Foreign key to the Item definition for the reward. Nullable.")]
        public int? ItemIdReward { get; set; }

        [Comment("Navigation property to the Item reward. Nullable.")]
        public Item? ItemReward { get; set; }

        [Comment("The quantity of the item reward. Nullable.")]
        public int? ItemQuantityReward { get; set; }

        [Comment("Collection of items that belong to this collection.")]
        public ICollection<CollectionItem> CollectionItems { get; set; } = new List<CollectionItem>();

        [Comment("Collection of PlayerCollection instances related to this collection.")]
        public ICollection<PlayerCollection> PlayerCollections { get; set; } = new List<PlayerCollection>();
    }
}
