using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

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
        public int UserId { get; set; }

        public virtual User User { get; set; } = new User();

        [Required]
        public int GameId { get; set; }

        public virtual Game Game { get; set; } = new Game();
    }
}
