using LegendsLabor.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LegendsLabor.Infrastructure
{
    public class LegendsLaborDbContext : DbContext
    {
        public LegendsLaborDbContext(DbContextOptions<LegendsLaborDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Collection> Collections { get; set; }
        public DbSet<PlayerCollection> PlayerCollections { get; set; }
        public DbSet<PlayerItem> PlayerItems { get; set; }
        public DbSet<GameEvent> GameEvents { get; set; }
        public DbSet<Friendship> Friendships { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<CollectionItem> CollectionItems { get; set; }
        public DbSet<GameEventReward> GameEventRewards { get; set; }
        public DbSet<PlayerSkill> PlayerSkills { get; set; }
        public DbSet<PlayerStatModifier> PlayerStatModifiers { get; set; }
        public DbSet<Base> Bases { get; set; }
        public DbSet<Guild> Guilds { get; set; }
        public DbSet<PlayerRecipe> PlayerRecipes { get; set; }
        public DbSet<ItemEffect> ItemEffects { get; set; }
        public DbSet<GuildMember> GuildMembers { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<MemberType> MemberTypes { get; set; }
        public DbSet<TournamentReward> TournamentRewards { get; set; }
        public DbSet<TournamentRewardItem> TournamentRewardItems { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<WorkReward> WorkRewards { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<SkillEffect> SkillEffects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Friendship: PlayerA
            modelBuilder.Entity<Friendship>()
                .HasOne(f => f.PlayerA)
                .WithMany(p => p.ChallengedFriendships)
                .HasForeignKey(f => f.PlayerIdA)
                .OnDelete(DeleteBehavior.Restrict);

            // Friendship: PlayerB
            modelBuilder.Entity<Friendship>()
                .HasOne(f => f.PlayerB)
                .WithMany(p => p.ChallengerFriendships)
                .HasForeignKey(f => f.PlayerIdB)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}