using System.ComponentModel.DataAnnotations;

namespace VideoGames.Models.DTO
{
    public class CreateGameDto
    {
        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public string Released { get; set; } = string.Empty;

        [Required]
        public string Image { get; set; } = string.Empty;

        public float Rating { get; set; } = 0;

        public string ReqMinim { get; set; } = string.Empty;

        public string ReqRecommended { get; set; } = string.Empty;

        [Required]
        public IList<int> Genres { get; set; } = new List<int>();

        public IList<int> Platforms { get; set; } = new List<int>();

        public IList<int> Tags { get; set; } = new List<int>();

        public IList<string> ESRBRatings { get; set; } = new List<string>();

        public IList<string> Screenshots { get; set; } = new List<string>();
    }
}
