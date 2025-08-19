using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace LegendsLabor.Core.Domain.Entities
{
    public class GameEvent : AuditableEntity, IEntity<int>
    {
        [Key]
        [Comment("Primary key for the GameEvent entity")]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Comment("The name of the game event.")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(255)]
        [Comment("A description of the game event.")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Comment("The start date and time of the game event.")]
        public DateTime StartDate { get; set; }
        
        [Comment("The end date and time of the game event.")]
        public DateTime EndDate { get; set; }

        [Required]
        [MaxLength(50)]
        [Comment("The status of the game event (e.g., Upcoming, Active, Completed).")]
        public string Status { get; set; } = "Upcoming";

        [Required]
        [MaxLength(50)]
        [Comment("The type of game event (e.g., Special Combat, Collection Event, Double XP, Double Gold).")]
        public string EventType { get; set; } = string.Empty; // Special Combat, Collection Event, Double XP, Double Gold

        [Comment("The minimum player level required to participate in the event. Nullable.")]
        public int? MinimumPlayerLevel { get; set; }

        // Navigation property
        [Comment("Collection of rewards associated with this game event.")]
        public ICollection<GameEventReward> Rewards { get; set; } = new List<GameEventReward>();
    }
}
