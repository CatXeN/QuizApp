using AutoMapper;
using QuizAppModels.Models.Entities;
using QuizAppModels.Models.Informations;

namespace QuizAppAdminApi.MappingProfile
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Category, CategoryInformation>().ReverseMap();
            CreateMap<Quiz, QuizInformation>().ReverseMap();
            CreateMap<Quest, QuestInformation>().ReverseMap();
            CreateMap<User, UserInformation>().ReverseMap();
            CreateMap<QuizHistory, QuizHistoryInformation>().ReverseMap();
        }
    }
}
