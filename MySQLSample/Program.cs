using System.ComponentModel.DataAnnotations.Schema;
using Devart.Data.MySql;
using Microsoft.EntityFrameworkCore;

public class Program
{
    private static void Main(string[] args)
    {
        var key = File.ReadAllText("devart.key");
        var connStringBuilder = new MySqlConnectionStringBuilder
        {
            Server = "localhost",
            Database = "grv_dev",
            UserId = "grv_dev_user",
            Password = "Welcome1docker",
            LicenseKey = key
        };

        Console.WriteLine("Connecting to database...");

        using var context = new SampleDataContext(connStringBuilder.ConnectionString);
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
    [Column("_id")] public int Id { get; set; }
    [Column("name")] public string? Name { get; set; }
}