using Microsoft.Extensions.DependencyInjection;
using Mpaille.AspNet5VueWebAppExample.Repositories.Extensions;
using Mpaille.AspNet5VueWebAppExample.Services.Core;
using Mpaille.AspNet5VueWebAppExample.Services.Interfaces;

namespace Mpaille.AspNet5VueWebAppExample.Services.Extensions
{
    public static class ServicesServiceCollectionExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddRepositories();
            services.AddSingleton<IProductService, ProductService>();
            services.AddSingleton<IServices, Core.Services>();
        }
    }
}
