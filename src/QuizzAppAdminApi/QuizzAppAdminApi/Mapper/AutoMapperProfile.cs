using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using QuizAppModels.Models.Entities;
using QuizAppModels.Models.Informations;

namespace QuizzAppAdminApi.Mapper
{
    public class AutoMapperProfile : Profile
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
