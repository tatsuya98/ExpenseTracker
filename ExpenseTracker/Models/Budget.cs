using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models
{
    public class Budget
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        [Column(TypeName = "decimal(9,2)")]
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public User User { get; set; }
    }

}
