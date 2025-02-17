using Microsoft.EntityFrameworkCore;
using UnitConversionApi.Infrastructure.Data;
using UnitConversionApi.Presentation.Resolvers;


var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddPooledDbContextFactory<UnitConversionDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services
    .AddGraphQLServer()
    .RegisterDbContextFactory<UnitConversionDbContext>()
    .AddQueryType<UnitsQuery>()
    .AddProjections()   // Permite proyecciones automáticas desde EF Core
    .AddFiltering()     // Habilita filtrado dinámico
    .AddSorting();      // Habilita ordenación dinámica

//builder.Services.AddScoped<IUnitQueryRepository, UnitQueryRepository>();

var app = builder.Build();

app.MapGraphQL();

app.Run();
