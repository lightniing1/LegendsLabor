using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LegendsLabor.Core.Domain.Entities
{
    public class CollectionItem : AuditableEntity
    {
        [Key]
        [Comment("Primary key for the CollectionItem entity.")]
        public int Id { get; set; }

        [ForeignKey("Id")]
        [Comment("Foreign key to the Collection entity.")]
        public int CollectionId { get; set; }

        [Comment("Navigation property to the Collection entity.")]
        public Collection Collection { get; set; } = null!;

        [ForeignKey("Id")]
        [Comment("Foreign key to the Item entity.")]
        public int ItemId { get; set; }

        [Comment("Navigation property to the Item entity.")]
        public Item Item { get; set; } = null!;
    }
}
