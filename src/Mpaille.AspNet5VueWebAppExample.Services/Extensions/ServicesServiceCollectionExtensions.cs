using Microsoft.Extensions.DependencyInjection;
using Mpaille.AspNet5VueWebAppExample.Services.Core;
using Mpaille.AspNet5VueWebAppExample.Services.Interfaces;

namespace Mpaille.AspNet5VueWebAppExample.Services.Extensions
{
    public static class ServicesServiceCollectionExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddSingleton<IServices>();
            services.AddSingleton<IProductService, ProductService>();
        }
    }
}
