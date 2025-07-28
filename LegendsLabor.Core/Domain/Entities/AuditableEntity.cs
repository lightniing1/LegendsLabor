using Microsoft.EntityFrameworkCore;

namespace LegendsLabor.Core.Domain.Entities
{
    public abstract class AuditableEntity
    {
        [Comment("The date and time when the entity was created.")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Comment("The user who created the entity. Nullable.")]
        public string? CreatedBy { get; set; }
        [Comment("The date and time when the entity was last updated. Nullable.")]
        public DateTime? UpdatedAt { get; set; }
        [Comment("The user who last updated the entity. Nullable.")]
        public string? UpdatedBy { get; set; }
        [Comment("The date and time when the entity was deleted. Nullable.")]
        public DateTime? DeletedAt { get; set; }
        [Comment("The user who deleted the entity. Nullable.")]
        public string? DeletedBy { get; set; }
        [Comment("Indicates if the entity is deleted.")]
        public bool IsDeleted { get; set; }
    }
}