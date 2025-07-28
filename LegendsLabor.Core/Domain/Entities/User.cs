using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace LegendsLabor.Core.Domain.Entities
{
    public class User : AuditableEntity
    {
        [Key]
        [Comment("Primary key for the User entity.")]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Comment("The username for the user.")]
        public string Username { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        [Comment("The email address of the user.")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [MaxLength(255)]
        [Comment("The hashed password of the user for security.")]
        public string PasswordHash { get; set; } = string.Empty;

        [Comment("The date and time when the user registered.")]
        public DateTime RegistrationDate { get; set; }

        [Comment("The date and time when the user last logged in. Nullable.")]
        public DateTime? LastLoginDate { get; set; }

        [Comment("Indicates if the user account is active.")]
        public bool IsActive { get; set; }

        [Comment("The player associated with this user. Nullable.")]
        public Player? Player { get; set; }
    }
}
