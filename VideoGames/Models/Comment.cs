using System.ComponentModel.DataAnnotations;

namespace VideoGames.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        public string Content { get; set; } = string.Empty;

        [Required]
        public User User { get; set; } = new User();

        [Required]
        public Game Game { get; set; } = new Game();
    }
}
