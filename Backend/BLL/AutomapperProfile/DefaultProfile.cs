using ApnaMakaanAPI.BLL.DTOs;
using ApnaMakaanAPI.DAL.Entities;
using AutoMapper;

namespace ApnaMakaanAPI.BLL.AutomapperProfile
{
    public class DefaultProfile : Profile
    {
        public DefaultProfile()
        {
            //For Request / for adding data
            CreateMap<CityRequestDTO, City>();
            CreateMap<ImageRequestDTO, Image>();
            CreateMap<PropertyRequestDTO, Property>();
            CreateMap<UserRequestDTO, user>();

            //For Response / for fetching data
            CreateMap<City, CityResponseDTO>();
            CreateMap<Property, PropertyResponseDTO>();
            CreateMap<user, UserResponseDTO>();
            CreateMap<Image, ImageResponseDTO>();
            CreateMap<City, CityPropertyResponseDTO>();
            CreateMap<FurnishingType, FurnishingTypeWithPropertyResponseDTO>();
            CreateMap<PropertyType, PropertyTypeWithPropertyResponseDTO>();
            CreateMap<PropertyType, PropertyTypeResponseDTO>();
            CreateMap<FurnishingType, FurnishingTypeResponseDTO>();
            CreateMap<user , UserPropertyResponseDTO>();


        }

    }
}
