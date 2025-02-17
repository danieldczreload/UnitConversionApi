using Microsoft.EntityFrameworkCore;
using UnitConversionApi.Domain.Entities;
using UnitConversionApi.Infrastructure.Seeds;

namespace UnitConversionApi.Infrastructure.Data;

public class UnitConversionDbContext(DbContextOptions<UnitConversionDbContext> options) : DbContext(options)
{
    public DbSet<UnitCategory> UnitCategories { get; set; }
    public DbSet<Unit> Units { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.SeedData();
        
        modelBuilder.Entity<UnitCategory>()
            .HasMany(uc => uc.Units)
            .WithOne(u => u.UnitCategory)
            .HasForeignKey(u => u.UnitCategoryId);
    }
}