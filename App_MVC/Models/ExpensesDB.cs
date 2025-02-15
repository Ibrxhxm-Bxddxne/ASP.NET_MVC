using Microsoft.EntityFrameworkCore;

namespace App_MVC.Models
{
    public class ExpensesDB : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }

        public ExpensesDB(DbContextOptions<ExpensesDB> options) : base(options)
        {
            
        }
    }
}
