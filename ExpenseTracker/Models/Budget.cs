namespace ExpenseTracker.Models
{
    public class Budget
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public decimal Amount { get; set; }
        public Category Category { get; set; }
        public User User { get; set; }
    }

}
