using System.Collections.Generic;
using System.Linq;
using AutomapperConfiguration.AutoMapperConfig;
using AutoMapper;

namespace AutomapperConfiguration
{
    public class PeopleService
    {
        private readonly IMapper _mapper;
        private readonly IEnumerable<Person> _people;
        public PeopleService(IEnumerable<Person> people, IAutoMapperConfiguration autoMapperConfiguration)
        {
            _people = people;
            _mapper = autoMapperConfiguration.Configure().CreateMapper();
        }

        public IList<NewsletterDto> GetPeopleForNewsletter()
        {
            var peopleAssignedToNewsletter = _people.Where(e => e.AssignedToNewsletter);
            var result = _mapper.Map<IEnumerable<Person>, IList<NewsletterDto>>(peopleAssignedToNewsletter);
            return result;
        }
    }
}
