using EFCore.Helper;
using Microsoft.EntityFrameworkCore;

namespace Log.Min.Data;

public class LogDbContext
    : DbContextDbConfig
{
    public DbSet<LogModel>? Log { get; set; }
    public DbSet<Task>? Task { get; set; }
    public DbSet<Category>? Category { get; set; }
    public DbSet<Place>? Place { get; set; }

    protected override void SeedData(ModelBuilder builder)
    {
    }
}