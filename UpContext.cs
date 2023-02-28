using Microsoft.EntityFrameworkCore;
using UpCount;

public class UpContext : DbContext
{
    public DbSet<Expense> Expenses => Set<Expense>();
    public DbSet<Category> Categories => Set<Category>();
    public string DbPath { get; set; }  

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        string currentDirectory = Directory.GetCurrentDirectory();
        DirectoryInfo currentDirectoryInfo = new DirectoryInfo(currentDirectory);
        string grandParentPath = currentDirectoryInfo.Parent.Parent.Parent.FullName;
        if (!options.IsConfigured)
        {
            options.UseSqlite($"Data Source=" + @$"{grandParentPath}\\database.db");
        }
    }

    public UpContext()
    {
        Database.Migrate();
    }
}