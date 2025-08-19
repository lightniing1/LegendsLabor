using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace LegendsLabor.Core.Domain.Entities
{
    public class PlayerWorkSession : AuditableEntity, IEntity<int>
    {
        [Key]
        [Comment("The unique identifier for the player work session.")]
        public int Id { get; set; }

        [Comment("Foreign key to the Player definition in SQL.")]
        public int PlayerId { get; set; }

        [Comment("Foreign key to the Work definition in SQL.")]
        public int WorkId { get; set; }

        [Required]
        [Comment("The current state of the work session (e.g., 'InProgress').")]
        public string CurrentState { get; set; } = "InProgress"; // State pattern

        [Comment("The date and time when the work session started.")]
        public DateTime StartedAt { get; set; } = DateTime.UtcNow;

        [Comment("The date and time when the work session was completed. Nullable.")]
        public DateTime? CompletedAt { get; set; }

        [Comment("The date and time until which the activity is on cooldown. Nullable.")]
        public DateTime? CooldownUntil { get; set; }
    }
}
