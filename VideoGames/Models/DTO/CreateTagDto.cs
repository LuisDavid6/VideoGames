using System.ComponentModel.DataAnnotations;

namespace VideoGames.Models.DTO
{
    public class CreateTagDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
