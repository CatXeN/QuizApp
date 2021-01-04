using AutoMapper;
using QuizAppModels.Models.Entities;
using QuizAppModels.Models.Informations;

namespace QuizAppGameApi.MappingProfile
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<QuizHistory, QuizHistoryInformation>().ReverseMap();
            CreateMap<Quiz, QuizInformation>().ReverseMap();
        }
    }
}
