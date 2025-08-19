using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace LegendsLabor.Core.Domain.Entities
{
    public class Recipe : AuditableEntity, IEntity<int>
    {
        [Key]
        [Comment("Primary key for the Recipe entity.")]
        public int Id { get; set; }

        [ForeignKey("Id")]
        [Comment("Foreign key to the Item produced by this recipe.")]
        public int OutputItemId { get; set; }

        [Comment("Navigation property to the Item produced by this recipe.")]
        public Item OutputItem { get; set; } = null!;

        [Comment("The quantity of the output item produced by this recipe.")]
        public int OutputQuantity { get; set; } = 1;

        [Comment("The difficulty level of the recipe.")]
        public int DifficultyLevel { get; set; } = 1;

        [MaxLength(50)]
        [Comment("The type of skill required for this recipe (e.g., 'Blacksmithing', 'Alchemy'). Nullable if no specific skill.")]
        public string? SkillTypeRequired { get; set; }

        [Comment("The required level in the SkillTypeRequired. Nullable.")]
        public int? SkillLevelRequired { get; set; }

        // Navigation properties
        [Comment("Collection of ingredients required for this recipe.")]
        public ICollection<RecipeIngredient> Ingredients { get; set; } = new List<RecipeIngredient>();

        [Comment("Collection of PlayerRecipe instances related to this recipe.")]
        public ICollection<PlayerRecipe> PlayerRecipes { get; set; } = new List<PlayerRecipe>();
    }
}
