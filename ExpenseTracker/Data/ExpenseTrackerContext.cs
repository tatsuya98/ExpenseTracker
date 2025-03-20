using ExpenseTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Data;

public class ExpenseTrackerContext: DbContext
{
    public ExpenseTrackerContext(DbContextOptions<ExpenseTrackerContext> options): base(options) { }
    
    public DbSet<Budget> Budgets { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Expense> Expenses { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Budget>().ToTable("Budget");
        modelBuilder.Entity<User>().ToTable("User");
        modelBuilder.Entity<Expense>().ToTable("Expense");
        modelBuilder.Entity<Category>().ToTable("Category");
    }
}