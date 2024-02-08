using System.ComponentModel.DataAnnotations;

namespace VideoGames.Models.DTO
{
    public class CreateGenreDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
