using AutomapperConfiguration.AutoMapperConfig.Profiles;
using AutoMapper;

namespace AutomapperConfiguration.AutoMapperConfig
{
    public class AutoMapperConfiguration : IAutoMapperConfiguration
    {
        public MapperConfiguration Configure()
        {
            var config = new MapperConfiguration(cfg =>
            {
                // HERE YOU CAN CONFIGURE YOUR MAPPINGS
                cfg.AddProfile<CarProfile>();
                cfg.AddProfile<PersonProfile>();
            });
            return config;
        }
    }
}
