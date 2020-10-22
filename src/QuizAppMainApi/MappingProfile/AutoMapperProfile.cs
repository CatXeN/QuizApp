using AutoMapper;
using QuizAppModels.Models.Entities;
using QuizAppModels.Models.Informations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAppMainApi.MappingProfile
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Category, CategoryInformation>().ReverseMap();
            CreateMap<Quiz, QuizInformation>().ReverseMap();
            CreateMap<Quest, QuestInformation>().ReverseMap();
        }
    }
}
