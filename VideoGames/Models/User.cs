using System.ComponentModel.DataAnnotations;

namespace VideoGames.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        public string UserName { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
