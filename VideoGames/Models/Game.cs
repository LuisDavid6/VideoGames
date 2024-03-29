﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace VideoGames.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }

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

        public IList<int> Ratings { get; set; } = [0,0,0,0,0];

        public ICollection<Genre> Genres { get; set; } = new List<Genre>();

        public ICollection<Platform> Platforms { get; set; } = new List<Platform>();

        public ICollection<Tag> Tags { get; set; } = new List<Tag>();

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();

        public IList<string> ESRBRatings { get; set; } = new List<string>();

        public IList<string> Screenshots { get; set; } = new List<string>();

        [JsonIgnore]
        public ICollection<FavoriteGame> FavoriteGames { get; set; } = new List<FavoriteGame>();
    }
}
