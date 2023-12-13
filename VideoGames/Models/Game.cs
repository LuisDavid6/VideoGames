using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace VideoGames.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Released { get; set; } = string.Empty;

        [Required]
        public string Image { get; set; } = string.Empty; 
        
        public float Rating { get; set; }

        public ICollection<string> Platforms { get; set; } = new List<string>();

        public ICollection<string> Genres { get; set; } = new List<string>();

        public ICollection<string> ESRBRatings { get; set; } = new List<string>();

        public ICollection<string> Screenshots { get; set; } = new List<string>();

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();

    }
}
