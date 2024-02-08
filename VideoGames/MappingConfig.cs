using AutoMapper;
using VideoGames.Models;
using VideoGames.Models.DTO;

namespace VideoGames
{
    public class MappingConfig: Profile
    {
        public MappingConfig() 
        {
            CreateMap<CreateGameDto, Game>()
                .ForMember(entity => entity.Genres, dto => dto
                    .MapFrom(field => field.Genres
                    .Select(id => new Genre { Id = id} )))
                .ForMember(entity => entity.Tags, dto => dto
                    .MapFrom(field => field.Tags
                    .Select(id => new Tag { Id = id })))
                .ForMember(entity => entity.Platforms, dto => dto
                    .MapFrom(field => field.Platforms
                    .Select(id => new Platform { Id = id })))
                .ReverseMap();

            CreateMap<CreateGenreDto, Genre>().ReverseMap();
            CreateMap<CreateCommentDto, Comment>().ReverseMap();
            CreateMap<CreatePlatformDto, Platform>().ReverseMap();
            CreateMap<CreateTagDto, Tag>().ReverseMap();
            CreateMap<AddFavoriteGameDto, FavoriteGame>().ReverseMap();


        }
    }
}
