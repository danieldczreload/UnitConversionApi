using UnitConversionApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace UnitConversionApi.Infrastructure.Seeds;

public static class ModelBuilderExtensions
{
    public static void SeedData(this ModelBuilder modelBuilder)
        {
            // Seed for UnitCategories
            modelBuilder.Entity<UnitCategory>().HasData(
                new UnitCategory { Id = 1, Name = "Length" },
                new UnitCategory { Id = 2, Name = "Weight" },
                new UnitCategory { Id = 3, Name = "Temperature" }
            );

            // Seed for Units
            modelBuilder.Entity<Unit>().HasData(
                // Length units
                new Unit 
                { 
                    Id = 1, 
                    Name = "meter", 
                    Factor = 1.0, 
                    UnitCategoryId = 1, 
                    MainReference = true 
                },
                new Unit 
                { 
                    Id = 2, 
                    Name = "kilometer", 
                    Factor = 1000.0, 
                    UnitCategoryId = 1, 
                    MainReference = false 
                },
                new Unit 
                { 
                    Id = 3, 
                    Name = "mile", 
                    Factor = 1609.34, 
                    UnitCategoryId = 1, 
                    MainReference = false 
                },
                // Weight units
                new Unit 
                { 
                    Id = 4, 
                    Name = "kilogram", 
                    Factor = 1.0, 
                    UnitCategoryId = 2, 
                    MainReference = true 
                },
                new Unit 
                { 
                    Id = 5, 
                    Name = "gram", 
                    Factor = 0.001, 
                    UnitCategoryId = 2, 
                    MainReference = false 
                },
                // Temperature units
                new Unit 
                { 
                    Id = 6, 
                    Name = "celsius", 
                    Factor = 1.0, // Para temperaturas, la conversión se hace mediante fórmulas
                    UnitCategoryId = 3, 
                    MainReference = true 
                },
                new Unit 
                { 
                    Id = 7, 
                    Name = "fahrenheit", 
                    Factor = 0.0, // Valor de placeholder; la conversión se realiza con fórmulas específicas
                    UnitCategoryId = 3, 
                    MainReference = false 
                }
            );
        }
}