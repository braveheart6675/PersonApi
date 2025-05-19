namespace PersonApi.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string FamilyName { get; set; } = string.Empty;
        public string SocialNumber { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
    }
}
