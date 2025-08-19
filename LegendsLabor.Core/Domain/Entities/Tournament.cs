using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace LegendsLabor.Core.Domain.Entities
{
    public class Tournament : AuditableEntity, IEntity<Guid>
    {
        [Key]
        [Comment("Primary key for the Tournament entity.")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(100)]
        [Comment("The name of the tournament.")]
        public string Name { get; set; } = string.Empty;

        [Comment("The start date and time of the tournament.")]
        public DateTime StartDate { get; set; }

        [Comment("The end date and time of the tournament.")]
        public DateTime EndDate { get; set; }

        [Required]
        [MaxLength(50)]
        [Comment("The status of the tournament (e.g., Upcoming, Active, Completed).")]
        public string Status { get; set; } = "Upcoming";

        [Required]
        [MaxLength(50)]
        [Comment("The type of tournament (e.g., Arena, GuildWar, Special).")]
        public string Type { get; set; } = "Arena";

        [Comment("The minimum player level required to participate in the tournament. Nullable.")]
        public int? MinPlayerLevel { get; set; }

        [Comment("The maximum player level allowed to participate in the tournament. Nullable.")]
        public int? MaxPlayerLevel { get; set; }

        // Navigation property
        [Comment("Collection of rewards associated with this tournament.")]
        public ICollection<TournamentReward> Rewards { get; set; } = new List<TournamentReward>();
        // TournamentParticipantRecord instances are in MongoDB
    }
}
