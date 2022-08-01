using EFCore.Helper;
using Microsoft.EntityFrameworkCore;

namespace Log.Min.Data;

public class LogDbContext
    : DbContextExtended
{
    public DbSet<LogModel>? Log { get; set; }
    public DbSet<Task>? Task { get; set; }
    public DbSet<Category>? Category { get; set; }
    public DbSet<Place>? Place { get; set; }

    //todo: make this virtual
    protected override void SeedData(ModelBuilder builder)
    {
    }

    private object GetEntity(
        int id
        , string name
        , string? description = default)
    {
        return new 
        { 
            Id = id
            , Name = name
            , Description = description
            , CreatedDate = DateTime.Now
            , UpdatedDate = DateTime.Now
        };
    }
}