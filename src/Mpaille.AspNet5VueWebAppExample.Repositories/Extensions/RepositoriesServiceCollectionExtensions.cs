using Microsoft.Extensions.DependencyInjection;
using Mpaille.AspNet5VueWebAppExample.Repositories.Core;
using Mpaille.AspNet5VueWebAppExample.Repositories.Interfaces;

namespace Mpaille.AspNet5VueWebAppExample.Repositories.Extensions
{
    public static class RepositoriesServiceCollectionExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddSingleton<IProductRepository, ProductRepository>();
            services.AddSingleton<IRepositories, Core.Repositories>();
        }
    }
}
