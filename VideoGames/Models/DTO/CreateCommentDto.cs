using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VideoGames.Models.DTO
{
    public class CreateCommentDto
    {
        [Required]
        public string Content { get; set; } = string.Empty;

        [Required]
        public int UserId { get; set; }

        [Required]
        public int GameId { get; set; }
    }
}
