using Byte2Byte.Models;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using MongoDB.EntityFrameworkCore.Extensions;

namespace Byte2Byte.Data;

public class ByteDbContext : DbContext
{
    public DbSet<ComparisonModel> Comparisons { get; init; }

    public static ByteDbContext Create(IMongoDatabase database) =>
        new(new DbContextOptionsBuilder<ByteDbContext>()
            .UseMongoDB(database.Client, database.DatabaseNamespace.DatabaseName)
            .Options);

    public ByteDbContext(DbContextOptions options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<ComparisonModel>().ToCollection("Comparisons");
    }
}