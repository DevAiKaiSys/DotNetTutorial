using Application.Features;
using AutoMapper;
using Domain.Entities;

namespace Application.Proflies
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // required mapping here

            _ = CreateMap<Blog, BlogDto>().
                //.ForMember(des => des.Title, opt => opt.MapForm(src => src.Name))
                ReverseMap();
        }
    }
}
