namespace ExpenseTracker.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime ExpenseDate { get; set; } = DateTime.Now.ToUniversalTime();
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
