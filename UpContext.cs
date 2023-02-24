using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using UpCount;

public class UpContext : DbContext
{
    public DbSet<Expense> Expenses => Set<Expense>();
    public DbSet<Category> Categories => Set<Category>();
    public string DbPath { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        

        if (!options.IsConfigured)
        {
            options.UseSqlite($@"Data Source=database.db");
        }
    }

    public UpContext()
    {
        string folder = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
        Database.Migrate();
        Debug.WriteLine(folder);
    }
}