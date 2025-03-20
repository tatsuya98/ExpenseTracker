namespace ExpenseTracker.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public ICollection<Expense> Expenses { get; set; }
    }
}
