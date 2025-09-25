using AutoMapper;
using JaddooTravel.Dtos.CategoryDtos;
using JaddooTravel.Dtos.DestinationDtos;
using JaddooTravel.Entities;

namespace JaddooTravel.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<Category,ResultCategoryDto>().ReverseMap();
            CreateMap<Category,CreateCategoryDto>().ReverseMap();
            CreateMap<Category,UpdateCategoryDto>().ReverseMap();
            CreateMap<Category,GetCategoryByIdDto>().ReverseMap();


            CreateMap<Destination,GetDestinationByIdDto>().ReverseMap();
            CreateMap<Destination,CreateDestinationDto>().ReverseMap();
            CreateMap<Destination,UpdateDestinationDto>().ReverseMap();
            CreateMap<Destination,ResultDestinationDto>().ReverseMap();
        }
    }
}
