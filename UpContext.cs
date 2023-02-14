using Microsoft.EntityFrameworkCore;
using UpCount;

public class UpContext : DbContext
{
    public DbSet<Expense> Expenses => Set<Expense>();
    public string DbPath { get; }
    public UpContext()
    {
        Console.WriteLine("UpContext() inited");
        var folder = Environment.SpecialFolder.LocalApplicationData;
        Console.WriteLine("folder: " + folder);
        var path = Environment.GetFolderPath(folder);
        Console.WriteLine("path: " + path);
        DbPath = Path.Join(path, "blogging.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}