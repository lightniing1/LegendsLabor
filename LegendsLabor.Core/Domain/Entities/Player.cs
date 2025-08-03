using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LegendsLabor.Core.Domain.Entities
{
    public class Player : AuditableEntity
    {
        [Key]
        [Comment("Primary key for the Player entity.")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [ForeignKey("Id")]
        [Comment("Foreign key to the User entity.")]
        public Guid UserId { get; set; }

        [Comment("Navigation property to the User entity.")]
        public User User { get; set; } = null!; // Navigation property

        [Required]
        [MaxLength(50)]
        [Comment("The player's in-game nickname.")]
        public string Nickname { get; set; } = string.Empty;

        [Comment("The current level of the player.")]
        public int Level { get; set; }

        [Comment("Character Experience for Leveling Up.")]
        public int Experience { get; set; }

        [Comment("The current energy points of the player.")]
        public int Energy { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Comment("The primary currency (gold) held by the player.")]
        public decimal Gold { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Comment("The gold stored in the player's bank.")]
        public decimal BankedGold { get; set; }

        [Comment("Skill Points Gained on Level Up, spent on Skills.")]
        public int SkillPoints { get; set; }

        [Comment("The player's might combat stat.")]
        public int Might { get; set; }

        [Comment("The player's skill combat stat.")]
        public int Skill { get; set; }

        [Comment("The player's focus combat stat.")]
        public int Focus { get; set; }

        [Comment("Combat Rating/Power Level of the player.")]
        public int OverallRating { get; set; }

        [Comment("Total number of matches played by the player.")]
        public int MatchesPlayed { get; set; }

        [Comment("Total number of wins by the player.")]
        public int Wins { get; set; }

        [Comment("Total number of losses by the player.")]
        public int Losses { get; set; }

        [Comment("Total number of draws by the player.")]
        public int Draws { get; set; }

        [Comment("Total number of enemies defeated by the player.")]
        public int EnemiesDefeated { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Comment("Total gold earned by the player.")]
        public decimal GoldEarnedTotal { get; set; }

        [Comment("Total experience earned by the player.")]
        public int ExperienceEarnedTotal { get; set; }

        [Comment("Total count of labor activities completed by the player.")]
        public int LaborCompletedCount { get; set; }

        [Comment("Total count of collections completed by the player.")]
        public int CollectionsCompletedCount { get; set; }

        [Required]
        [MaxLength(50)]
        [Comment("The current state of the player (Idle, Laboring, Training, InCombat, etc.).")]
        public string CurrentState { get; set; } = "Idle"; // State pattern (Idle, Laboring, Training, InCombat, etc.)

        public DateTime StateChangedAt { get; set; }

        [MaxLength(255)]
        public string? ProfileImageUrl { get; set; }

        [Comment("Maximum health points of the player.")]
        public int MaxHealth { get; set; } = 100;

        [Comment("Maximum energy points of the player.")]
        public int MaxEnergy { get; set; } = 100;

        [Column(TypeName = "decimal(5,2)")]
        [Comment("The critical hit chance of the player.")]
        public decimal CriticalChance { get; set; } = 5.0m;

        [Column(TypeName = "decimal(5,2)")]
        [Comment("The dodge chance of the player.")]
        public decimal DodgeChance { get; set; } = 5.0m;

        [Column(TypeName = "decimal(5,2)")]
        [Comment("The energy regeneration rate of the player.")]
        public decimal EnergyRegenRate { get; set; } = 1.0m;

        // Navigation properties (Relationships within SQL Server)
        // Collection of stat modifiers applied to the player.
        public ICollection<PlayerStatModifier> StatModifiers { get; set; } = new List<PlayerStatModifier>();
        // Collection of skills owned and leveled up by the player.
        public ICollection<PlayerSkill> Skills { get; set; } = new List<PlayerSkill>(); // Skills player owns and leveled up
        // Collection of items in the player's inventory.
        public ICollection<PlayerItem> Items { get; set; } = new List<PlayerItem>(); // Inventory
        // Collection of bases owned by the player.
        public ICollection<Base> Bases { get; set; } = new List<Base>(); // Player-owned Bases/Bases (assuming 1:Many, adjust if 1:1)
        // Collection of completed collections by the player.
        public ICollection<PlayerCollection> PlayerCollections { get; set; } = new List<PlayerCollection>(); // Completed collections
        // Collection of friendships where this player initiated the challenge.
        public ICollection<Friendship> ChallengedFriendships { get; set; } = new List<Friendship>();
        // Collection of friendships where this player was challenged.
        public ICollection<Friendship> ChallengerFriendships { get; set; } = new List<Friendship>();
        // Assuming a player can own one guild (1:1 relationship)
        // The guild owned by the player. Nullable.
        public Guild? OwnedGuild { get; set; }
        public ICollection<PlayerRecipe> PlayerRecipes { get; set; } = new List<PlayerRecipe>();
    }
}
