﻿using System.ComponentModel.DataAnnotations;

namespace VideoGames.Models.DTO
{
    public class CreatePlatformDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;

    }
}
