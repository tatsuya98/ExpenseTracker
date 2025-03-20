
using ExpenseTracker.Models;

namespace ExpenseTracker.Data;

public static class DbInitialiser
{
        public static void Initialize(ExpenseTrackerContext context)
    {
        // Look for any students.
        if (context.Users.Any())
        {
            return;   // DB has been seeded
        }
        
        var users = new User[]
        {
            new User { Id = 1, Username = "John" },
            new User { Id = 2, Username = "Jane" }, 
            new User { Id = 3, Username = "Bob" },
        };

        context.Users.AddRange(users);
        context.SaveChanges();
        
        var budgets = new Budget[]
        {
            new Budget { Id = 1, UserId = 1, Amount = 100, Description = "Monthly games budget"},
            new Budget { Id = 2, UserId = 2, Amount = 200, Description = "Monthly movies budget"},
            new Budget { Id = 3, UserId = 3,Amount = 300 , Description = "Monthly books budget"},
            new Budget { Id = 4, UserId = 3, Amount = 400, Description = "Monthly food budget"},
            new Budget { Id = 5, UserId = 1, Amount = 500, Description = "Monthly clothes budget"},
            new Budget { Id = 6, UserId = 2,Amount = 600, Description = "Monthly transportation budget"},
            
        };

        context.Budgets.AddRange(budgets);
        context.SaveChanges();

        var categories = new Category[]
        {
            new Category { Id = 1, CategoryName = "Groceries" },
            new Category { Id = 2, CategoryName = "Entertainment" },
            new Category { Id = 3, CategoryName = "Restaurants" },
            new Category { Id = 4, CategoryName = "Clothing" },
            new Category { Id = 5, CategoryName = "Utilities" },
            new Category { Id = 6, CategoryName = "Transportation" },
            new Category { Id = 7, CategoryName = "Healthcare" },
        };

        context.Categories.AddRange(categories);
        context.SaveChanges();

        var expenses = new Expense[]
        {
            new Expense { Id = 1, CategoryId = 1, UserId = 1, Amount = 50 },
            new Expense { Id = 2, CategoryId = 2, UserId = 2, Amount = 75, },
            new Expense { Id = 3, CategoryId = 3, UserId = 3,Amount = 100, },
            new Expense { Id = 4, CategoryId = 4, UserId = 1, Amount = 125, },
        };

        context.Expenses.AddRange(expenses);
        context.SaveChanges();
    }
}