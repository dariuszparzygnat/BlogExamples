using System;
using System.Collections.Generic;
using AutomapperConfiguration.AutoMapperConfig;

namespace AutomapperConfiguration
{
    class Program
    {
        static void Main(string[] args)
        {
            var peopleService = new PeopleService(People, new AutoMapperConfiguration());
            var newsletterPeople = peopleService.GetPeopleForNewsletter();
            foreach (var newsletterPerson in newsletterPeople)
            {
                Console.WriteLine(string.Format("Send a newsletter  to {0} {1}. Use following email: {2}", newsletterPerson.FirstName, newsletterPerson.LastName, newsletterPerson.Email));
            }
            Console.ReadKey();
        }

        private static IEnumerable<Person> People
        {
            get
            {
                yield return
                    new Person()
                    {
                        AssignedToNewsletter = true,
                        Email = "jkowalski@gmail.com",
                        FirstName = "Jan",
                        LastName = "Kowalski",
                        PersonalId = "90010106789"
                    };
                yield return
                    new Person()
                    {
                        AssignedToNewsletter = true,
                        Email = "jnowak@gmail.com",
                        FirstName = "Jan",
                        LastName = "Nowak",
                        PersonalId = "90020106789"
                    };
                yield return
                    new Person()
                    {
                        AssignedToNewsletter = false,
                        Email = "adam.bak@gmail.com",
                        FirstName = "Adam",
                        LastName = "Bak",
                        PersonalId = "90022506779"
                    };
            }
        }
    }
}