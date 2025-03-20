using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models
{
    public class Expense
    {
        public int Id { get; set; }
        [Column(TypeName = "decimal(9,2)")]
        public decimal Amount { get; set; }
        public DateTime ExpenseDate { get; set; } = DateTime.Now.ToUniversalTime();
        public int CategoryId { get; set; }
        public int UserId { get; set; }
        public Category Category { get; set; }
        public User User { get; set; }
    }
}
