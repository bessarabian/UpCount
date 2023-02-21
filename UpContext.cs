using Microsoft.EntityFrameworkCore;
using UpCount;

public class UpContext : DbContext
{
    public DbSet<Expense> Expenses => Set<Expense>();
    public DbSet<Category> Categories => Set<Category>();

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        if (!options.IsConfigured)
        {
            options.UseSqlite("Data Source=C:\\Users\\gerem\\Desktop\\UpCount\\bin\\Debug\\net6.0-windows\\database.db");
        }
    }

    public UpContext()
    {
        Database.Migrate();
    }
}