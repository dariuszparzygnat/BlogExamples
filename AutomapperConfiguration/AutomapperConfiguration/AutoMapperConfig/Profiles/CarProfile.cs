using AutoMapper;

namespace AutomapperConfiguration.AutoMapperConfig.Profiles
{
    public class CarProfile : Profile
    {
        public CarProfile()
        {
            CreateMap<Car, DisplayedCarDto>();
            CreateMap<Car, CarPerformanceDto>().ReverseMap();
        }
    }
}
