﻿using AutoMapper;
using testServerless.Models;
using testServerless.ViewModel;

namespace testServerless.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateAutoViewModel, Auto>()
                .ReverseMap();

            CreateMap<UpdateAutoViewModel, Auto>()
               .ReverseMap();

            CreateMap<GetAutoViewModel, Auto>()
               .ReverseMap();
        }
    }
}
