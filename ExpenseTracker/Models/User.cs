namespace ExpenseTracker.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public ICollection<Expense> Expense { get; set; }
        public ICollection<Budget> Budget { get; set; }
    }
}
