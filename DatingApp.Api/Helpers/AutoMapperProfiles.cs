using AutoMapper;
using DatingApp.Api.Dtos;
using DatingApp.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Api.Helpers
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDtos>()
                .ForMember(dest => dest.PhotoUrl,
                    opt => opt.MapFrom(src =>
                        src.Photos.FirstOrDefault(p => p.IsMain).Url))
                .ForMember(dest => dest.Age,
                    opt => opt.MapFrom(src =>
                         src.DOB.CalculateAge())); 
            CreateMap<User, UserForDetailDtos>()
                 .ForMember(dest => dest.PhotoUrl,
                    opt => opt.MapFrom(src =>
                        src.Photos.FirstOrDefault(p => p.IsMain).Url))
                 .ForMember(dest => dest.Age,
                    opt => opt.MapFrom(src =>
                         src.DOB.CalculateAge()));
            CreateMap<Photo, PhotosForDetailDtos>();
        }
    }
}
