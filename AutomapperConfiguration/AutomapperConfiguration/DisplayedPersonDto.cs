namespace AutomapperConfiguration
{
    public class DisplayedPersonDto
    {
        public string PersonalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => LastName + " " + FirstName;
    }
}
