using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VideoGames.Models
{
    public class FavoriteGame
    {

        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; } = new User();
        
        public int GameId { get; set; }
        
        public Game Game { get; set; } = new Game();

    }
}
