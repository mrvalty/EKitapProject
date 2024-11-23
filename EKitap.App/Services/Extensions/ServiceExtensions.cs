using EKitap.Dom.Repositories;
using EKitap.Inf.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace EKitap.App.Services.Extensions;
public static class ServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        //Repository katmanını ekler.
        services.AddScoped<IKitapRepository, KitapRepository>();

        //Service katmanını ekler.
        //services.AddScoped<IKullaniciService, KullaniciService>();

        return services;
    }
}
