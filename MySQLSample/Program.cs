using System.ComponentModel.DataAnnotations.Schema;
using Devart.Data.MySql;
using Microsoft.EntityFrameworkCore;

public class Program
{
    private static void Main(string[] args)
    {
        var connStringBuilder = new MySqlConnectionStringBuilder
        {
            Server = "10.0.0.33",
            Database = "sample",
            UserId = "root",
            Password = "Welcome1docker",
            LicenseKey = File.ReadAllText("devart.key").Trim(),
        };

        Console.WriteLine("Connecting to database...");

        using var context = new SampleDataContext(connStringBuilder.ConnectionString);

        Console.WriteLine("Querying database...");
        var count = context.Stores.Count();

        Console.WriteLine($"Number of stores: {count}");
    }
}

public class SampleDataContext(string connectionString) : DbContext
{
    public DbSet<Store> Stores => Set<Store>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        Console.WriteLine("Configuring database context...");
        optionsBuilder.UseMySql(connectionString);
    }
}

[Table("store")]
public class Store
{
    [Column("id")] public int Id { get; set; }
    [Column("name")] public string? Name { get; set; }
}