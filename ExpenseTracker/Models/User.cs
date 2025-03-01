namespace ExpenseTracker.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public int ExpenseId { get; set; }
        public int BudgetId { get; set; }
        public ICollection<Expense> Expense { get; set; }
        public ICollection<Budget> Budget { get; set; }
    }
}
