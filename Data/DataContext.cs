using dotnet_rpg.Entities;

namespace dotnet_rpg.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    public DbSet<Character> Characters => Set<Character>();
    // public DbSet<Character> Characters {get; set;};
}
