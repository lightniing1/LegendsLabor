using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LegendsLabor.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GameEvents",
                columns: table => new
                {
                    GameEventId = table.Column<int>(type: "integer", nullable: false, comment: "Primary key for the GameEvent entity")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, comment: "The name of the game event."),
                    Description = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, comment: "A description of the game event."),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The start date and time of the game event."),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The end date and time of the game event."),
                    Status = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, comment: "The status of the game event (e.g., Upcoming, Active, Completed)."),
                    EventType = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, comment: "The type of game event (e.g., Special Combat, Collection Event, Double XP, Double Gold)."),
                    MinimumPlayerLevel = table.Column<int>(type: "integer", nullable: true, comment: "The minimum player level required to participate in the event. Nullable."),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The date and time when the entity was created."),
                    CreatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who created the entity. Nullable."),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was last updated. Nullable."),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who last updated the entity. Nullable."),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was deleted. Nullable."),
                    DeletedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who deleted the entity. Nullable."),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates if the entity is deleted.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameEvents", x => x.GameEventId);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "integer", nullable: false, comment: "Primary key for the Item entity.")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, comment: "The name of the item."),
                    Description = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, comment: "A description of the item."),
                    Category = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, comment: "The category of the item (e.g., Equipment, Consumable, Collectible)."),
                    SubCategory = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, comment: "The sub-category of the item (e.g., Sword, Axe, Shield, Helmet, Potion, Gem)."),
                    Level = table.Column<int>(type: "integer", nullable: false, comment: "The required player level to use this item."),
                    ImageUrl = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true, comment: "URL for the item's image. Nullable."),
                    GoldPrice = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "The cost of the item in Gold."),
                    IsAvailableInStore = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates if the item is available for purchase in the store."),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The date and time when the entity was created."),
                    CreatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who created the entity. Nullable."),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was last updated. Nullable."),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who last updated the entity. Nullable."),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was deleted. Nullable."),
                    DeletedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who deleted the entity. Nullable."),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates if the entity is deleted.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "MemberTypes",
                columns: table => new
                {
                    MemberTypeId = table.Column<int>(type: "integer", nullable: false, comment: "Primary key for the MemberType entity.")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, comment: "The type of member (e.g., Warrior, Mage, Scout)."),
                    Description = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true, comment: "A description of the member type. Nullable."),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The date and time when the entity was created."),
                    CreatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who created the entity. Nullable."),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was last updated. Nullable."),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who last updated the entity. Nullable."),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was deleted. Nullable."),
                    DeletedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who deleted the entity. Nullable."),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates if the entity is deleted.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberTypes", x => x.MemberTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    SkillId = table.Column<int>(type: "integer", nullable: false, comment: "Primary key for the Skill entity.")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, comment: "The name of the skill."),
                    Description = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, comment: "A description of the skill."),
                    Category = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, comment: "The category of the skill (e.g., Offensive, Defensive, Passive, Active)."),
                    MaxLevel = table.Column<int>(type: "integer", nullable: false, comment: "The maximum level this skill can reach."),
                    BaseCooldown = table.Column<int>(type: "integer", nullable: false, comment: "The base cooldown of the skill in seconds (0 if passive or turn-based)."),
                    BaseEffectiveness = table.Column<int>(type: "integer", nullable: false, comment: "The base effectiveness value for skill effects."),
                    RequiredPlayerLevel = table.Column<int>(type: "integer", nullable: false, comment: "The minimum player level required to unlock this skill."),
                    SkillPointsCostToUnlock = table.Column<int>(type: "integer", nullable: false, comment: "The cost in Skill Points to unlock this skill."),
                    GoldCostToUnlock = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "Optional gold cost to unlock this skill."),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The date and time when the entity was created."),
                    CreatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who created the entity. Nullable."),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was last updated. Nullable."),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who last updated the entity. Nullable."),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was deleted. Nullable."),
                    DeletedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who deleted the entity. Nullable."),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates if the entity is deleted.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.SkillId);
                });

            migrationBuilder.CreateTable(
                name: "Tournaments",
                columns: table => new
                {
                    TournamentId = table.Column<int>(type: "integer", nullable: false, comment: "Primary key for the Tournament entity.")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, comment: "The name of the tournament."),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The start date and time of the tournament."),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The end date and time of the tournament."),
                    Status = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, comment: "The status of the tournament (e.g., Upcoming, Active, Completed)."),
                    Type = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, comment: "The type of tournament (e.g., Arena, GuildWar, Special)."),
                    MinPlayerLevel = table.Column<int>(type: "integer", nullable: true, comment: "The minimum player level required to participate in the tournament. Nullable."),
                    MaxPlayerLevel = table.Column<int>(type: "integer", nullable: true, comment: "The maximum player level allowed to participate in the tournament. Nullable."),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The date and time when the entity was created."),
                    CreatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who created the entity. Nullable."),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was last updated. Nullable."),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who last updated the entity. Nullable."),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was deleted. Nullable."),
                    DeletedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who deleted the entity. Nullable."),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates if the entity is deleted.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournaments", x => x.TournamentId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false, comment: "Primary key for the User entity.")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Username = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, comment: "The username for the user."),
                    Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, comment: "The email address of the user."),
                    PasswordHash = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, comment: "The hashed password of the user for security."),
                    RegistrationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The date and time when the user registered."),
                    LastLoginDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the user last logged in. Nullable."),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates if the user account is active."),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The date and time when the entity was created."),
                    CreatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who created the entity. Nullable."),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was last updated. Nullable."),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who last updated the entity. Nullable."),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was deleted. Nullable."),
                    DeletedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who deleted the entity. Nullable."),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates if the entity is deleted.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Works",
                columns: table => new
                {
                    WorkId = table.Column<int>(type: "integer", nullable: false, comment: "Primary key for the Work entity. Renamable to LaborTypeId/GatheringTypeId.")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, comment: "The name of the work activity."),
                    Description = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, comment: "A description of the work activity."),
                    EnergyCost = table.Column<int>(type: "integer", nullable: false, comment: "The energy cost to perform this work activity."),
                    DurationMinutes = table.Column<int>(type: "integer", nullable: false, comment: "The duration of the work activity in minutes."),
                    ExperienceReward = table.Column<int>(type: "integer", nullable: false, comment: "The character experience reward for completing this work activity."),
                    GoldReward = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "The fixed gold reward for completing this work activity."),
                    MinimumPlayerLevel = table.Column<int>(type: "integer", nullable: false, comment: "The minimum player level required to undertake this work activity."),
                    ItemDropChance = table.Column<decimal>(type: "numeric(5,2)", nullable: false, comment: "The total chance for ANY item to drop from WorkRewards for this activity."),
                    CooldownMinutes = table.Column<int>(type: "integer", nullable: false, comment: "The cooldown period in minutes before this work activity can be attempted again."),
                    Tier = table.Column<int>(type: "integer", nullable: false, comment: "The tier of the work activity."),
                    FailureChance = table.Column<decimal>(type: "numeric(5,2)", nullable: false, comment: "The chance of failure for the activity."),
                    FailureDescription = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true, comment: "A description of the failure condition. Nullable."),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The date and time when the entity was created."),
                    CreatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who created the entity. Nullable."),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was last updated. Nullable."),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who last updated the entity. Nullable."),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was deleted. Nullable."),
                    DeletedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who deleted the entity. Nullable."),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates if the entity is deleted.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Works", x => x.WorkId);
                });

            migrationBuilder.CreateTable(
                name: "Collections",
                columns: table => new
                {
                    CollectionId = table.Column<int>(type: "integer", nullable: false, comment: "Primary key for the Collection entity.")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, comment: "The name of the collection."),
                    Description = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, comment: "A description of the collection."),
                    RewardDescription = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, comment: "A description of the reward for completing the collection."),
                    GoldRewardValue = table.Column<decimal>(type: "numeric(18,2)", nullable: true, comment: "The gold reward value for completing the collection. Nullable."),
                    ExperienceReward = table.Column<int>(type: "integer", nullable: true, comment: "The character experience reward for completing the collection. Nullable."),
                    ItemIdReward = table.Column<int>(type: "integer", nullable: true, comment: "Foreign key to the Item definition for the reward. Nullable."),
                    ItemRewardItemId = table.Column<int>(type: "integer", nullable: true),
                    ItemQuantityReward = table.Column<int>(type: "integer", nullable: true, comment: "The quantity of the item reward. Nullable."),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The date and time when the entity was created."),
                    CreatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who created the entity. Nullable."),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was last updated. Nullable."),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who last updated the entity. Nullable."),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was deleted. Nullable."),
                    DeletedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who deleted the entity. Nullable."),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates if the entity is deleted.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collections", x => x.CollectionId);
                    table.ForeignKey(
                        name: "FK_Collections_Items_ItemRewardItemId",
                        column: x => x.ItemRewardItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId");
                });

            migrationBuilder.CreateTable(
                name: "GameEventRewards",
                columns: table => new
                {
                    GameEventRewardId = table.Column<int>(type: "integer", nullable: false, comment: "Primary key for the GameEventReward entity.")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GameEventId = table.Column<int>(type: "integer", nullable: false, comment: "Foreign key to the GameEvent entity."),
                    RewardType = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, comment: "The type of reward (e.g., Item, Gold, Experience, StatBoost, SkillPoints)."),
                    ItemId = table.Column<int>(type: "integer", nullable: true, comment: "Foreign key to the Item definition for the reward. Nullable."),
                    Quantity = table.Column<int>(type: "integer", nullable: true, comment: "The quantity of the reward (for Item, Experience, SkillPoints). Nullable."),
                    GoldValue = table.Column<decimal>(type: "numeric(18,2)", nullable: true, comment: "The gold value of the reward. Nullable."),
                    AffectedStat = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true, comment: "The skill affected for SkillPoints rewards (e.g., 'Swordsmanship', 'Archery'). Nullable if RewardType is not SkillPoints."),
                    StatBoostValue = table.Column<int>(type: "integer", nullable: true, comment: "The value for StatBoost rewards. Nullable."),
                    IsPermanent = table.Column<bool>(type: "boolean", nullable: true, comment: "Indicates if the StatBoost is permanent. Nullable if not StatBoost."),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The date and time when the entity was created."),
                    CreatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who created the entity. Nullable."),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was last updated. Nullable."),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who last updated the entity. Nullable."),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was deleted. Nullable."),
                    DeletedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who deleted the entity. Nullable."),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates if the entity is deleted.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameEventRewards", x => x.GameEventRewardId);
                    table.ForeignKey(
                        name: "FK_GameEventRewards_GameEvents_GameEventId",
                        column: x => x.GameEventId,
                        principalTable: "GameEvents",
                        principalColumn: "GameEventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameEventRewards_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId");
                });

            migrationBuilder.CreateTable(
                name: "ItemEffects",
                columns: table => new
                {
                    ItemEffectId = table.Column<int>(type: "integer", nullable: false, comment: "Primary key for the ItemEffect entity.")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ItemId = table.Column<int>(type: "integer", nullable: false, comment: "Foreign key to the Item entity."),
                    EffectType = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, comment: "The type of effect (e.g., StatBoost, Recovery, Special)."),
                    AffectedStat = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true, comment: "The stat affected by the item effect (e.g., 'Might', 'Skill', 'Focus'). Nullable."),
                    Value = table.Column<int>(type: "integer", nullable: false, comment: "The amount of boost/effect."),
                    IsPermanent = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates whether the effect lasts permanently *while equipped* (for equipment)."),
                    DurationMinutes = table.Column<int>(type: "integer", nullable: true, comment: "Duration of the effect in minutes for temporary effects (consumables, timed buffs). Nullable."),
                    ConsumesItem = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates whether using the effect consumes the item (typically true for Consumables)."),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The date and time when the entity was created."),
                    CreatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who created the entity. Nullable."),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was last updated. Nullable."),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who last updated the entity. Nullable."),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was deleted. Nullable."),
                    DeletedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who deleted the entity. Nullable."),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates if the entity is deleted.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemEffects", x => x.ItemEffectId);
                    table.ForeignKey(
                        name: "FK_ItemEffects_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    RecipeId = table.Column<int>(type: "integer", nullable: false, comment: "Primary key for the Recipe entity.")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OutputItemId = table.Column<int>(type: "integer", nullable: false, comment: "Foreign key to the Item produced by this recipe."),
                    OutputQuantity = table.Column<int>(type: "integer", nullable: false, comment: "The quantity of the output item produced by this recipe."),
                    DifficultyLevel = table.Column<int>(type: "integer", nullable: false, comment: "The difficulty level of the recipe."),
                    SkillTypeRequired = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true, comment: "The type of skill required for this recipe (e.g., 'Blacksmithing', 'Alchemy'). Nullable if no specific skill."),
                    SkillLevelRequired = table.Column<int>(type: "integer", nullable: true, comment: "The required level in the SkillTypeRequired. Nullable."),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The date and time when the entity was created."),
                    CreatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who created the entity. Nullable."),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was last updated. Nullable."),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who last updated the entity. Nullable."),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was deleted. Nullable."),
                    DeletedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who deleted the entity. Nullable."),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates if the entity is deleted.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.RecipeId);
                    table.ForeignKey(
                        name: "FK_Recipes_Items_OutputItemId",
                        column: x => x.OutputItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SkillEffects",
                columns: table => new
                {
                    SkillEffectId = table.Column<int>(type: "integer", nullable: false, comment: "Primary key for the SkillEffect entity.")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SkillId = table.Column<int>(type: "integer", nullable: false, comment: "Foreign key to the Skill entity."),
                    EffectType = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, comment: "The type of effect (e.g., StatBoost, StatusEffect, Damage, Healing, ChanceModifier, TriggeredEffect, PassiveEffect)."),
                    AffectedStat = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true, comment: "The stat affected by the skill effect (e.g., 'Might', 'Skill', 'Focus'). Nullable."),
                    Value = table.Column<int>(type: "integer", nullable: false, comment: "The base value of the effect."),
                    ScalesWithLevel = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates if the effect gets stronger with skill level."),
                    ScalingFactor = table.Column<decimal>(type: "numeric(5,2)", nullable: false, comment: "How much the effect increases per level (e.g., 0.1 for +10%)."),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The date and time when the entity was created."),
                    CreatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who created the entity. Nullable."),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was last updated. Nullable."),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who last updated the entity. Nullable."),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was deleted. Nullable."),
                    DeletedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who deleted the entity. Nullable."),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates if the entity is deleted.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillEffects", x => x.SkillEffectId);
                    table.ForeignKey(
                        name: "FK_SkillEffects_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "SkillId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingType",
                columns: table => new
                {
                    TrainingTypeId = table.Column<int>(type: "integer", nullable: false, comment: "Primary key for the TrainingType entity. Renamable to TrainingRegimenId.")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, comment: "The name of the training activity."),
                    Description = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, comment: "A description of the training activity."),
                    EnergyCost = table.Column<int>(type: "integer", nullable: false, comment: "The energy cost to perform this training activity."),
                    DurationMinutes = table.Column<int>(type: "integer", nullable: false, comment: "The duration of the training activity in minutes."),
                    ExperienceReward = table.Column<int>(type: "integer", nullable: false, comment: "The character experience reward for completing this training activity."),
                    GoldCost = table.Column<decimal>(type: "numeric(18,2)", nullable: true, comment: "Optional gold cost for training. Nullable."),
                    TargetStatType = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true, comment: "The type of stat targeted by the training (e.g., 'Might', 'Skill', 'Focus'). Nullable if training targets skills or gives general XP/rewards."),
                    StatIncreaseValue = table.Column<int>(type: "integer", nullable: true, comment: "The base value of the stat increase from training. Nullable."),
                    TargetSkillId = table.Column<int>(type: "integer", nullable: true, comment: "Foreign key to the targeted Skill. Nullable if not targeting a specific skill."),
                    SkillExperienceReward = table.Column<int>(type: "integer", nullable: true, comment: "Experience gained towards a specific skill. Nullable."),
                    SkillPointsReward = table.Column<int>(type: "integer", nullable: true, comment: "Skill Points gained from training. Nullable."),
                    MinimumPlayerLevel = table.Column<int>(type: "integer", nullable: false),
                    CooldownMinutes = table.Column<int>(type: "integer", nullable: false),
                    Tier = table.Column<int>(type: "integer", nullable: false),
                    FailureChance = table.Column<decimal>(type: "numeric(5,2)", nullable: false),
                    FailurePenalty = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The date and time when the entity was created."),
                    CreatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who created the entity. Nullable."),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was last updated. Nullable."),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who last updated the entity. Nullable."),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was deleted. Nullable."),
                    DeletedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who deleted the entity. Nullable."),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates if the entity is deleted.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingType", x => x.TrainingTypeId);
                    table.ForeignKey(
                        name: "FK_TrainingType_Skills_TargetSkillId",
                        column: x => x.TargetSkillId,
                        principalTable: "Skills",
                        principalColumn: "SkillId");
                });

            migrationBuilder.CreateTable(
                name: "TournamentRewards",
                columns: table => new
                {
                    TournamentRewardId = table.Column<int>(type: "integer", nullable: false, comment: "Primary key for the TournamentReward entity.")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TournamentId = table.Column<int>(type: "integer", nullable: false, comment: "Foreign key to the Tournament entity."),
                    Position = table.Column<int>(type: "integer", nullable: false, comment: "The rank that receives this reward."),
                    Gold = table.Column<decimal>(type: "numeric(18,2)", nullable: true, comment: "The gold reward for this position. Nullable."),
                    Experience = table.Column<int>(type: "integer", nullable: true, comment: "The character experience reward for this position. Nullable."),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The date and time when the entity was created."),
                    CreatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who created the entity. Nullable."),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was last updated. Nullable."),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who last updated the entity. Nullable."),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was deleted. Nullable."),
                    DeletedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who deleted the entity. Nullable."),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates if the entity is deleted.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TournamentRewards", x => x.TournamentRewardId);
                    table.ForeignKey(
                        name: "FK_TournamentRewards_Tournaments_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "Tournaments",
                        principalColumn: "TournamentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "integer", nullable: false, comment: "Primary key for the Player entity.")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false, comment: "Foreign key to the User entity."),
                    Nickname = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, comment: "The player's in-game nickname."),
                    Level = table.Column<int>(type: "integer", nullable: false, comment: "The current level of the player."),
                    Experience = table.Column<int>(type: "integer", nullable: false, comment: "Character Experience for Leveling Up."),
                    Energy = table.Column<int>(type: "integer", nullable: false, comment: "The current energy points of the player."),
                    Gold = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "The primary currency (gold) held by the player."),
                    BankedGold = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "The gold stored in the player's bank."),
                    SkillPoints = table.Column<int>(type: "integer", nullable: false, comment: "Skill Points Gained on Level Up, spent on Skills."),
                    Might = table.Column<int>(type: "integer", nullable: false, comment: "The player's might combat stat."),
                    Skill = table.Column<int>(type: "integer", nullable: false, comment: "The player's skill combat stat."),
                    Focus = table.Column<int>(type: "integer", nullable: false, comment: "The player's focus combat stat."),
                    OverallRating = table.Column<int>(type: "integer", nullable: false, comment: "Combat Rating/Power Level of the player."),
                    MatchesPlayed = table.Column<int>(type: "integer", nullable: false, comment: "Total number of matches played by the player."),
                    Wins = table.Column<int>(type: "integer", nullable: false, comment: "Total number of wins by the player."),
                    Losses = table.Column<int>(type: "integer", nullable: false, comment: "Total number of losses by the player."),
                    Draws = table.Column<int>(type: "integer", nullable: false, comment: "Total number of draws by the player."),
                    EnemiesDefeated = table.Column<int>(type: "integer", nullable: false, comment: "Total number of enemies defeated by the player."),
                    GoldEarnedTotal = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "Total gold earned by the player."),
                    ExperienceEarnedTotal = table.Column<int>(type: "integer", nullable: false, comment: "Total experience earned by the player."),
                    LaborCompletedCount = table.Column<int>(type: "integer", nullable: false, comment: "Total count of labor activities completed by the player."),
                    CollectionsCompletedCount = table.Column<int>(type: "integer", nullable: false, comment: "Total count of collections completed by the player."),
                    CurrentState = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, comment: "The current state of the player (Idle, Laboring, Training, InCombat, etc.)."),
                    StateChangedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ProfileImageUrl = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    MaxHealth = table.Column<int>(type: "integer", nullable: false, comment: "Maximum health points of the player."),
                    MaxEnergy = table.Column<int>(type: "integer", nullable: false, comment: "Maximum energy points of the player."),
                    CriticalChance = table.Column<decimal>(type: "numeric(5,2)", nullable: false, comment: "The critical hit chance of the player."),
                    DodgeChance = table.Column<decimal>(type: "numeric(5,2)", nullable: false, comment: "The dodge chance of the player."),
                    EnergyRegenRate = table.Column<decimal>(type: "numeric(5,2)", nullable: false, comment: "The energy regeneration rate of the player."),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The date and time when the entity was created."),
                    CreatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who created the entity. Nullable."),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was last updated. Nullable."),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who last updated the entity. Nullable."),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was deleted. Nullable."),
                    DeletedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who deleted the entity. Nullable."),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates if the entity is deleted.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerId);
                    table.ForeignKey(
                        name: "FK_Players_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkRewards",
                columns: table => new
                {
                    WorkRewardId = table.Column<int>(type: "integer", nullable: false, comment: "Primary key for the WorkReward entity. Renamable to LaborRewardId.")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WorkId = table.Column<int>(type: "integer", nullable: false, comment: "Foreign key to the Work entity. Renamable to LaborTypeId."),
                    RewardType = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, comment: "The type of reward (e.g., Item, Experience, StatBoost)."),
                    ItemId = table.Column<int>(type: "integer", nullable: true, comment: "Foreign key to the Item definition. Nullable."),
                    Quantity = table.Column<int>(type: "integer", nullable: false, comment: "The quantity of the reward (for Item or Experience)."),
                    Value = table.Column<decimal>(type: "numeric(18,2)", nullable: true, comment: "The value for StatBoost rewards. Nullable."),
                    AffectedStat = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true, comment: "The stat affected for StatBoost rewards (e.g., 'Might', 'Skill', 'Focus'). Nullable if not StatBoost."),
                    DropChance = table.Column<decimal>(type: "numeric(5,2)", nullable: false, comment: "The percentage chance for this specific reward item/type to drop."),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The date and time when the entity was created."),
                    CreatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who created the entity. Nullable."),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was last updated. Nullable."),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who last updated the entity. Nullable."),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was deleted. Nullable."),
                    DeletedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who deleted the entity. Nullable."),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates if the entity is deleted.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkRewards", x => x.WorkRewardId);
                    table.ForeignKey(
                        name: "FK_WorkRewards_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId");
                    table.ForeignKey(
                        name: "FK_WorkRewards_Works_WorkId",
                        column: x => x.WorkId,
                        principalTable: "Works",
                        principalColumn: "WorkId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CollectionItems",
                columns: table => new
                {
                    CollectionItemId = table.Column<int>(type: "integer", nullable: false, comment: "Primary key for the CollectionItem entity.")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CollectionId = table.Column<int>(type: "integer", nullable: false, comment: "Foreign key to the Collection entity."),
                    ItemId = table.Column<int>(type: "integer", nullable: false, comment: "Foreign key to the Item entity."),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The date and time when the entity was created."),
                    CreatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who created the entity. Nullable."),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was last updated. Nullable."),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who last updated the entity. Nullable."),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was deleted. Nullable."),
                    DeletedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who deleted the entity. Nullable."),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates if the entity is deleted.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollectionItems", x => x.CollectionItemId);
                    table.ForeignKey(
                        name: "FK_CollectionItems_Collections_CollectionId",
                        column: x => x.CollectionId,
                        principalTable: "Collections",
                        principalColumn: "CollectionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CollectionItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecipeIngredients",
                columns: table => new
                {
                    RecipeIngredientId = table.Column<int>(type: "integer", nullable: false, comment: "Primary key for the RecipeIngredient entity.")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RecipeId = table.Column<int>(type: "integer", nullable: false, comment: "Foreign key to the Recipe entity."),
                    IngredientItemId = table.Column<int>(type: "integer", nullable: false, comment: "Foreign key to the required Item for this ingredient."),
                    QuantityRequired = table.Column<int>(type: "integer", nullable: false, comment: "The quantity of the ingredient item required."),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The date and time when the entity was created."),
                    CreatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who created the entity. Nullable."),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was last updated. Nullable."),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who last updated the entity. Nullable."),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was deleted. Nullable."),
                    DeletedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who deleted the entity. Nullable."),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates if the entity is deleted.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeIngredients", x => x.RecipeIngredientId);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Items_IngredientItemId",
                        column: x => x.IngredientItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "RecipeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TournamentRewardItems",
                columns: table => new
                {
                    TournamentRewardItemId = table.Column<int>(type: "integer", nullable: false, comment: "Primary key for the TournamentRewardItem entity.")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TournamentRewardId = table.Column<int>(type: "integer", nullable: false, comment: "Foreign key to the TournamentReward entity."),
                    ItemId = table.Column<int>(type: "integer", nullable: false, comment: "Foreign key to the Item entity."),
                    Quantity = table.Column<int>(type: "integer", nullable: false, comment: "The quantity of the item reward."),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The date and time when the entity was created."),
                    CreatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who created the entity. Nullable."),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was last updated. Nullable."),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who last updated the entity. Nullable."),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was deleted. Nullable."),
                    DeletedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who deleted the entity. Nullable."),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates if the entity is deleted.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TournamentRewardItems", x => x.TournamentRewardItemId);
                    table.ForeignKey(
                        name: "FK_TournamentRewardItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TournamentRewardItems_TournamentRewards_TournamentRewardId",
                        column: x => x.TournamentRewardId,
                        principalTable: "TournamentRewards",
                        principalColumn: "TournamentRewardId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bases",
                columns: table => new
                {
                    BaseId = table.Column<int>(type: "integer", nullable: false, comment: "Primary key for the Base entity.")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PlayerId = table.Column<int>(type: "integer", nullable: false, comment: "Foreign key to the Player entity."),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, comment: "The name of the player's base."),
                    Level = table.Column<int>(type: "integer", nullable: false, comment: "The current level of the base."),
                    Capacity = table.Column<int>(type: "integer", nullable: false, comment: "The capacity of the base (e.g., # of crafting stations, # of guild members housed)."),
                    IncomePerHour = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "The gold income generated by the base per hour."),
                    LastCollectedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The date and time when income was last collected from the base."),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The date and time when the entity was created."),
                    CreatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who created the entity. Nullable."),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was last updated. Nullable."),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who last updated the entity. Nullable."),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was deleted. Nullable."),
                    DeletedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who deleted the entity. Nullable."),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates if the entity is deleted.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bases", x => x.BaseId);
                    table.ForeignKey(
                        name: "FK_Bases_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Friendships",
                columns: table => new
                {
                    FriendshipId = table.Column<int>(type: "integer", nullable: false, comment: "Primary key for the Friendship entity.")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PlayerIdA = table.Column<int>(type: "integer", nullable: false, comment: "Foreign key to the first player in the friendship."),
                    PlayerIdB = table.Column<int>(type: "integer", nullable: false, comment: "Foreign key to the second player in the friendship."),
                    Status = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, comment: "The nickname of the first player in the friendship."),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The date and time when the entity was created."),
                    CreatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who created the entity. Nullable."),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was last updated. Nullable."),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who last updated the entity. Nullable."),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was deleted. Nullable."),
                    DeletedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who deleted the entity. Nullable."),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates if the entity is deleted.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friendships", x => x.FriendshipId);
                    table.ForeignKey(
                        name: "FK_Friendships_Players_PlayerIdA",
                        column: x => x.PlayerIdA,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Friendships_Players_PlayerIdB",
                        column: x => x.PlayerIdB,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Guilds",
                columns: table => new
                {
                    GuildId = table.Column<int>(type: "integer", nullable: false, comment: "Primary key for the Guild entity.")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PlayerId = table.Column<int>(type: "integer", nullable: false, comment: "Foreign key to the Player who owns the guild."),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, comment: "The name of the guild."),
                    Logo = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true, comment: "URL for the guild's logo. Nullable."),
                    FoundationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The date when the guild was founded."),
                    OverallRating = table.Column<int>(type: "integer", nullable: false, comment: "The overall rating of the guild, calculated based on its members."),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The date and time when the entity was created."),
                    CreatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who created the entity. Nullable."),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was last updated. Nullable."),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who last updated the entity. Nullable."),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was deleted. Nullable."),
                    DeletedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who deleted the entity. Nullable."),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates if the entity is deleted.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guilds", x => x.GuildId);
                    table.ForeignKey(
                        name: "FK_Guilds_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerCollections",
                columns: table => new
                {
                    PlayerCollectionId = table.Column<int>(type: "integer", nullable: false, comment: "Primary key for the PlayerCollection entity.")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PlayerId = table.Column<int>(type: "integer", nullable: false, comment: "Foreign key to the Player entity."),
                    CollectionId = table.Column<int>(type: "integer", nullable: false, comment: "Foreign key to the Collection entity."),
                    CompletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The date and time when the collection was completed."),
                    RewardClaimed = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates if the reward for completing the collection has been claimed."),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The date and time when the entity was created."),
                    CreatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who created the entity. Nullable."),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was last updated. Nullable."),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who last updated the entity. Nullable."),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was deleted. Nullable."),
                    DeletedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who deleted the entity. Nullable."),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates if the entity is deleted.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerCollections", x => x.PlayerCollectionId);
                    table.ForeignKey(
                        name: "FK_PlayerCollections_Collections_CollectionId",
                        column: x => x.CollectionId,
                        principalTable: "Collections",
                        principalColumn: "CollectionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerCollections_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerItems",
                columns: table => new
                {
                    PlayerItemId = table.Column<int>(type: "integer", nullable: false, comment: "Primary key for the PlayerItem entity.")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PlayerId = table.Column<int>(type: "integer", nullable: false, comment: "Foreign key to the Player entity."),
                    ItemId = table.Column<int>(type: "integer", nullable: false, comment: "Foreign key to the Item entity."),
                    Quantity = table.Column<int>(type: "integer", nullable: false, comment: "The quantity of the item the player possesses."),
                    IsEquipped = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates if the item is currently equipped by the player."),
                    EquipSlot = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true, comment: "The equipment slot for the item (e.g., Weapon, Helmet, Chest). Nullable if not equipped or equippable."),
                    AcquiredAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The date and time when the item was acquired."),
                    ExpiresAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the item expires (for limited-time items). Nullable."),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The date and time when the entity was created."),
                    CreatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who created the entity. Nullable."),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was last updated. Nullable."),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who last updated the entity. Nullable."),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was deleted. Nullable."),
                    DeletedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who deleted the entity. Nullable."),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates if the entity is deleted.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerItems", x => x.PlayerItemId);
                    table.ForeignKey(
                        name: "FK_PlayerItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerItems_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerRecipes",
                columns: table => new
                {
                    PlayerRecipeId = table.Column<int>(type: "integer", nullable: false, comment: "Primary key for the PlayerRecipe entity.")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PlayerId = table.Column<int>(type: "integer", nullable: false, comment: "Foreign key to the Player entity."),
                    RecipeId = table.Column<int>(type: "integer", nullable: false, comment: "Foreign key to the Recipe entity."),
                    IsDiscovered = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates if the recipe has been discovered by the player."),
                    DiscoveryDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the recipe was discovered. Nullable until discovered."),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The date and time when the entity was created."),
                    CreatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who created the entity. Nullable."),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was last updated. Nullable."),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who last updated the entity. Nullable."),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was deleted. Nullable."),
                    DeletedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who deleted the entity. Nullable."),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates if the entity is deleted.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerRecipes", x => x.PlayerRecipeId);
                    table.ForeignKey(
                        name: "FK_PlayerRecipes_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerRecipes_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "RecipeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerSkills",
                columns: table => new
                {
                    PlayerSkillId = table.Column<int>(type: "integer", nullable: false, comment: "Primary key for the PlayerSkill entity.")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PlayerId = table.Column<int>(type: "integer", nullable: false, comment: "Foreign key to the Player entity."),
                    SkillId = table.Column<int>(type: "integer", nullable: false, comment: "Foreign key to the Skill entity."),
                    Level = table.Column<int>(type: "integer", nullable: false, comment: "The current level of the player's skill."),
                    Experience = table.Column<int>(type: "integer", nullable: false, comment: "Experience towards this skill (if using hybrid XP/Points)."),
                    UnlockedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The date and time when the skill was unlocked."),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates if the skill is active (e.g., if skills can be toggled or are passive/active)."),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The date and time when the entity was created."),
                    CreatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who created the entity. Nullable."),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was last updated. Nullable."),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who last updated the entity. Nullable."),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was deleted. Nullable."),
                    DeletedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who deleted the entity. Nullable."),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates if the entity is deleted.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerSkills", x => x.PlayerSkillId);
                    table.ForeignKey(
                        name: "FK_PlayerSkills_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "SkillId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerStatModifiers",
                columns: table => new
                {
                    PlayerStatModifierId = table.Column<int>(type: "integer", nullable: false, comment: "Primary key for the PlayerStatModifier entity.")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PlayerId = table.Column<int>(type: "integer", nullable: false, comment: "Foreign key to the Player entity."),
                    StatType = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, comment: "The type of stat being modified (e.g., 'Might', 'Skill', 'Focus')."),
                    Value = table.Column<int>(type: "integer", nullable: false, comment: "The value of the stat modification (can be positive or negative)."),
                    Source = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, comment: "The source of the stat modifier (e.g., 'Item', 'Skill', 'Temporary Effect', 'Event')."),
                    SourceId = table.Column<int>(type: "integer", nullable: true, comment: "The ID of the source (e.g., ItemId, SkillId). Nullable."),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates if the stat modifier is currently active."),
                    ExpiresAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the stat modifier expires. Nullable."),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The date and time when the entity was created."),
                    CreatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who created the entity. Nullable."),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was last updated. Nullable."),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who last updated the entity. Nullable."),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was deleted. Nullable."),
                    DeletedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who deleted the entity. Nullable."),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates if the entity is deleted.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerStatModifiers", x => x.PlayerStatModifierId);
                    table.ForeignKey(
                        name: "FK_PlayerStatModifiers_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuildMembers",
                columns: table => new
                {
                    GuildMemberId = table.Column<int>(type: "integer", nullable: false, comment: "Primary key for the GuildMember entity.")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GuildId = table.Column<int>(type: "integer", nullable: false, comment: "Foreign key to the Guild this member belongs to."),
                    MemberTypeId = table.Column<int>(type: "integer", nullable: false, comment: "Foreign key to the MemberType of this guild member."),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, comment: "The name of the guild member."),
                    Level = table.Column<int>(type: "integer", nullable: false, comment: "The level of the guild member."),
                    Rarity = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, comment: "The rarity of the guild member (e.g., 'Common')."),
                    Position = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, comment: "The position or role of the guild member (e.g., 'Warrior')."),
                    Might = table.Column<int>(type: "integer", nullable: false, comment: "The might combat stat of the guild member."),
                    Skill = table.Column<int>(type: "integer", nullable: false, comment: "The skill combat stat of the guild member."),
                    Focus = table.Column<int>(type: "integer", nullable: false, comment: "The focus combat stat of the guild member."),
                    OverallRating = table.Column<int>(type: "integer", nullable: false),
                    Stipend = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "The gold stipend for the guild member."),
                    ContractExpiration = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "The date and time when the entity was created."),
                    CreatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who created the entity. Nullable."),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was last updated. Nullable."),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who last updated the entity. Nullable."),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "The date and time when the entity was deleted. Nullable."),
                    DeletedBy = table.Column<string>(type: "text", nullable: true, comment: "The user who deleted the entity. Nullable."),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Indicates if the entity is deleted.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuildMembers", x => x.GuildMemberId);
                    table.ForeignKey(
                        name: "FK_GuildMembers_Guilds_GuildId",
                        column: x => x.GuildId,
                        principalTable: "Guilds",
                        principalColumn: "GuildId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuildMembers_MemberTypes_MemberTypeId",
                        column: x => x.MemberTypeId,
                        principalTable: "MemberTypes",
                        principalColumn: "MemberTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bases_PlayerId",
                table: "Bases",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_CollectionItems_CollectionId",
                table: "CollectionItems",
                column: "CollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_CollectionItems_ItemId",
                table: "CollectionItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Collections_ItemRewardItemId",
                table: "Collections",
                column: "ItemRewardItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Friendships_PlayerIdA",
                table: "Friendships",
                column: "PlayerIdA");

            migrationBuilder.CreateIndex(
                name: "IX_Friendships_PlayerIdB",
                table: "Friendships",
                column: "PlayerIdB");

            migrationBuilder.CreateIndex(
                name: "IX_GameEventRewards_GameEventId",
                table: "GameEventRewards",
                column: "GameEventId");

            migrationBuilder.CreateIndex(
                name: "IX_GameEventRewards_ItemId",
                table: "GameEventRewards",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_GuildMembers_GuildId",
                table: "GuildMembers",
                column: "GuildId");

            migrationBuilder.CreateIndex(
                name: "IX_GuildMembers_MemberTypeId",
                table: "GuildMembers",
                column: "MemberTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Guilds_PlayerId",
                table: "Guilds",
                column: "PlayerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemEffects_ItemId",
                table: "ItemEffects",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerCollections_CollectionId",
                table: "PlayerCollections",
                column: "CollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerCollections_PlayerId",
                table: "PlayerCollections",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerItems_ItemId",
                table: "PlayerItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerItems_PlayerId",
                table: "PlayerItems",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerRecipes_PlayerId",
                table: "PlayerRecipes",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerRecipes_RecipeId",
                table: "PlayerRecipes",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_UserId",
                table: "Players",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlayerSkills_PlayerId",
                table: "PlayerSkills",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerSkills_SkillId",
                table: "PlayerSkills",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerStatModifiers_PlayerId",
                table: "PlayerStatModifiers",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_IngredientItemId",
                table: "RecipeIngredients",
                column: "IngredientItemId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_RecipeId",
                table: "RecipeIngredients",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_OutputItemId",
                table: "Recipes",
                column: "OutputItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillEffects_SkillId",
                table: "SkillEffects",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_TournamentRewardItems_ItemId",
                table: "TournamentRewardItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_TournamentRewardItems_TournamentRewardId",
                table: "TournamentRewardItems",
                column: "TournamentRewardId");

            migrationBuilder.CreateIndex(
                name: "IX_TournamentRewards_TournamentId",
                table: "TournamentRewards",
                column: "TournamentId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingType_TargetSkillId",
                table: "TrainingType",
                column: "TargetSkillId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkRewards_ItemId",
                table: "WorkRewards",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkRewards_WorkId",
                table: "WorkRewards",
                column: "WorkId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bases");

            migrationBuilder.DropTable(
                name: "CollectionItems");

            migrationBuilder.DropTable(
                name: "Friendships");

            migrationBuilder.DropTable(
                name: "GameEventRewards");

            migrationBuilder.DropTable(
                name: "GuildMembers");

            migrationBuilder.DropTable(
                name: "ItemEffects");

            migrationBuilder.DropTable(
                name: "PlayerCollections");

            migrationBuilder.DropTable(
                name: "PlayerItems");

            migrationBuilder.DropTable(
                name: "PlayerRecipes");

            migrationBuilder.DropTable(
                name: "PlayerSkills");

            migrationBuilder.DropTable(
                name: "PlayerStatModifiers");

            migrationBuilder.DropTable(
                name: "RecipeIngredients");

            migrationBuilder.DropTable(
                name: "SkillEffects");

            migrationBuilder.DropTable(
                name: "TournamentRewardItems");

            migrationBuilder.DropTable(
                name: "TrainingType");

            migrationBuilder.DropTable(
                name: "WorkRewards");

            migrationBuilder.DropTable(
                name: "GameEvents");

            migrationBuilder.DropTable(
                name: "Guilds");

            migrationBuilder.DropTable(
                name: "MemberTypes");

            migrationBuilder.DropTable(
                name: "Collections");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "TournamentRewards");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Works");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Tournaments");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
