using Microsoft.EntityFrameworkCore;
using VideoGames.Models;

namespace VideoGames.Data
{
    public class VideoGamesDBContext : DbContext
    {
        public VideoGamesDBContext(DbContextOptions<VideoGamesDBContext> options): base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}
