using Mpaille.AspNet5VueWebAppExample.Repositories.Interfaces;

namespace Mpaille.AspNet5VueWebAppExample.Repositories.Core
{
    internal class Repositories : IRepositories
    {
        public Repositories(IProductRepository products)
        {
            Products = products;
        }

        public IProductRepository Products { get; }
    }
}
