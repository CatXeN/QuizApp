using AutoMapper;
using QuizAppAuthApi.Models.Entities;
using QuizAppAuthApi.Models.Informations;

namespace QuizAppAuthApi.MappingProfile
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserInformation>().ReverseMap();
        }
    }
}
