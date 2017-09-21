using AutoMapper;

namespace AutomapperConfiguration.AutoMapperConfig.Profiles
{
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<Person, DisplayedPersonDto>();
            CreateMap<Person, NewsletterDto>();
        }
    }
}
