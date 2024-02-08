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
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<FavoriteGame> FavoritesGames { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<FavoriteGame>().HasKey(fg => new { fg.UserId, fg.GameId });

            modelBuilder.Seed();

            base.OnModelCreating(modelBuilder);
        }

        


    }
}
