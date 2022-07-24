using EFCore.Helper;
using Microsoft.EntityFrameworkCore;

namespace Log.Min.Data;

public class LogDbContext
    : DbContextExtended
{
    public DbSet<LogModel>? Log { get; set; }

    //todo: make this virtual
    protected override void SeedData(ModelBuilder builder)
    {
    }
}