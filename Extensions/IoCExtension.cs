using System.Reflection;
using Encinecarlos.CountryPedia.Infrastructure.Interfaces;
using Encinecarlos.CountryPedia.Infrastructure.Services;
using MediatR;

namespace Encinecarlos.CountryPedia.Extensions
{
    public static class IoCExtension
    {
        public static void AddIoC(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddHttpClient();

            services.AddScoped<IHttpService, HttpService>();
        } 
    }
}