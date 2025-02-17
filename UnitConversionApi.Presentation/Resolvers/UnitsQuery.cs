using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Types;
using Microsoft.EntityFrameworkCore;
using UnitConversionApi.Domain;
using UnitConversionApi.Infrastructure;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnitConversionApi.Domain.Entities;
using UnitConversionApi.Infrastructure.Data;

namespace UnitConversionApi.Presentation.Resolvers;

public class UnitsQuery
{
    // Aquí se habilitan proyección, filtrado y ordenación
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public async Task<IReadOnlyList<Unit>> GetUnits(IDbContextFactory<UnitConversionDbContext> dbContextFactory)
    {
        // Crea un DbContext para la consulta y asegúrate de disponerlo al finalizar
        await using var dbContext = dbContextFactory.CreateDbContext();

        // Materializa la consulta dentro del alcance del DbContext
        return await dbContext.Units
            .Include(u => u.UnitCategory)
            .ToListAsync();
    }
}