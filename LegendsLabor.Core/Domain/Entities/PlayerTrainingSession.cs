using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace LegendsLabor.Core.Domain.Entities
{
    public class PlayerTrainingSession : AuditableEntity, IEntity<int>
    {
        [Key]
        [Comment("The unique identifier for the player training session.")]
        public int Id { get; set; }

        [Comment("Foreign key to the Player definition in SQL.")]
        public int PlayerId { get; set; } // FK to Player definition in SQL

        [Comment("Foreign key to the TrainingType definition in SQL.")]
        public int TrainingTypeId { get; set; } // FK to TrainingType definition in SQL

        [Required]
        [Comment("The current state of the training session (e.g., 'InProgress').")]
        public string CurrentState { get; set; } = "InProgress"; // State pattern

        [Comment("The date and time when the training session started.")]
        public DateTime StartedAt { get; set; } = DateTime.UtcNow;

        [Comment("The date and time when the training session was completed. Nullable.")]
        public DateTime? CompletedAt { get; set; }

        [Comment("The date and time until which the activity is on cooldown. Nullable.")]
        public DateTime? CooldownUntil { get; set; }
    }
}
