using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace LegendsLabor.Core.Domain.Entities
{
    public class PlayerRecipe : AuditableEntity // Tracks a player's discovery of a Recipe
    {
        [Key]
        [Comment("Primary key for the PlayerRecipe entity.")]
        public int Id { get; set; }

        [ForeignKey("Id")]
        [Comment("Foreign key to the Player entity.")]
        public int PlayerId { get; set; }

        [Comment("Navigation property to the Player entity.")]
        public Player Player { get; set; } = null!;

        [ForeignKey("Id")]
        [Comment("Foreign key to the Recipe entity.")]
        public int RecipeId { get; set; }

        [Comment("Navigation property to the discovered Recipe.")]
        public Recipe Recipe { get; set; } = null!;

        [Comment("Indicates if the recipe has been discovered by the player.")]
        public bool IsDiscovered { get; set; } = false;

        [Comment("The date and time when the recipe was discovered. Nullable until discovered.")]
        public DateTime? DiscoveryDate { get; set; }
    }
}
