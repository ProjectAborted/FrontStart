namespace Library.Models
{
    public class BorrowRecord
    {
        public Guid Id { get; set; }
        public Guid BookId { get; set; }
        public Guid MemberId { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public String Status { get; set; } // "Borrowed", "Returned"
    }
}