using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LegendsLabor.Core.Domain.Entities
{
    public class RecipeIngredient : AuditableEntity
    {
        [Key]
        [Comment("Primary key for the RecipeIngredient entity.")]
        public int Id { get; set; }

        [ForeignKey("Id")]
        [Comment("Foreign key to the Recipe entity.")]
        public int RecipeId { get; set; }

        [Comment("Navigation property to the Recipe entity.")]
        public Recipe Recipe { get; set; } = null!;

        [ForeignKey("Id")]
        [Comment("Foreign key to the required Item for this ingredient.")]
        public int IngredientItemId { get; set; }

        [Comment("Navigation property to the required Item for this ingredient.")]
        public Item IngredientItem { get; set; } = null!;

        [Comment("The quantity of the ingredient item required.")]
        public int QuantityRequired { get; set; } = 1;
    }
}
