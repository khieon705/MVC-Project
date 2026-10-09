namespace WebApplication1.Models
{
    public class CardViewModel
    {
        public string LastName { get; set; } = "";
        public string FirstName { get; set; } = "";
        public Address Address { get; set; } = new Address();
        public Sex Sex { get; set; } = Sex.Male;
        public List<string> Skills { get; set; } = new List<string>();
        public DateOnly DateOfBirth { get; set; } = new DateOnly();
        public string Email { get; set; } = "";
        public string CardNumber { get; set; } = "";
        public string School { get; set; } = "";
        public string Program { get; set; } = "";
        public string CivilStatus { get; set; } = "";
        public string PictureUrl { get; set; } = "";
        public string ProjectQRUrl { get; set; } = "";
    }
}
