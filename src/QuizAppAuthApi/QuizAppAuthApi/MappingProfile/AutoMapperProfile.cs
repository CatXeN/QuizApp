using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
