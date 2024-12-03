using PlantGuide.DataAccess.Repository;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.Extensions;

public static class ServiceExtension
{
    public static IServiceCollection AddRepository(this IServiceCollection services)
    {
        services.AddScoped<IClimateRepository, ClimateRepository>();
        services.AddScoped<ICountryRepository, CountryRepository>();
        services.AddScoped<IFamilyRepository, FamilyRepository>();
        services.AddScoped<IOriginRepository, OriginRepository>();
        services.AddScoped<IPhotoRepository, PhotoRepository>();
        services.AddScoped<IPlantRepository, PlantRepository>();
        services.AddScoped<ISourceRepository, SourceRepository>();
        services.AddScoped<ITypeSeasonRepository, TypeSeasonRepository>();

        return services;
    }
    public static IServiceCollection AddBusinessServices(this IServiceCollection services)
    {
        return services;
    }
}
