using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Entities;
using WebApi.Models;

namespace WebApi.Profiles
{
    public class TestMappingProfile : Profile
    {
        public TestMappingProfile()
        {
            CreateMap<TestEntity, TestModel>()
                .ForMember(c => c.Name, opt => opt.MapFrom(m => $"{m.FirstName} {m.LastName}"));
        }
    }
}
