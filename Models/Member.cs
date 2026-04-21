namespace Library.Models
{
    public class Member
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime MembershipDate { get; set; }
    }
}