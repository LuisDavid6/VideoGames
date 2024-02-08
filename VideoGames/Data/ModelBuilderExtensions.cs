using Microsoft.EntityFrameworkCore;
using System;
using VideoGames.Models;

namespace VideoGames.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //GENRES
            var action = new Genre { Id = 1, Name = "Action" };
            var adventure = new Genre { Id = 2, Name = "Adventure" };
            var rpg = new Genre { Id = 3, Name = "RPG" };
            var shooter = new Genre { Id = 4, Name = "Shooter" };
            var racing = new Genre { Id = 5, Name = "Racing" };
            var sports = new Genre { Id = 6, Name = "Sports" };
            var fighting = new Genre { Id = 7, Name = "Fighting" };
            var strategy = new Genre { Id = 8, Name = "Strategy" };
            var casual = new Genre { Id = 9, Name = "Casual" };
            var simulation = new Genre { Id = 10, Name = "Simulation" };
            var puzzle = new Genre { Id = 11, Name = "Puzzle" };
            var arcade = new Genre { Id = 12, Name = "Arcade" };
            var indie = new Genre { Id = 13, Name = "Indie" };
            var family = new Genre { Id = 14, Name = "Family" };
            var educational = new Genre { Id = 15, Name = "Educational" };
            var card = new Genre { Id = 16, Name = "Card" };

            //PLATFORMS
            var play3 = new Platform { Id = 1, Name = "PlayStation 3" };
            var play4 = new Platform { Id = 2, Name = "PlayStation 4" };
            var play5 = new Platform { Id = 3, Name = "PlayStation 5" };
            var xbox360 = new Platform { Id = 4, Name = "Xbox 360" };
            var xboxOne = new Platform { Id = 5, Name = "Xbox One" };
            var xboxSeriesSX = new Platform { Id = 6, Name = "Xbox Series S/X" };
            var nintendoSwitch = new Platform { Id = 7, Name = "Nintendo Switch" };
            var iOS = new Platform { Id = 8, Name = "iOS" };
            var android = new Platform { Id = 9, Name = "Android" };
            var pc = new Platform { Id = 10, Name = "PC" };

            //TAGS
            var singleplayer = new Tag { Id = 1, Name = "Singleplayer" };
            var multiplayer = new Tag { Id = 2, Name = "Multiplayer" };
            var atmospheric = new Tag { Id = 3, Name = "Atmospheric" };
            var cooperative = new Tag { Id = 4, Name = "Cooperative" };
            var openWorld = new Tag { Id = 5, Name = "Open World" };
            var firstPerson = new Tag { Id = 6, Name = "First Person" };
            var thirdPerson = new Tag { Id = 7, Name = "Third Person" };
            var funny = new Tag { Id = 8, Name = "Funny" };
            var comedy = new Tag { Id = 9, Name = "Comedy" };
            var crime = new Tag { Id = 10, Name = "Crime" };
            var fantasy = new Tag { Id = 11, Name = "Fantasy" };
            var medieval = new Tag { Id = 12, Name = "Medieval" };
            var magic = new Tag { Id = 13, Name = "Magic" };

            //GAMES
            var gtaV = new Game
            {
                Id = 1,
                Title = "Grand Theft Auto V",
                Description = "<p>Rockstar Games went bigger, since their previous installment of the series. You get the complicated and realistic world-building from Liberty City of GTA4 in the setting of lively and diverse Los Santos, from an old fan favorite GTA San Andreas. 561 different vehicles (including every transport you can operate) and the amount is rising with every update. <br />\\nSimultaneous storytelling from three unique perspectives: <br />\\nFollow Michael, ex-criminal living his life of leisure away from the past, Franklin, a kid that seeks the better future, and Trevor, the exact past Michael is trying to run away from. <br />\\nGTA Online will provide a lot of additional challenge even for the experienced players, coming fresh from the story mode. Now you will have other players around that can help you just as likely as ruin your mission. Every GTA mechanic up to date can be experienced by players through the unique customizable character, and community content paired with the leveling system tends to keep everyone busy and engaged.</p>",
                Released = "2013-09-17",
                Image = "https://media.rawg.io/media/games/20a/20aa03a10cda45239fe22d035c0ebe64.jpg",
                ReqMinim = "<p>OS: Windows 10 64 Bit, Windows 8.1 64 Bit, Windows 8 64 Bit, Windows 7 64 Bit Service Pack 1, Windows Vista 64 Bit Service Pack 2* (*NVIDIA video card recommended if running Vista OS) <br/> Processor: Intel Core 2 Quad CPU Q6600 @ 2.40GHz (4 CPUs) / AMD Phenom 9850 Quad-Core Processor (4 CPUs) @ 2.5GHzMemory: 4 GB RAM <br/> Graphics: NVIDIA 9800 GT 1GB / AMD HD 4870 1GB (DX 10, 10.1, 11) <br/> Storage: 72 GB available spaceSound Card: 100% DirectX 10 compatibleAdditional Notes: Over time downloadable content and programming changes will change the system requirements for this game. <br/> Please refer to your hardware manufacturer and www.rockstargames.com/support for current compatibility information. Some system components such as mobile chipsets, integrated, and AGP graphics cards may be incompatible. Unlisted specifications may not be supported by publisher. <br/> Other requirements:  Installation and online play requires log-in to Rockstar Games Social Club (13+) network; internet connection required for activation, online play, and periodic entitlement verification; software installations required including Rockstar Games Social Club platform, DirectX, Chromium, and Microsoft Visual C++ 2008 sp1 Redistributable Package, and authentication software that recognizes certain hardware attributes for entitlement, digital rights management, system, and other support purposes. <br/> SINGLE USE SERIAL CODE REGISTRATION VIA INTERNET REQUIRED; REGISTRATION IS LIMITED TO ONE ROCKSTAR GAMES SOCIAL CLUB ACCOUNT (13+) PER SERIAL CODE; ONLY ONE PC LOG-IN ALLOWED PER SOCIAL CLUB ACCOUNT AT ANY TIME; SERIAL CODE(S) ARE NON-TRANSFERABLE ONCE USED; SOCIAL CLUB ACCOUNTS ARE NON-TRANSFERABLE. <br/> Partner Requirements:  Please check the terms of service of this site before purchasing this software.</p>",
                ReqRecommended = "<p>OS: Windows 10 64 Bit, Windows 8.1 64 Bit, Windows 8 64 Bit, Windows 7 64 Bit Service Pack 1 <br/> Processor: Intel Core i5 3470 @ 3.2GHz (4 CPUs) / AMD X8 FX-8350 @ 4GHz (8 CPUs) <br/> Memory: 8 GB RAM <br/> Graphics: NVIDIA GTX 660 2GB / AMD HD 7870 2GB <br/> Storage: 72 GB available spaceSound <br/> DirectX 10.</p>",
                ESRBRatings = ["Mature"],
                Screenshots = [
                  "https://media.rawg.io/media/screenshots/a7c/a7c43871a54bed6573a6a429451564ef.jpg",
                  "https://media.rawg.io/media/screenshots/cf4/cf4367daf6a1e33684bf19adb02d16d6.jpg",
                  "https://media.rawg.io/media/screenshots/f95/f9518b1d99210c0cae21fc09e95b4e31.jpg",
                  "https://media.rawg.io/media/screenshots/a5c/a5c95ea539c87d5f538763e16e18fb99.jpg",
                  "https://media.rawg.io/media/screenshots/a7e/a7e990bc574f4d34e03b5926361d1ee7.jpg",
                  "https://media.rawg.io/media/screenshots/592/592e2501d8734b802b2a34fee2df59fa.jpg"
                ]
            };

            modelBuilder.Entity<Genre>()
                .HasData( 
                    [ action, adventure, rpg, shooter, racing, sports, fighting, strategy, casual, simulation, puzzle, arcade, indie, family, educational, card]
                );

            modelBuilder.Entity<Platform>()
                .HasData(
                    [play3, play4, play5, xbox360, xboxOne, xboxSeriesSX, pc, nintendoSwitch, android, iOS]
                );
           
            modelBuilder.Entity<Tag>()
                .HasData(
                    [singleplayer, multiplayer, atmospheric, cooperative, openWorld, firstPerson, thirdPerson, funny, comedy, crime, fantasy, medieval, magic]
                );

            modelBuilder.Entity<Game>()
                .HasData( 
                    [ gtaV ] 
                );

            modelBuilder.Entity("GameGenre")
                .HasData(
                    new Dictionary<string, object> { ["GamesId"] = gtaV.Id, ["GenresId"] = action.Id }
                );

            modelBuilder.Entity("GamePlatform")
                .HasData(
                    new Dictionary<string, object> { ["GamesId"] = gtaV.Id, ["PlatformsId"] = play3.Id },
                    new Dictionary<string, object> { ["GamesId"] = gtaV.Id, ["PlatformsId"] = play4.Id },
                    new Dictionary<string, object> { ["GamesId"] = gtaV.Id, ["PlatformsId"] = play5.Id },
                    new Dictionary<string, object> { ["GamesId"] = gtaV.Id, ["PlatformsId"] = xbox360.Id },
                    new Dictionary<string, object> { ["GamesId"] = gtaV.Id, ["PlatformsId"] = xboxOne.Id },
                    new Dictionary<string, object> { ["GamesId"] = gtaV.Id, ["PlatformsId"] = xboxSeriesSX.Id },
                    new Dictionary<string, object> { ["GamesId"] = gtaV.Id, ["PlatformsId"] = pc.Id }
                );

            modelBuilder.Entity("GameTag")
                .HasData(
                    new Dictionary<string, object> { ["GamesId"] = gtaV.Id, ["TagsId"] = singleplayer.Id },
                    new Dictionary<string, object> { ["GamesId"] = gtaV.Id, ["TagsId"] = multiplayer.Id },
                    new Dictionary<string, object> { ["GamesId"] = gtaV.Id, ["TagsId"] = cooperative.Id },
                    new Dictionary<string, object> { ["GamesId"] = gtaV.Id, ["TagsId"] = openWorld.Id },
                    new Dictionary<string, object> { ["GamesId"] = gtaV.Id, ["TagsId"] = thirdPerson.Id },
                    new Dictionary<string, object> { ["GamesId"] = gtaV.Id, ["TagsId"] = crime.Id }
                );


        }
    }
}
