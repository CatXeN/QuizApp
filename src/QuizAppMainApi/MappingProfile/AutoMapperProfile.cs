using AutoMapper;
using QuizAppModels.Models.Entities;
using QuizAppModels.Models.Informations;

namespace QuizAppMainApi.MappingProfile
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Category, CategoryInformation>().ReverseMap();
            CreateMap<Quiz, QuizInformation>().ReverseMap();
            CreateMap<Quest, QuestInformation>().ReverseMap();
            CreateMap<User, UserInformation>().ReverseMap();
        }
    }
}
