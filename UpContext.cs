using Microsoft.EntityFrameworkCore;
using UpCount;

public class UpContext : DbContext
{
    public DbSet<Expense> Expenses => Set<Expense>();
    public UpContext() => Database.EnsureCreated();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(DB_Control.GetConnectionString());
    }
}